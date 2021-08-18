Imports System.Data.SqlClient
Class frmstockentry
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Rushit\Canteen_Management_System\Canteen_Management_System\Database1.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim qry As String
    Dim i As Integer = 0
    Dim id As String = ""

        Private Sub frmstockentry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bindcombo()
        loaddataingrid()
        End Sub

        Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If con.State = 1 Then con.Close()
        If txtdesc.Text = "" Then txtdesc.Focus() : Exit Sub
        If txtqnty.Text = "" Then txtqnty.Focus() : Exit Sub
        If cmbselitm.Text = "" Then cmbselitm.Focus() : Exit Sub

        Try
            qry = "insert into tblstock(stockid,itemtitle,quantity,itemdesc)values('" & txtstockid.Text & "','" & cmbselitm.Text & "','" & txtqnty.Text & "','" & txtdesc.Text & "')"
            i = insertdata(qry)
            If i >= 1 Then
                MsgBox("data inserted succesfully....")
                loaddataingrid()
            Else
                MsgBox("failed to insert records....")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        clr()
        End Sub

        Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        Dim result As Integer = MsgBox("do you want to delete?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            If (Label1.Text = "") Then
                MsgBox("select any row from gridview...")
            Else
                Try
                    qry = "delete from tblstock where stockid='" & Label1.Text & "'"
                    i = insertdata(qry)
                    If (i > 0) Then
                        MessageBox.Show("record deleted successfully...")
                    Else
                        MessageBox.Show("record not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    loaddataingrid()
                    clr()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
        End Sub

        Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If con.State = 1 Then con.Close()
        If txtdesc.Text = "" Then txtdesc.Focus() : Exit Sub
        If txtqnty.Text = "" Then txtqnty.Focus() : Exit Sub
        If cmbselitm.Text = "" Then cmbselitm.Focus() : Exit Sub

        Try
            qry = "update tblstock set itemtitle='" & cmbselitm.Text & "',quantity='" & txtqnty.Text & "',itemdesc='" & txtdesc.Text & "' where stockid='" & Label1.Text & "'"
            i = insertdata(qry)
            If i >= 1 Then
                MsgBox("data updated successfully....")
                loaddataingrid()
                clr()
            Else
                MsgBox("failed to update records....")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        End Sub

        Private Sub btnclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclr.Click
        txtstockid.Visible = True
        Label1.Text = "stock id "
        clr()
        End Sub

        Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Try
                txtstockid.Visible = False
                i = DataGridView1.CurrentRow.Index
                Me.Label1.Text = DataGridView1.Item(0, i).Value
                Me.cmbselitm.Text = DataGridView1.Item(1, i).Value
                Me.txtqnty.Text = DataGridView1.Item(2, i).Value
                Me.txtdesc.Text = DataGridView1.Item(3, i).Value


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        End Sub
        Private Sub bindcombo()
        cmbselitm.Items.Clear()
        ds.Clear()
        con.Close()
        qry = "select distinct itemid,itemtitle from tblitem  with(nolock)"
        ds = fetchdata(qry)
            ds = fetchdata(qry)
            If ds.Tables(0).Rows.Count - 1 Then
                Dim a As Integer = ds.Tables(0).Rows.Count - 1
                Dim i As Integer = 0
                For i = 0 To a
                cmbselitm.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
                Next
            Else
                MsgBox("no record found...", MsgBoxStyle.Exclamation)
            End If
    End Sub
    Public Sub loaddataingrid()
        If con.State = 1 Then con.Close()
        qry = "select * from tblstock with(nolock)"
        ds = fetchdata(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("no record found...", MsgBoxStyle.Exclamation)

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
    Public Sub clr()
        txtdesc.Clear()
        txtqnty.Clear()
        txtdesc.Clear()
        cmbselitm.Text = ""
    End Sub

    Private Sub txtqnty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqnty.TextChanged
        txtdesc.Text = txtqnty.Text + "items available"
    End Sub

    Private Sub cmbselitm_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbselitm.MouseClick
        txtstockid.Visible = True
        Label1.Text = "stock id "
        clr()
    End Sub
End Class