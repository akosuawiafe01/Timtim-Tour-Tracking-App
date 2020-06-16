Public Class frmTripMenu
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub TripDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TripDetailsToolStripMenuItem.Click
        frmTripBooking.Show()
        Me.Hide()
    End Sub

    Private Sub frmTripMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = frmUserLogin.txtUsername.Text
    End Sub

    Private Sub BookedToursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookedToursToolStripMenuItem.Click
        frmBookedTours.Show()
        Me.Hide()
    End Sub
End Class