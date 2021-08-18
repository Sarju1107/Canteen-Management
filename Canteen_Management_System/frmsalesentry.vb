Imports System.Data.SqlClient
Public Class frmsalesentry
    Dim cost As String = ""
    Dim maxid As String = ""
    Dim qty As String = ""
    Dim qty2 As String = ""
    Dim tot As String = ""
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Rushit\Canteen_Management_System\Canteen_Management_System\Database1.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim qry As String
    Dim i As Integer = 0
    Dim id As String = ""
    Private Sub frmsalesentry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtdate.Text = Date.Today



    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtname.Text = "" Then txtname.Focus() : Exit Sub
        If txtmob.Text = "" Then txtmob.Focus() : Exit Sub
        maxid = ""
        qry = "insert into tblsalemaster(id,customer,mobile,date) values ('" & txtid.Text & "','" & txtname.Text & "','" & txtmob.Text & "','" & txtdate.Text & "')"
        i = insertdata(qry)
        If i >= 1 Then
            MsgBox("add items into cart", MsgBoxStyle.Information)
            Panel1.Visible = True
            bindcmb()
            getmaxid()
        Else
            MsgBox("failed....", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub bindcmb()
        qry = "Select * From tblitem with(nolock)"
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            cmd = New SqlCommand(qry, con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            'fill dataset with records from table
            Dim ds1 As DataSet = New DataSet()
            sda.Fill(ds1, "tblitem")
            'Dim a As Integer = 
            Dim i As Integer = 0
            cmbitem.Items.Clear()
            For i = 0 To ds1.Tables("tblitem").Rows.Count - 1
                cmbitem.Items.Add(ds1.Tables("tblitem").Rows(i)(1).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("cannot open connection!...")
        End Try
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

    Private Sub cmbitem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbitem.SelectedIndexChanged
        If con.State = 1 Then con.Close()
        txtqnty.Clear()
        btnminus.Enabled = False
        Try
            cmd = New SqlCommand("select * from [tblitem]with(nolock)where itemtitle='" & cmbitem.Text & "'", con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read() Then
                txtcost.text = dr1.Item("cost").ToString
                cost = dr1.Item("cost").ToString
                txtqnty.Focus()
            Else
                MsgBox("price not found...")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If con.State = 1 Then con.Close()
    End Sub

    Private Sub txtqnty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqnty.TextChanged
        If txtqnty.Text = "" Then
            txtcost.Text = cost
        Else
            txtcost.Text = Convert.ToInt32(txtqnty.Text) * Convert.ToInt32(txtcost.Text)
            txtcost.ReadOnly = True

        End If
    End Sub

    Private Sub btnplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplus.Click
        If txtqnty.Text = "" Then txtqnty.Focus() : Exit Sub
        btnminus.Enabled = False
        checkstock()

        If Val(qty) >= Val(txtqnty.Text) Then
            qry = "insert into tblsaletemp(saleid,id,itemname,quantity,totalcost)values('" & txtid.Text & "','" & maxid & "','" & cmbitem.Text & "','" & txtqnty.Text & "','" & txtcost.Text & "')"
            i = insertdata(qry)
            If i >= 1 Then
                MsgBox("one item is added into cart", MsgBoxStyle.Information)
                updateqty()
                showitemgrid()
            Else
                MsgBox("failed...", MsgBoxStyle.Critical)

            End If
        End If
    End Sub
    Public Sub checkstock()
        If con.State = 1 Then con.Close()
        Try
            cmd = New SqlCommand("select * from [tblstock] with (nolock) where itemtitle='" & cmbitem.Text & "'", con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read() Then
                qty = dr1.Item("quantity").ToString
            Else
                MsgBox("data is not available...")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub updateqty()
        If con.State = 1 Then con.Close()
        If Val(qty) >= Val(txtqnty.Text) Then
            qty2 = Val(qty) - Val(txtqnty.Text)
            qry = "update tblstock set quantity='" & qty2 & "'where itemtitle='" & cmbitem.Text & "'"
            i = insertdata(qry)
            If i >= 1 Then

            Else
                MsgBox("failed...")
            End If
        Else
            MsgBox("items out of stock...", MsgBoxStyle.Critical)
            Exit Sub


        End If
    End Sub
    Public Sub showitemgrid()
        If con.State = 1 Then con.Close()
        ds.Dispose()
        If maxid = "" Then
            'Exit sub
        End If
        qry = "select * from tblsaletemp with (nolock) where id='" & maxid & "'"
        con.Open()
        ds = fetchdata(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
            caltotal()
        Else
            MessageBox.Show("data not found...")
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
    Public Sub caltotal()
        Dim totamount As Integer = 0
        Dim a As Integer = 0
        For a = 0 To DataGridView1.Rows.Count - 1
            totamount += DataGridView1.Rows(a).Cells("totalcost").Value
        Next
        txttotal.text = totamount
    End Sub
    Public Sub getmaxid()
        maxid = ""
        If con.State = 1 Then con.Close()
        Try
            cmd = New SqlCommand("select top 1 MAX(ID) as maxid from tblsalemaster", con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read() Then
                maxid = dr1.Item("maxid").ToString

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If con.State = 1 Then con.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        qry = "update tblsalemaster set totalsale='" & txttotal.Text & "' where id='" & maxid & "'"
        i = insertdata(qry)
        If i >= 1 Then
            MsgBox("successfully order done...", MsgBoxStyle.Information)
            txtname.Clear()
            txtmob.Clear()
            cmbitem.Text = ""
            txtqnty.Clear()
            txtcost.Text = "0"
            txtramt.Text = "0"
            txtramt.Text = "0"
            txtdamt.Text = "0"
            txtcamt.Text = "0"
            Panel1.Visible = False
            txtname.Focus()

            ds.Clear()
            DataGridView1.DataSource = ds
            DataGridView1.DataSource = Nothing

        Else
            MsgBox("failed", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txtramt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtramt.TextChanged
        If txtramt.Text <> "" Then
            If Val(txtramt.Text) > Val(txttotal.Text) Then
                txtcamt.Text = Val(txtramt.Text) - (txttotal.Text)
                txtdamt.Text = 0
            ElseIf Val(txtramt.Text) < Val(txttotal.Text) Then
                txtdamt.Text = Val(txttotal.Text) - (txtramt.Text)
                txtcamt.Text = 0
            End If
        Else
            txtdamt.Text = 0
            txtcamt.Text = 0

        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Try
                i = DataGridView1.CurrentRow.Index
                id = DataGridView1.Item(0, i).Value
                Me.cmbitem.Text = DataGridView1.Item(2, i).Value
                Me.txtqnty.Text = DataGridView1.Item(3, i).Value
                Me.txtcost.Text = DataGridView1.Item(4, i).Value
                btnminus.Enabled = True

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnminus.Click
        If id = "" Then
            MsgBox("select any item that you want to delete", MsgBoxStyle.Critical)
        Else
            Try
                qry = "delete from tblsaletemp with (nolock) where id='" & maxid & "'"
                i = insertdata(qry)
                If (i > 0) Then
                    DataGridView1.DataSource = ds.Tables(0)
                    caltotal()
                Else
                    MessageBox.Show("data not found", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                MsgBox("item delete from cart", MsgBoxStyle.Exclamation)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        btnminus.Enabled = False
    End Sub

    Private Sub txtname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtname.LostFocus
        Dim sname As String = "^[a-zA-Z\s]+$"
        Dim rsname As New System.Text.RegularExpressions.Regex(sname) 'Attach Pattern To Surname Textbox

        'Not A Match
        If Not rsname.IsMatch(txtname.Text) Then
            lblerror.Visible = True
            lblerror.Text = "Please Enter Alphabetic Characters Only!"

            txtname.Focus()

            txtname.Clear()

            sname = False

        Else
            lblerror.Visible = False
            sname = True

        End If
    End Sub

    Private Sub txtmob_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmob.LostFocus
        Dim sname As String = "^[0-9\s]+$"
        Dim rsname As New System.Text.RegularExpressions.Regex(sname) 'Attach Pattern To Surname Textbox

        'Not A Match
        If Not rsname.IsMatch(txtmob.Text) Then
            lblerror.Visible = True
            lblerror.Text = "Please Enter 10 Digits Only!"

            txtmob.Focus()

            txtmob.Clear()

            sname = False

        Else
            lblerror.Visible = False
            sname = True

        End If
    End Sub

   
End Class