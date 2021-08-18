

Imports System.Data.SqlClient
Public Class AddEmployee
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Rushit\Canteen_Management_System\Canteen_Management_System\Database1.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim qry As String
    Dim i As Integer = 0
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
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtename.Text = "" Then txtename.Focus() : Exit Sub
        If txtmob.Text = "" Then txtmob.Focus() : Exit Sub
        If txtdob.Text = "" Then txtdob.Focus() : Exit Sub
        If txtsal.Text = "" Then txtsal.Focus() : Exit Sub
        If txtemail.Text = "" Then txtemail.Focus() : Exit Sub
        If txtaddr.Text = "" Then txtaddr.Focus() : Exit Sub
        If txtcity.Text = "" Then txtcity.Focus() : Exit Sub
        If txtstate.Text = "" Then txtstate.Focus() : Exit Sub
        If txtpin.Text = "" Then txtpin.Focus() : Exit Sub
        If txtcountry.Text = "" Then txtcountry.Focus() : Exit Sub

        Try
            qry = "insert into tblemployeemgt(empid,empname,designation,salary,mobile,email,DOB,address,city,state,pinno,country) values('" & txtid.Text & "','" & txtename.Text & "','" & cmbdesg.Text & "','" & txtsal.Text & "','" & txtmob.Text & "','" & txtemail.Text & "','" & txtdob.Text & "','" & txtaddr.Text & "','" & txtcity.Text & "','" & txtstate.Text & "','" & txtpin.Text & "','" & txtcountry.Text & "')"
            cmd = New SqlCommand(qry, con)
            i = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MsgBox("success...", MsgBoxStyle.Information)
                loaddataingrid()
            Else
                MsgBox("failed...", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub loaddataingrid()
        If con.State = 1 Then con.Close()
        qry = "select * from tblemployeemgt with(nolock)"
        ds = fetchdata(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("no record found...", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub AddEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbleid.Visible = True
        bindcombo()
        loaddataingrid()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If (e.RowIndex >= 0) Then
            Try
                lbleid.Visible = True
                txtid.Visible = False
                i = DataGridView1.CurrentRow.Index
                Me.lbleid.Text = DataGridView1.Item(0, i).Value
                Me.txtename.Text = DataGridView1.Item(1, i).Value
                Me.cmbdesg.Text = DataGridView1.Item(2, i).Value
                Me.txtsal.Text = DataGridView1.Item(3, i).Value
                Me.txtmob.Text = DataGridView1.Item(4, i).Value
                Me.txtemail.Text = DataGridView1.Item(5, i).Value
                Me.txtdob.Text = DataGridView1.Item(6, i).Value

                Me.txtaddr.Text = DataGridView1.Item(7, i).Value
                Me.txtcity.Text = DataGridView1.Item(8, i).Value
                Me.txtstate.Text = DataGridView1.Item(9, i).Value
                Me.txtpin.Text = DataGridView1.Item(10, i).Value
                Me.txtcountry.Text = DataGridView1.Item(11, i).Value
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtename.Text = "" Then txtename.Focus() : Exit Sub
        If txtmob.Text = "" Then txtmob.Focus() : Exit Sub
        If txtdob.Text = "" Then txtdob.Focus() : Exit Sub
        If txtsal.Text = "" Then txtsal.Focus() : Exit Sub
        If txtemail.Text = "" Then txtemail.Focus() : Exit Sub
        If txtaddr.Text = "" Then txtaddr.Focus() : Exit Sub
        If txtcity.Text = "" Then txtcity.Focus() : Exit Sub
        If txtstate.Text = "" Then txtstate.Focus() : Exit Sub
        If txtpin.Text = "" Then txtpin.Focus() : Exit Sub
        If txtcountry.Text = "" Then txtcountry.Focus() : Exit Sub
        'update record
        Try
            qry = "update tblemployeemgt set empname='" & txtename.Text & "',designation='" & cmbdesg.Text & "',salary='" & txtsal.Text & "',mobile='" & txtmob.Text & "',email='" & txtemail.Text & "',DOB='" & txtdob.Text & "',address='" & txtaddr.Text & "',city='" & txtcity.Text & "',state='" & txtstate.Text & "',pinno='" & txtpin.Text & "',country='" & txtcountry.Text & "' where empid=" & lbleid.Text & ""
            i = insertdata(qry)
            If (i > 0) Then
                MsgBox("Updated Successfully", MsgBoxStyle.Information)
                loaddataingrid()
                clr()
            Else
                MsgBox("Updated Failed", MsgBoxStyle.Critical)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim result As Integer
        result = MsgBox("do you want to delete?", MsgBoxStyle.YesNo)
        If (lbleid.Text = "") Then
            MsgBox("select any row from gridview for delete", MsgBoxStyle.Critical)
        Else
            Try
                qry = "delete from tblemployeemgt where empid=" & lbleid.Text & ""
                i = insertdata(qry)
                If (i > 0) Then
                    MsgBox("deleted succesfully...", MsgBoxStyle.Information)
                    loaddataingrid()
                    clr()
                Else
                    MsgBox("delete failed...", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    Private Sub clr()
        txtename.Clear()
        txtcity.Clear()
        txtcountry.Clear()
        txtdob.Clear()
        txtemail.Clear()
        txtmob.Clear()
        txtaddr.Clear()
        txtpin.Clear()
        txtsal.Clear()
        txtsearch.Clear()
        txtstate.Clear()


    End Sub

    Private Sub btnclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclr.Click
        txtid.Visible = True
        lbleid.Text = "Employee ID:"
        clr()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        loaddataingrid()
        If txtsearch.Text = "" Then
            MsgBox("enter employee name", MsgBoxStyle.Critical)
            loaddataingrid()
            Exit Sub
        Else
            qry = "select * from tblemployeemgt with (nolock)"
            qry &= "where empname LIKE'%' + '" & txtsearch.Text & "'+'%'  or city LIKE'%' + '" & txtsearch.Text & "'+'%'"
            ds = fetchdata(qry)
            If (DataGridView1.Rows.Count > 0) Then
                clr()
                DataGridView1.DataSource = ds.Tables(0)
            Else
                clr()
                MsgBox("record not found...", MsgBoxStyle.Exclamation)

            End If

        End If
    End Sub
    Private Sub bindcombo()
        cmbdesg.Items.Clear()
        ds.Clear()
        qry = "select * from tbldesignation with(nolock)"
        ds = fetchdata(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim a As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To a
                cmbdesg.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
            Next
        Else
            MsgBox("no record found..", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub txtename_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtename.LostFocus
        Dim sname As String = "^[a-zA-Z\s]+$"
        Dim rsname As New System.Text.RegularExpressions.Regex(sname) 'Attach Pattern To Surname Textbox

        'Not A Match
        If Not rsname.IsMatch(txtename.Text) Then
            lblerror.Visible = True
            lblerror.Text = "Please Enter Alphabetic Characters Only!"

            txtename.Focus()

            txtename.Clear()

            sname = False

        Else
            lblerror.Visible = False
            sname = True

        End If
    End Sub

    Private Sub txtename_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtename.MouseClick
        txtid.Visible = True
        lbleid.Text = "Employee ID:"
        clr()
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

    Private Sub txtemail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.LostFocus
        Dim sname As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Dim rsname As New System.Text.RegularExpressions.Regex(sname) 'Attach Pattern To Surname Textbox

        'Not A Match
        If Not rsname.IsMatch(txtemail.Text) Then
            lblerror.Visible = True
            lblerror.Text = "Please Enter Digits,Characters And @ !"

            txtemail.Focus()

            txtemail.Clear()

            sname = False

        Else
            lblerror.Visible = False
            sname = True

        End If
    End Sub

    
    
   
   
   
End Class