<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmitementry
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
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblcost = New System.Windows.Forms.Label()
        Me.lblitype = New System.Windows.Forms.Label()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.cmbitemtype = New System.Windows.Forms.ComboBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblitmid = New System.Windows.Forms.Label()
        Me.txtitemid = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(34, 76)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(40, 17)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "Title"
        '
        'lblcost
        '
        Me.lblcost.AutoSize = True
        Me.lblcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcost.Location = New System.Drawing.Point(34, 131)
        Me.lblcost.Name = "lblcost"
        Me.lblcost.Size = New System.Drawing.Size(38, 17)
        Me.lblcost.TabIndex = 1
        Me.lblcost.Text = "cost"
        '
        'lblitype
        '
        Me.lblitype.AutoSize = True
        Me.lblitype.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitype.Location = New System.Drawing.Point(254, 69)
        Me.lblitype.Name = "lblitype"
        Me.lblitype.Size = New System.Drawing.Size(79, 17)
        Me.lblitype.TabIndex = 2
        Me.lblitype.Text = "Item Type"
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesc.Location = New System.Drawing.Point(253, 131)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(90, 17)
        Me.lbldesc.TabIndex = 3
        Me.lbldesc.Text = "Description"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(84, 71)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(133, 22)
        Me.txttitle.TabIndex = 4
        '
        'txtcost
        '
        Me.txtcost.Location = New System.Drawing.Point(84, 128)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(133, 22)
        Me.txtcost.TabIndex = 5
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(345, 126)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(133, 22)
        Me.txtdesc.TabIndex = 6
        '
        'cmbitemtype
        '
        Me.cmbitemtype.FormattingEnabled = True
        Me.cmbitemtype.Location = New System.Drawing.Point(345, 69)
        Me.cmbitemtype.Name = "cmbitemtype"
        Me.cmbitemtype.Size = New System.Drawing.Size(224, 24)
        Me.cmbitemtype.TabIndex = 7
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(37, 189)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 38)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.SkyBlue
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(142, 189)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 38)
        Me.btndelete.TabIndex = 9
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.SkyBlue
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(256, 189)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 38)
        Me.btnupdate.TabIndex = 10
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnclr
        '
        Me.btnclr.BackColor = System.Drawing.Color.SkyBlue
        Me.btnclr.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclr.Location = New System.Drawing.Point(370, 189)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(75, 38)
        Me.btnclr.TabIndex = 11
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 259)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(666, 309)
        Me.DataGridView1.TabIndex = 12
        '
        'lblitmid
        '
        Me.lblitmid.AutoSize = True
        Me.lblitmid.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitmid.Location = New System.Drawing.Point(34, 24)
        Me.lblitmid.Name = "lblitmid"
        Me.lblitmid.Size = New System.Drawing.Size(56, 17)
        Me.lblitmid.TabIndex = 13
        Me.lblitmid.Text = "item id"
        '
        'txtitemid
        '
        Me.txtitemid.Location = New System.Drawing.Point(112, 24)
        Me.txtitemid.Name = "txtitemid"
        Me.txtitemid.Size = New System.Drawing.Size(133, 22)
        Me.txtitemid.TabIndex = 14
        '
        'frmitementry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(729, 609)
        Me.Controls.Add(Me.txtitemid)
        Me.Controls.Add(Me.lblitmid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cmbitemtype)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.txtcost)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.lbldesc)
        Me.Controls.Add(Me.lblitype)
        Me.Controls.Add(Me.lblcost)
        Me.Controls.Add(Me.lbltitle)
        Me.Name = "frmitementry"
        Me.Text = "frmitementry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents lblcost As System.Windows.Forms.Label
    Friend WithEvents lblitype As System.Windows.Forms.Label
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents txtcost As System.Windows.Forms.TextBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents cmbitemtype As System.Windows.Forms.ComboBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnclr As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblitmid As System.Windows.Forms.Label
    Friend WithEvents txtitemid As System.Windows.Forms.TextBox
End Class
