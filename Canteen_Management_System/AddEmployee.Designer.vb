<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmployee
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
        Me.lbleid = New System.Windows.Forms.Label()
        Me.lblename = New System.Windows.Forms.Label()
        Me.lblsal = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lbladdr = New System.Windows.Forms.Label()
        Me.lblcity = New System.Windows.Forms.Label()
        Me.lblpin = New System.Windows.Forms.Label()
        Me.lbldesg = New System.Windows.Forms.Label()
        Me.lblmob = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.lblstate = New System.Windows.Forms.Label()
        Me.lblcountry = New System.Windows.Forms.Label()
        Me.txtename = New System.Windows.Forms.TextBox()
        Me.cmbdesg = New System.Windows.Forms.ComboBox()
        Me.txtsal = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtaddr = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtpin = New System.Windows.Forms.TextBox()
        Me.txtmob = New System.Windows.Forms.TextBox()
        Me.txtdob = New System.Windows.Forms.TextBox()
        Me.txtstate = New System.Windows.Forms.TextBox()
        Me.txtcountry = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.lblerror = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbleid
        '
        Me.lbleid.AutoSize = True
        Me.lbleid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleid.Location = New System.Drawing.Point(35, 35)
        Me.lbleid.Name = "lbleid"
        Me.lbleid.Size = New System.Drawing.Size(115, 20)
        Me.lbleid.TabIndex = 0
        Me.lbleid.Text = "Employee ID"
        '
        'lblename
        '
        Me.lblename.AutoSize = True
        Me.lblename.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblename.Location = New System.Drawing.Point(35, 80)
        Me.lblename.Name = "lblename"
        Me.lblename.Size = New System.Drawing.Size(144, 20)
        Me.lblename.TabIndex = 1
        Me.lblename.Text = "Employee Name"
        '
        'lblsal
        '
        Me.lblsal.AutoSize = True
        Me.lblsal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsal.Location = New System.Drawing.Point(38, 126)
        Me.lblsal.Name = "lblsal"
        Me.lblsal.Size = New System.Drawing.Size(62, 20)
        Me.lblsal.TabIndex = 2
        Me.lblsal.Text = "Salary"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(38, 164)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(56, 20)
        Me.lblemail.TabIndex = 3
        Me.lblemail.Text = "Email"
        '
        'lbladdr
        '
        Me.lbladdr.AutoSize = True
        Me.lbladdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdr.Location = New System.Drawing.Point(35, 207)
        Me.lbladdr.Name = "lbladdr"
        Me.lbladdr.Size = New System.Drawing.Size(78, 20)
        Me.lbladdr.TabIndex = 4
        Me.lbladdr.Text = "Address"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcity.Location = New System.Drawing.Point(38, 256)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(42, 20)
        Me.lblcity.TabIndex = 5
        Me.lblcity.Text = "City"
        '
        'lblpin
        '
        Me.lblpin.AutoSize = True
        Me.lblpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpin.Location = New System.Drawing.Point(35, 301)
        Me.lblpin.Name = "lblpin"
        Me.lblpin.Size = New System.Drawing.Size(65, 20)
        Me.lblpin.TabIndex = 6
        Me.lblpin.Text = "PIN no"
        '
        'lbldesg
        '
        Me.lbldesg.AutoSize = True
        Me.lbldesg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesg.Location = New System.Drawing.Point(514, 41)
        Me.lbldesg.Name = "lbldesg"
        Me.lbldesg.Size = New System.Drawing.Size(109, 20)
        Me.lbldesg.TabIndex = 7
        Me.lbldesg.Text = "Designation"
        '
        'lblmob
        '
        Me.lblmob.AutoSize = True
        Me.lblmob.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmob.Location = New System.Drawing.Point(514, 80)
        Me.lblmob.Name = "lblmob"
        Me.lblmob.Size = New System.Drawing.Size(90, 20)
        Me.lblmob.TabIndex = 8
        Me.lblmob.Text = "Mobile no"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.Location = New System.Drawing.Point(519, 126)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(50, 20)
        Me.lbldob.TabIndex = 9
        Me.lbldob.Text = "DOB"
        '
        'lblstate
        '
        Me.lblstate.AutoSize = True
        Me.lblstate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstate.Location = New System.Drawing.Point(519, 250)
        Me.lblstate.Name = "lblstate"
        Me.lblstate.Size = New System.Drawing.Size(53, 20)
        Me.lblstate.TabIndex = 10
        Me.lblstate.Text = "State"
        '
        'lblcountry
        '
        Me.lblcountry.AutoSize = True
        Me.lblcountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcountry.Location = New System.Drawing.Point(514, 295)
        Me.lblcountry.Name = "lblcountry"
        Me.lblcountry.Size = New System.Drawing.Size(74, 20)
        Me.lblcountry.TabIndex = 11
        Me.lblcountry.Text = "Country"
        '
        'txtename
        '
        Me.txtename.Location = New System.Drawing.Point(212, 80)
        Me.txtename.Name = "txtename"
        Me.txtename.Size = New System.Drawing.Size(181, 22)
        Me.txtename.TabIndex = 13
        '
        'cmbdesg
        '
        Me.cmbdesg.FormattingEnabled = True
        Me.cmbdesg.Location = New System.Drawing.Point(658, 37)
        Me.cmbdesg.Name = "cmbdesg"
        Me.cmbdesg.Size = New System.Drawing.Size(175, 24)
        Me.cmbdesg.TabIndex = 12
        '
        'txtsal
        '
        Me.txtsal.Location = New System.Drawing.Point(212, 124)
        Me.txtsal.Name = "txtsal"
        Me.txtsal.Size = New System.Drawing.Size(181, 22)
        Me.txtsal.TabIndex = 14
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(212, 162)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(181, 22)
        Me.txtemail.TabIndex = 15
        '
        'txtaddr
        '
        Me.txtaddr.Location = New System.Drawing.Point(212, 205)
        Me.txtaddr.Name = "txtaddr"
        Me.txtaddr.Size = New System.Drawing.Size(482, 22)
        Me.txtaddr.TabIndex = 16
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(212, 250)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(181, 22)
        Me.txtcity.TabIndex = 17
        '
        'txtpin
        '
        Me.txtpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpin.Location = New System.Drawing.Point(212, 295)
        Me.txtpin.Name = "txtpin"
        Me.txtpin.Size = New System.Drawing.Size(181, 26)
        Me.txtpin.TabIndex = 18
        '
        'txtmob
        '
        Me.txtmob.Location = New System.Drawing.Point(658, 78)
        Me.txtmob.Name = "txtmob"
        Me.txtmob.Size = New System.Drawing.Size(175, 22)
        Me.txtmob.TabIndex = 19
        '
        'txtdob
        '
        Me.txtdob.Location = New System.Drawing.Point(658, 123)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(175, 22)
        Me.txtdob.TabIndex = 20
        '
        'txtstate
        '
        Me.txtstate.Location = New System.Drawing.Point(658, 250)
        Me.txtstate.Name = "txtstate"
        Me.txtstate.Size = New System.Drawing.Size(100, 22)
        Me.txtstate.TabIndex = 21
        '
        'txtcountry
        '
        Me.txtcountry.Location = New System.Drawing.Point(658, 298)
        Me.txtcountry.Name = "txtcountry"
        Me.txtcountry.Size = New System.Drawing.Size(100, 22)
        Me.txtcountry.TabIndex = 22
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Teal
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsave.Location = New System.Drawing.Point(1045, 93)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(88, 38)
        Me.btnsave.TabIndex = 23
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Teal
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndelete.Location = New System.Drawing.Point(1045, 154)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(88, 37)
        Me.btndelete.TabIndex = 24
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Teal
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnupdate.Location = New System.Drawing.Point(1045, 207)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(88, 40)
        Me.btnupdate.TabIndex = 25
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnclr
        '
        Me.btnclr.BackColor = System.Drawing.Color.Teal
        Me.btnclr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnclr.Location = New System.Drawing.Point(1045, 268)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(88, 37)
        Me.btnclr.TabIndex = 26
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(191, 380)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(503, 22)
        Me.txtsearch.TabIndex = 27
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.Black
        Me.btnsearch.Location = New System.Drawing.Point(791, 380)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(88, 31)
        Me.btnsearch.TabIndex = 28
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 443)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1219, 221)
        Me.DataGridView1.TabIndex = 29
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(212, 33)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(181, 22)
        Me.txtid.TabIndex = 30
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.Red
        Me.lblerror.Location = New System.Drawing.Point(885, 33)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(0, 17)
        Me.lblerror.TabIndex = 31
        '
        'AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1247, 681)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtcountry)
        Me.Controls.Add(Me.txtstate)
        Me.Controls.Add(Me.txtdob)
        Me.Controls.Add(Me.txtmob)
        Me.Controls.Add(Me.txtpin)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.txtaddr)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtsal)
        Me.Controls.Add(Me.txtename)
        Me.Controls.Add(Me.cmbdesg)
        Me.Controls.Add(Me.lblcountry)
        Me.Controls.Add(Me.lblstate)
        Me.Controls.Add(Me.lbldob)
        Me.Controls.Add(Me.lblmob)
        Me.Controls.Add(Me.lbldesg)
        Me.Controls.Add(Me.lblpin)
        Me.Controls.Add(Me.lblcity)
        Me.Controls.Add(Me.lbladdr)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblsal)
        Me.Controls.Add(Me.lblename)
        Me.Controls.Add(Me.lbleid)
        Me.Name = "AddEmployee"
        Me.Text = "AddEmployee"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbleid As System.Windows.Forms.Label
    Friend WithEvents lblename As System.Windows.Forms.Label
    Friend WithEvents lblsal As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lbladdr As System.Windows.Forms.Label
    Friend WithEvents lblcity As System.Windows.Forms.Label
    Friend WithEvents lblpin As System.Windows.Forms.Label
    Friend WithEvents lbldesg As System.Windows.Forms.Label
    Friend WithEvents lblmob As System.Windows.Forms.Label
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents lblstate As System.Windows.Forms.Label
    Friend WithEvents lblcountry As System.Windows.Forms.Label
    Friend WithEvents txtename As System.Windows.Forms.TextBox
    Friend WithEvents cmbdesg As System.Windows.Forms.ComboBox
    Friend WithEvents txtsal As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtaddr As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtpin As System.Windows.Forms.TextBox
    Friend WithEvents txtmob As System.Windows.Forms.TextBox
    Friend WithEvents txtdob As System.Windows.Forms.TextBox
    Friend WithEvents txtstate As System.Windows.Forms.TextBox
    Friend WithEvents txtcountry As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnclr As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents lblerror As System.Windows.Forms.Label
End Class
