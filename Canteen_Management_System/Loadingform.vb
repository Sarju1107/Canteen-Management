Public Class Loadingform

    Private Sub Loadingform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        ProgressBar1.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Hide()
            Home_Page.Show()
            Timer1.Stop()
        End If
    End Sub

    
    
End Class