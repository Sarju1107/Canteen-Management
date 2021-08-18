<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsalesentry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblmob = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtmob = New System.Windows.Forms.TextBox()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtcamt = New System.Windows.Forms.TextBox()
        Me.txtdamt = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtramt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnminus = New System.Windows.Forms.Button()
        Me.lblcamt = New System.Windows.Forms.Label()
        Me.btnplus = New System.Windows.Forms.Button()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.txtqnty = New System.Windows.Forms.TextBox()
        Me.lbldamt = New System.Windows.Forms.Label()
        Me.cmbitem = New System.Windows.Forms.ComboBox()
        Me.lblcost = New System.Windows.Forms.Label()
        Me.lblqnty = New System.Windows.Forms.Label()
        Me.lblramt = New System.Windows.Forms.Label()
        Me.lblitem = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(217, 34)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(49, 17)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Name"
        '
        'lblmob
        '
        Me.lblmob.AutoSize = True
        Me.lblmob.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmob.Location = New System.Drawing.Point(403, 34)
        Me.lblmob.Name = "lblmob"
        Me.lblmob.Size = New System.Drawing.Size(55, 17)
        Me.lblmob.TabIndex = 1
        Me.lblmob.Text = "Mobile"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(580, 34)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(42, 17)
        Me.lbldate.TabIndex = 2
        Me.lbldate.Text = "Date"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(178, 54)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(138, 22)
        Me.txtname.TabIndex = 3
        '
        'txtmob
        '
        Me.txtmob.Location = New System.Drawing.Point(355, 54)
        Me.txtmob.Name = "txtmob"
        Me.txtmob.Size = New System.Drawing.Size(138, 22)
        Me.txtmob.TabIndex = 4
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(540, 55)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(138, 22)
        Me.txtdate.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.txttotal)
        Me.Panel1.Controls.Add(Me.txtcamt)
        Me.Panel1.Controls.Add(Me.txtdamt)
        Me.Panel1.Controls.Add(Me.lbltotal)
        Me.Panel1.Controls.Add(Me.txtramt)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.btnminus)
        Me.Panel1.Controls.Add(Me.lblcamt)
        Me.Panel1.Controls.Add(Me.btnplus)
        Me.Panel1.Controls.Add(Me.txtcost)
        Me.Panel1.Controls.Add(Me.txtqnty)
        Me.Panel1.Controls.Add(Me.lbldamt)
        Me.Panel1.Controls.Add(Me.cmbitem)
        Me.Panel1.Controls.Add(Me.lblcost)
        Me.Panel1.Controls.Add(Me.lblqnty)
        Me.Panel1.Controls.Add(Me.lblramt)
        Me.Panel1.Controls.Add(Me.lblitem)
        Me.Panel1.Location = New System.Drawing.Point(40, 156)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(829, 386)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Visible = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(671, 315)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(114, 51)
        Me.btnsave.TabIndex = 12
        Me.btnsave.Text = "Save Order"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(528, 344)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(100, 22)
        Me.txttotal.TabIndex = 13
        '
        'txtcamt
        '
        Me.txtcamt.Location = New System.Drawing.Point(347, 344)
        Me.txtcamt.Name = "txtcamt"
        Me.txtcamt.Size = New System.Drawing.Size(106, 22)
        Me.txtcamt.TabIndex = 14
        '
        'txtdamt
        '
        Me.txtdamt.Location = New System.Drawing.Point(180, 344)
        Me.txtdamt.Name = "txtdamt"
        Me.txtdamt.Size = New System.Drawing.Size(106, 22)
        Me.txtdamt.TabIndex = 15
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(525, 315)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(45, 17)
        Me.lbltotal.TabIndex = 11
        Me.lbltotal.Text = "Total"
        '
        'txtramt
        '
        Me.txtramt.Location = New System.Drawing.Point(25, 344)
        Me.txtramt.Name = "txtramt"
        Me.txtramt.Size = New System.Drawing.Size(106, 22)
        Me.txtramt.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(748, 175)
        Me.DataGridView1.TabIndex = 8
        '
        'btnminus
        '
        Me.btnminus.BackColor = System.Drawing.Color.Red
        Me.btnminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminus.Location = New System.Drawing.Point(694, 36)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(68, 43)
        Me.btnminus.TabIndex = 7
        Me.btnminus.Text = "-"
        Me.btnminus.UseVisualStyleBackColor = False
        '
        'lblcamt
        '
        Me.lblcamt.AutoSize = True
        Me.lblcamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcamt.Location = New System.Drawing.Point(344, 315)
        Me.lblcamt.Name = "lblcamt"
        Me.lblcamt.Size = New System.Drawing.Size(122, 17)
        Me.lblcamt.TabIndex = 10
        Me.lblcamt.Text = "Change Amount"
        '
        'btnplus
        '
        Me.btnplus.BackColor = System.Drawing.Color.Lime
        Me.btnplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnplus.Location = New System.Drawing.Point(584, 36)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.Size = New System.Drawing.Size(73, 43)
        Me.btnplus.TabIndex = 6
        Me.btnplus.Text = "+"
        Me.btnplus.UseVisualStyleBackColor = False
        '
        'txtcost
        '
        Me.txtcost.Location = New System.Drawing.Point(366, 53)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(100, 22)
        Me.txtcost.TabIndex = 5
        '
        'txtqnty
        '
        Me.txtqnty.Location = New System.Drawing.Point(196, 51)
        Me.txtqnty.Name = "txtqnty"
        Me.txtqnty.Size = New System.Drawing.Size(100, 22)
        Me.txtqnty.TabIndex = 4
        '
        'lbldamt
        '
        Me.lbldamt.AutoSize = True
        Me.lbldamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldamt.Location = New System.Drawing.Point(177, 315)
        Me.lbldamt.Name = "lbldamt"
        Me.lbldamt.Size = New System.Drawing.Size(96, 17)
        Me.lbldamt.TabIndex = 9
        Me.lbldamt.Text = "Due Amount"
        '
        'cmbitem
        '
        Me.cmbitem.FormattingEnabled = True
        Me.cmbitem.Location = New System.Drawing.Point(37, 51)
        Me.cmbitem.Name = "cmbitem"
        Me.cmbitem.Size = New System.Drawing.Size(121, 24)
        Me.cmbitem.TabIndex = 3
        '
        'lblcost
        '
        Me.lblcost.AutoSize = True
        Me.lblcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcost.Location = New System.Drawing.Point(363, 30)
        Me.lblcost.Name = "lblcost"
        Me.lblcost.Size = New System.Drawing.Size(40, 17)
        Me.lblcost.TabIndex = 2
        Me.lblcost.Text = "Cost"
        '
        'lblqnty
        '
        Me.lblqnty.AutoSize = True
        Me.lblqnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqnty.Location = New System.Drawing.Point(193, 30)
        Me.lblqnty.Name = "lblqnty"
        Me.lblqnty.Size = New System.Drawing.Size(69, 17)
        Me.lblqnty.TabIndex = 1
        Me.lblqnty.Text = "Quantity"
        '
        'lblramt
        '
        Me.lblramt.AutoSize = True
        Me.lblramt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblramt.Location = New System.Drawing.Point(22, 315)
        Me.lblramt.Name = "lblramt"
        Me.lblramt.Size = New System.Drawing.Size(125, 17)
        Me.lblramt.TabIndex = 8
        Me.lblramt.Text = "Recieve Amount"
        '
        'lblitem
        '
        Me.lblitem.AutoSize = True
        Me.lblitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitem.Location = New System.Drawing.Point(34, 30)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(46, 17)
        Me.lblitem.TabIndex = 0
        Me.lblitem.Text = "items"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(37, 34)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(21, 17)
        Me.lblid.TabIndex = 8
        Me.lblid.Text = "id"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(24, 54)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 22)
        Me.txtid.TabIndex = 9
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(711, 34)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(165, 54)
        Me.btnadd.TabIndex = 6
        Me.btnadd.Text = "Add to Cart"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.Red
        Me.lblerror.Location = New System.Drawing.Point(327, 106)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(0, 17)
        Me.lblerror.TabIndex = 10
        '
        'frmsalesentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(962, 598)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.txtmob)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lblmob)
        Me.Controls.Add(Me.lblname)
        Me.Name = "frmsalesentry"
        Me.Text = "frmsalesentry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblmob As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtmob As System.Windows.Forms.TextBox
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnminus As System.Windows.Forms.Button
    Friend WithEvents btnplus As System.Windows.Forms.Button
    Friend WithEvents txtcost As System.Windows.Forms.TextBox
    Friend WithEvents txtqnty As System.Windows.Forms.TextBox
    Friend WithEvents cmbitem As System.Windows.Forms.ComboBox
    Friend WithEvents lblcost As System.Windows.Forms.Label
    Friend WithEvents lblqnty As System.Windows.Forms.Label
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents lblramt As System.Windows.Forms.Label
    Friend WithEvents lbldamt As System.Windows.Forms.Label
    Friend WithEvents lblcamt As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtcamt As System.Windows.Forms.TextBox
    Friend WithEvents txtdamt As System.Windows.Forms.TextBox
    Friend WithEvents txtramt As System.Windows.Forms.TextBox
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents lblerror As System.Windows.Forms.Label
End Class
