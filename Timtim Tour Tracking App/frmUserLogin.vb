Public Class frmUserLogin
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnUserLogin_Click(sender As Object, e As EventArgs) Handles btnUserLogin.Click
        Dim userPass, userName As String

        userName = txtUsername.Text
        userPass = txtPassword.Text


        Dim strCon As String = "Data Source=.;Initial Catalog=TimtimTourApp-Db;Integrated Security=True"
        Dim strSQL As String = "Select * from Client where userName='" & userName & "' and password ='" & userPass & "' "
        Dim dataAdapter As New SqlClient.SqlDataAdapter(strSQL, strCon)
        Dim sqlCmd As SqlClient.SqlCommand
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        If dataTable.Rows.Count > 0 Then
            frmTripMenu.Show()
            Me.Hide()

        Else
            MessageBox.Show("Incorrect username or password", "Incorrect Details")
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        frmEmployeeLogin.Show()
        Me.Hide()
    End Sub

    Private Sub frmUserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class