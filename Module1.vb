Imports System.Data.SqlClient

Module Module1
    Public ds As New DataSet
    'Dim link As String = "Data Source=.\sqlexpress;Initial Catalog=PS02832_Assignment;Integrated Security=True"
    'Dim link As String = "workstation id=hoaiphong123.mssql.somee.com;packet size=4096;user id=phongnhps;pwd=Phong123;data source=hoaiphong123.mssql.somee.com;persist security info=False;initial catalog=hoaiphong123"
    Dim link As String = "workstation id=phong123.mssql.somee.com;packet size=4096;user id=phongnguyen2511_SQLLogin_1;pwd=t5ogveouqe;data source=phong123.mssql.somee.com;persist security info=False;initial catalog=phong123"

    Public Sub excute(sql As String)
        Dim cnn As New SqlConnection(link)
        Dim command As New SqlCommand(sql, cnn)
        cnn.Open()
        command.ExecuteNonQuery()
        cnn.Close()
    End Sub

    Public Sub thucthi(sql As String, tablename As String)
        Dim cnn As New SqlConnection(link)
        Dim adapter As New SqlDataAdapter(sql, cnn)
        If ds.Tables.Contains(tablename) Then
            ds.Tables(tablename).Clear()
        End If
        adapter.Fill(ds, tablename)
        cnn.Close()
    End Sub

   


End Module
