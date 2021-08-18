<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Page
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home_Page))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesMnagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDesignationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Gold
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeToolStripMenuItem, Me.ItemManagementToolStripMenuItem, Me.StockManagementToolStripMenuItem, Me.SalesMnagementToolStripMenuItem, Me.MasterEntryToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(949, 36)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(110, 32)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(212, 32)
        Me.AddEmployeeToolStripMenuItem.Text = "Add Employee"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(212, 32)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ItemManagementToolStripMenuItem
        '
        Me.ItemManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem})
        Me.ItemManagementToolStripMenuItem.Name = "ItemManagementToolStripMenuItem"
        Me.ItemManagementToolStripMenuItem.Size = New System.Drawing.Size(184, 32)
        Me.ItemManagementToolStripMenuItem.Text = "Item Management"
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(165, 32)
        Me.AddItemToolStripMenuItem.Text = "Add Item"
        '
        'StockManagementToolStripMenuItem
        '
        Me.StockManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStockToolStripMenuItem})
        Me.StockManagementToolStripMenuItem.Name = "StockManagementToolStripMenuItem"
        Me.StockManagementToolStripMenuItem.Size = New System.Drawing.Size(193, 32)
        Me.StockManagementToolStripMenuItem.Text = "Stock Management"
        '
        'AddStockToolStripMenuItem
        '
        Me.AddStockToolStripMenuItem.Name = "AddStockToolStripMenuItem"
        Me.AddStockToolStripMenuItem.Size = New System.Drawing.Size(174, 32)
        Me.AddStockToolStripMenuItem.Text = "Add Stock"
        '
        'SalesMnagementToolStripMenuItem
        '
        Me.SalesMnagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesFormToolStripMenuItem, Me.SalesReportToolStripMenuItem})
        Me.SalesMnagementToolStripMenuItem.Name = "SalesMnagementToolStripMenuItem"
        Me.SalesMnagementToolStripMenuItem.Size = New System.Drawing.Size(179, 32)
        Me.SalesMnagementToolStripMenuItem.Text = "Sales Mnagement"
        '
        'SalesFormToolStripMenuItem
        '
        Me.SalesFormToolStripMenuItem.Name = "SalesFormToolStripMenuItem"
        Me.SalesFormToolStripMenuItem.Size = New System.Drawing.Size(192, 32)
        Me.SalesFormToolStripMenuItem.Text = "Sales form"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(192, 32)
        Me.SalesReportToolStripMenuItem.Text = "Sales Report"
        '
        'MasterEntryToolStripMenuItem
        '
        Me.MasterEntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDesignationToolStripMenuItem, Me.AddItemTypesToolStripMenuItem})
        Me.MasterEntryToolStripMenuItem.Name = "MasterEntryToolStripMenuItem"
        Me.MasterEntryToolStripMenuItem.Size = New System.Drawing.Size(134, 32)
        Me.MasterEntryToolStripMenuItem.Text = "Master Entry"
        '
        'AddDesignationToolStripMenuItem
        '
        Me.AddDesignationToolStripMenuItem.Name = "AddDesignationToolStripMenuItem"
        Me.AddDesignationToolStripMenuItem.Size = New System.Drawing.Size(231, 32)
        Me.AddDesignationToolStripMenuItem.Text = "Add Designation"
        '
        'AddItemTypesToolStripMenuItem
        '
        Me.AddItemTypesToolStripMenuItem.Name = "AddItemTypesToolStripMenuItem"
        Me.AddItemTypesToolStripMenuItem.Size = New System.Drawing.Size(231, 32)
        Me.AddItemTypesToolStripMenuItem.Text = "Add item types"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(176, 32)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 533)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(949, 25)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Home_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Canteen_Management_System.My.Resources.Resources.school_canteen_interior_flat_illustration_318844_69
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(949, 558)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Home_Page"
        Me.Text = "Home_Page"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesMnagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddDesignationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddItemTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
