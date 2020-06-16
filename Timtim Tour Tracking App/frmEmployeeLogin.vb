Public Class frmEmployeeLogin
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnUserLoginEmp_Click(sender As Object, e As EventArgs) Handles btnUserLoginEmp.Click
        Dim empPass, empname As String

        empPass = txtPasswordEmp.Text
        empname = txtUsernameEmp.Text


        Dim strCon As String = "Data Source=.;Initial Catalog=TimtimTourApp-Db;Integrated Security=True"
        Dim strSQL As String = "Select * from Employee where userName='" & empname & "' and password ='" & empPass & "' "
        Dim dataAdapter As New SqlClient.SqlDataAdapter(strSQL, strCon)
        Dim sqlCmd As SqlClient.SqlCommand
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        If dataTable.Rows.Count > 0 Then
            frmTripMenu.Show()
            Me.Hide()

        Else
            MessageBox.Show("Enter a correct username or password", "Incorrect Details")
        End If


    End Sub
End Class