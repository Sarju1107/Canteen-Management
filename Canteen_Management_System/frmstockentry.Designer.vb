<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstockentry
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
        Me.lblselitm = New System.Windows.Forms.Label()
        Me.cmbselitm = New System.Windows.Forms.ComboBox()
        Me.lblqnty = New System.Windows.Forms.Label()
        Me.txtqnty = New System.Windows.Forms.TextBox()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstockid = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblselitm
        '
        Me.lblselitm.AutoSize = True
        Me.lblselitm.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblselitm.Location = New System.Drawing.Point(59, 58)
        Me.lblselitm.Name = "lblselitm"
        Me.lblselitm.Size = New System.Drawing.Size(94, 17)
        Me.lblselitm.TabIndex = 0
        Me.lblselitm.Text = "select items"
        '
        'cmbselitm
        '
        Me.cmbselitm.FormattingEnabled = True
        Me.cmbselitm.Location = New System.Drawing.Point(177, 58)
        Me.cmbselitm.Name = "cmbselitm"
        Me.cmbselitm.Size = New System.Drawing.Size(186, 24)
        Me.cmbselitm.TabIndex = 1
        '
        'lblqnty
        '
        Me.lblqnty.AutoSize = True
        Me.lblqnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqnty.Location = New System.Drawing.Point(62, 125)
        Me.lblqnty.Name = "lblqnty"
        Me.lblqnty.Size = New System.Drawing.Size(69, 17)
        Me.lblqnty.TabIndex = 2
        Me.lblqnty.Text = "Quantity"
        '
        'txtqnty
        '
        Me.txtqnty.Location = New System.Drawing.Point(177, 125)
        Me.txtqnty.Name = "txtqnty"
        Me.txtqnty.Size = New System.Drawing.Size(186, 22)
        Me.txtqnty.TabIndex = 3
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesc.Location = New System.Drawing.Point(62, 199)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(90, 17)
        Me.lbldesc.TabIndex = 4
        Me.lbldesc.Text = "Description"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(177, 194)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(186, 22)
        Me.txtdesc.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 260)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(623, 211)
        Me.DataGridView1.TabIndex = 6
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.CadetBlue
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsave.Location = New System.Drawing.Point(470, 73)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(70, 36)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.CadetBlue
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndel.Location = New System.Drawing.Point(470, 140)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(107, 36)
        Me.btndel.TabIndex = 8
        Me.btndel.Text = "DELETE"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.CadetBlue
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnupdate.Location = New System.Drawing.Point(598, 73)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(107, 36)
        Me.btnupdate.TabIndex = 9
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnclr
        '
        Me.btnclr.BackColor = System.Drawing.Color.CadetBlue
        Me.btnclr.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnclr.Location = New System.Drawing.Point(627, 140)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(78, 36)
        Me.btnclr.TabIndex = 10
        Me.btnclr.Text = "CLEAR"
        Me.btnclr.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "stock id"
        '
        'txtstockid
        '
        Me.txtstockid.Location = New System.Drawing.Point(177, 13)
        Me.txtstockid.Name = "txtstockid"
        Me.txtstockid.Size = New System.Drawing.Size(186, 22)
        Me.txtstockid.TabIndex = 12
        '
        'frmstockentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(738, 518)
        Me.Controls.Add(Me.txtstockid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.lbldesc)
        Me.Controls.Add(Me.txtqnty)
        Me.Controls.Add(Me.lblqnty)
        Me.Controls.Add(Me.cmbselitm)
        Me.Controls.Add(Me.lblselitm)
        Me.Name = "frmstockentry"
        Me.Text = "frmstockentry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblselitm As System.Windows.Forms.Label
    Friend WithEvents cmbselitm As System.Windows.Forms.ComboBox
    Friend WithEvents lblqnty As System.Windows.Forms.Label
    Friend WithEvents txtqnty As System.Windows.Forms.TextBox
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnclr As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtstockid As System.Windows.Forms.TextBox
End Class
