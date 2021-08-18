Imports System.Data.SqlClient
Public Class frmchangepasswoed
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Rushit\Canteen_Management_System\Canteen_Management_System\Database1.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim qry As String
    Dim i As Integer = 0
    Dim id As String = ""
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If con.State = 1 Then con.Close()
        If txtoldpass.Text = "" Then txtoldpass.Focus() : Exit Sub
        If txtnewpass.Text = "" Then txtnewpass.Focus() : Exit Sub
        If txtcnfpass.Text = "" Then txtcnfpass.Focus() : Exit Sub
        If txtoldpass.Text = Module1.pass Then
            If txtnewpass.Text = txtcnfpass.Text Then
                Try
                    qry = "update tbllogin set password='" & txtnewpass.Text & "'where username='" & Module1.user & "'"
                    i = insertdata(qry)
                    If i >= 1 Then
                        MsgBox("data inserted successfully....")
                        txtcnfpass.Clear()
                        txtnewpass.Clear()
                        txtoldpass.Clear()
                        Module1.user = ""
                        Me.Close()
                        Home_Page.Hide()
                        LoginFrom.Show()
                    Else
                        MsgBox("failed...")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("old password not matched...", MsgBoxStyle.Critical)
            Me.Dispose()
        End If
    End Sub
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