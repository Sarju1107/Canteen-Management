Imports System.Data.SqlClient
Public Class frmdesignationvb
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Rushit\Canteen_Management_System\Canteen_Management_System\Database1.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim qry As String
    Dim i As Integer = 0
    Dim id As String = ""

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If con.State = 1 Then con.Close()
        If txtdn.Text = "" Then txtdn.Focus() : Exit Sub
        Try
            qry = "insert into tbldesignation(id,designation)values('" & txtid.Text & "','" & txtdn.Text & "')"
            i = insertdata(qry)
            If i >= 1 Then
                MsgBox("data inserted successfully...")
                loaddataingrid()
                txtdn.Clear()
                txtdn.Focus()
            Else
                MsgBox("failed...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If con.State = 1 Then con.Close()
        If txtdn.Text = "" Then txtdn.Focus() : Exit Sub
        Try
            qry = "update tbldesignation set designation='" & txtdn.Text & "' where id='" & id & "'"
            i = insertdata(qry)
            If i >= 1 Then
                MsgBox("data updated successfully...", MsgBoxStyle.Information)
                loaddataingrid()
                txtdn.Clear()
                txtdn.Focus()
            Else
                MsgBox("failed...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        If con.State = 1 Then con.Close()
        If txtdn.Text = "" Then txtdn.Focus() : Exit Sub
        If id = "" Then MsgBox("select any for delete") : Exit Sub
        Try
            qry = "delete from tbldesignation where id='" & id & "'"
            i = insertdata(qry)
            If i >= 1 Then
                MsgBox("data deleted successfully", MsgBoxStyle.Information)
                loaddataingrid()
                txtdn.Clear()
                txtdn.Focus()
            Else
                MsgBox("failed...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Dispose()
    End Sub
    Public Sub loaddataingrid()
        If con.State = 1 Then con.Close()
        ds.Clear()
        DataGridView1.DataSource = ds
        DataGridView1.DataSource = Nothing
        qry = "select * from tbldesignation with (nolock)"
        ds = fetchdata(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MessageBox.Show("data not found...")
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        id = ""
        If e.RowIndex >= 0 Then
            Try
                i = DataGridView1.CurrentRow.Index
                id = DataGridView1.Item(0, i).Value
                Me.txtdn.Text = DataGridView1.Item(1, i).Value
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Public Function fetchdata(ByVal qry As String) As DataSet
        If con.State = 1 Then con.Close()
        con.Open()
        da = New SqlDataAdapter(qry, con)
        ds = New DataSet
        da.Fill(ds)
        Return ds
        con.Close()
    End Function
    Public Function insertdata(ByVal qry As String) As Integer
        If con.State = 1 Then con.Close()
        cmd = New SqlCommand(qry, con)
        cmd.Connection.Open()
        i = cmd.ExecuteNonQuery()
        If con.State = 1 Then con.Close()
        Return i
        con.Close()
    End Function
End Class