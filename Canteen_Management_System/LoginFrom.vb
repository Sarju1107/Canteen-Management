Imports System.Data.SqlClient
Public Class LoginFrom
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Rushit\Canteen_Management_System\Canteen_Management_System\Database1.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim str As String
    Dim dr As SqlDataReader
    Dim qry As String

   

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If Len(Trim(txtusername.Text)) = 0 Then
            MessageBox.Show("plz enter username", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusername.Clear()
            txtusername.Focus()
            Exit Sub
        ElseIf Len(Trim(txtpassword.Text)) = 0 Then
            MessageBox.Show("plz enter password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword.Clear()
            txtpassword.Focus()

        End If
        Try

            str = "select * from tbllogin where Username=@username and password=@password"
            cmd = New SqlCommand(str, con)
            cmd.Parameters.AddWithValue("@username", txtusername.Text)
            cmd.Parameters.AddWithValue("@password", txtpassword.Text)

            user = txtusername.Text
            pass = txtpassword.Text

            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)


            If ds.Tables(0).Rows.Count > 0 Then

                Dim utype As String
                utype = ds.Tables(0).Rows(0).Item("usertype")
                

                If utype = "admin" Or utype = "manager" Then
                    txtpassword.Clear()
                    txtusername.Clear()
                    Me.Hide()
                    Loadingform.Show()
                ElseIf utype = "user" Or utype = "sales" Then
                    txtpassword.Clear()
                    txtusername.Clear()
                    Me.Hide()
                    Loadingform.Show()
                Else
                    MessageBox.Show("username and password are not valid", "input error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            If con.State = 1 Then con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Dim res As Integer
        res = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Me.txtusername.Clear()
            Me.txtpassword.Clear()
            Me.cmburole.Items.Clear()
            Me.Close()
        End If
    End Sub
End Class
