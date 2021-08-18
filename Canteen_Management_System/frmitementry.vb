Imports System.Data.SqlClient
Public Class frmitementry
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Rushit\Canteen_Management_System\Canteen_Management_System\Database1.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim qry As String
    Dim i As Integer = 0
    Dim id As String = ""
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

    Private Sub frmitementry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bindcombo()
        loaddataingrid()
    End Sub
    Private Sub bindcombo()
        cmbitemtype.Items.Clear()
        ds.clear()
        qry = "select * from tblitemtype with(nolock)"
        ds = fetchdata(qry)
        If ds.Tables(0).Rows.Count - 1 Then
            Dim a As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To a
                cmbitemtype.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
            Next
        Else
            MsgBox("no record found...", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If con.State = 1 Then con.Close()
        If txttitle.text = "" Then txttitle.focus() : Exit Sub
        If txtcost.Text = "" Then txtcost.Focus() : Exit Sub
        If txtdesc.Text = "" Then txtdesc.Focus() : Exit Sub
        If cmbitemtype.Text = "" Then cmbitemtype.Focus() : Exit Sub
        Try
            qry = "insert into tblitem(itemid,itemtitle,itemtype,cost,itemdesc) values('" & txtitemid.Text & "','" & txttitle.Text & "','" & cmbitemtype.Text & "','" & txtcost.Text & "','" & txtdesc.Text & "')"
            i = insertdata(qry)
            If i >= 1 Then
                MsgBox("data inserted successfully...")
                loaddataingrid()
            Else
                MsgBox("failed to insert data...")
            End If
            clr()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub loaddataingrid()
        If con.State = 1 Then con.Close()
        qry = "select * from tblitem with(nolock)"
        ds = fetchdata(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("no record found...", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Try
                lblitmid.Visible = True
                txtitemid.Visible = False
                i = DataGridView1.CurrentRow.Index
                Me.lblitmid.Text = DataGridView1.Item(0, i).Value
                Me.txttitle.Text = DataGridView1.Item(1, i).Value
                Me.cmbitemtype.Text = DataGridView1.Item(2, i).Value
                Me.txtcost.Text = DataGridView1.Item(3, i).Value
                Me.txtdesc.Text = DataGridView1.Item(4, i).Value
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If con.State = 1 Then con.Close()
        If txttitle.Text = "" Then txttitle.Focus() : Exit Sub
        If txtcost.Text = "" Then txtcost.Focus() : Exit Sub
        If txtdesc.Text = "" Then txtdesc.Focus() : Exit Sub
        If cmbitemtype.Text = "" Then cmbitemtype.Focus() : Exit Sub
        Try
            qry = "update tblitem set itemtitle='" & txttitle.Text & "',itemtype='" & cmbitemtype.Text & "',cost='" & txtcost.Text & "',itemdesc='" & txttitle.Text & "' where itemid='" & lblitmid.Text & "'"
            i = insertdata(qry)
            If i > 0 Then
                MsgBox("data updated successfully...")
                loaddataingrid()

            Else
                MsgBox("failed to update data...")
            End If
            clr()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim result As Integer = MsgBox("do you want to delete?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            If (lblitmid.Text = "") Then
                MsgBox("select any row from gridview...")
            Else
                Try
                    qry = "delete from tblitem where itemid='" & lblitmid.Text & "'"
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
    Private Sub clr()
        txttitle.Clear()
        txtcost.Clear()
        txtdesc.Clear()
        cmbitemtype.Text = ""
    End Sub

    Private Sub btnclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclr.Click
        txtitemid.Visible = True
        lblitmid.Text = "item id:"
        clr()

    End Sub

    Private Sub txttitle_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txttitle.MouseClick
        txtitemid.Visible = True
        lblitmid.Text = "item id:"
    End Sub
End Class