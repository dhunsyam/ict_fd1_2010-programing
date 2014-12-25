Public Class Frmdbtest

    Private Sub Frmdbtest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'creates a connection object to the cd's database
        Dim cnn As OleDb.OleDbConnection
        'creates the decared as a new database object
        cnn = New OleDb.OleDbConnection()
        'connection string
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\ict_fd1_2010 programing\DBCDSACCESS\CDs.mdb"
        'open string
        cnn.Open()
        'create a command object that selects the object that selects the music catogory from the cd's database
        Dim cmd As OleDb.OleDbCommand
        cmd = New OleDb.OleDbCommand()
        'find the single instance of the catogory
        cmd.CommandText = "select distinct category from tblartists"

        cmd.CommandType = CommandType.Text
        cmd.Connection = cnn
        'create a datareader that reads that reads the music catogory from the cds database
        Dim dr As OleDb.OleDbDataReader
        dr = cmd.ExecuteReader

        'if there are rows in the database then loop through then get the music catrogory
        If dr.HasRows Then
            Do While dr.Read
                Cbomusiccategory.Items.Add(dr("category"))  'adds the catogoyies to the combobox
            Loop
        End If
        'cleaning process dispose of the database objetcs
        cnn.Close()
        cmd.Dispose()
        cnn.Dispose()
    End Sub

    Private Sub Cbomusiccategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbomusiccategory.SelectedIndexChanged
        'creates a connection object to the cd's database
        Dim cnn As OleDb.OleDbConnection
        'creates the decared as a new database object
        cnn = New OleDb.OleDbConnection()
        'connection string
        cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\ict_fd1_2010 programing\DBCDSACCESS\CDs.mdb"
        'open string
        cnn.Open()
        'create a command object that selects the object that selects the music catogory from the cd's database
        Dim cmd As OleDb.OleDbCommand
        cmd = New OleDb.OleDbCommand()
        'find the single instance of the catogory
        cmd.CommandText = "select tblartists.ArtistID,tblartists.artist From tblArtists WHERE tblartists.category= '" & Cbomusiccategory.Text & "'"


        cmd.CommandType = CommandType.Text
        cmd.Connection = cnn


        Dim da As OleDb.OleDbDataAdapter
        da = New OleDb.OleDbDataAdapter()

        Dim dsArtists As DataSet
        dsArtists = New DataSet()

        da.SelectCommand = cmd
        da.Fill(dsArtists, "Artiststable")

        Lsbcds.DataSource = dsArtists.Tables("Artiststable")

        Lsbcds.DisplayMember = "Artist"

        Lsbcds.ValueMember = "ArtistID"

        'cleaning process dispose of the database objetcs
        cnn.Close()

        cnn.Dispose()
    End Sub
End Class
