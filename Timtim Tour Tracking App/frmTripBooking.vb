Imports System.Data.SqlClient

Public Class frmTripBooking

    'Transcript Table data adapter
    Dim tripBookAdapter As timtim_App_DatasetTableAdapters.TripTableAdapter = New timtim_App_DatasetTableAdapters.TripTableAdapter
    'Student Table dataset
    Dim tripDataset = New timtim_App_Dataset()
    'Variable for storing student data collected
    Dim tripRow As timtim_App_Dataset.TripRow


    Dim subClientAdapter As timtim_App_DatasetTableAdapters.ClientTableAdapter = New timtim_App_DatasetTableAdapters.ClientTableAdapter
    Dim subClientRow As timtim_App_Dataset.ClientDataTable





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try


            'row = tabledataset.table.NewRow

            tripRow = tripDataset.Trip.NewRow

            'recieving data from text boxes

            tripRow.clientID = txtClientID.Text
            tripRow.tourSiteID = cmbToursite.SelectedValue.ToString


        Catch ex As Exception
            MessageBox.Show("Data fields cannot be left null", ex.Message)
        End Try


        'saving the Courses into the database


        tripDataset.Trip.AddTripRow(tripRow)
        tripBookAdapter.Update(tripDataset.Trip)


        'Saving data into database
        MessageBox.Show("Trip Booked", "Booking Successful", MessageBoxButtons.OK)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub frmTripBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Timtim_App_Dataset.Tour_Site' table. You can move, or remove it, as needed.
        Me.Tour_SiteTableAdapter.Fill(Me.Timtim_App_Dataset.Tour_Site)



        txtUserUser.Text = frmUserLogin.txtUsername.Text

        Try

            Dim constr As String = "Data Source=.;Initial Catalog=TimtimTourApp-Db;Integrated Security=True"
            Using con As SqlConnection = New SqlConnection(constr)
                Using cmd As SqlCommand = New SqlCommand("Select * from Client where userName='" & frmUserLogin.txtUsername.Text & "'  ")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    Using sdr As SqlDataReader = cmd.ExecuteReader()
                        sdr.Read()

                        txtClientID.Text = sdr("clientID").ToString()
                    End Using
                    con.Close()
                End Using
            End Using



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try





    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim cancelOption = MessageBox.Show("Do you want to go back to the Main Menu?", "Back to Main Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmTripMenu.Show()

            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub txtClientID_TextChanged(sender As Object, e As EventArgs) Handles txtClientID.TextChanged

    End Sub
End Class