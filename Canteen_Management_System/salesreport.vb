Public Class salesreport

    Private Sub salesreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'salesreports.tblsaletemp' table. You can move, or remove it, as needed.
        Me.tblsaletempTableAdapter.Fill(Me.salesreports.tblsaletemp)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class