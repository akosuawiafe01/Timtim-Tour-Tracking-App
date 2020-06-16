<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTripBooking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbToursite = New System.Windows.Forms.ComboBox()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.cmbDistance = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpBookdate = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUserUser = New System.Windows.Forms.TextBox()
        Me.txtClientID = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Timtim_App_Dataset = New Timtim_Tour_Tracking_App.timtim_App_Dataset()
        Me.TourSiteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tour_SiteTableAdapter = New Timtim_Tour_Tracking_App.timtim_App_DatasetTableAdapters.Tour_SiteTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Timtim_App_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TourSiteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Enabled = False
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(800, 96)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TimTim Tour Services"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tour Site"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(156, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Distance"
        '
        'cmbToursite
        '
        Me.cmbToursite.DataSource = Me.TourSiteBindingSource
        Me.cmbToursite.DisplayMember = "Name"
        Me.cmbToursite.FormattingEnabled = True
        Me.cmbToursite.Location = New System.Drawing.Point(270, 96)
        Me.cmbToursite.Name = "cmbToursite"
        Me.cmbToursite.Size = New System.Drawing.Size(180, 21)
        Me.cmbToursite.TabIndex = 12
        Me.cmbToursite.ValueMember = "TourSiteID"
        '
        'cmbLocation
        '
        Me.cmbLocation.DataSource = Me.TourSiteBindingSource
        Me.cmbLocation.DisplayMember = "Location"
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(272, 142)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(178, 21)
        Me.cmbLocation.TabIndex = 13
        Me.cmbLocation.ValueMember = "Location"
        '
        'cmbDistance
        '
        Me.cmbDistance.DataSource = Me.TourSiteBindingSource
        Me.cmbDistance.DisplayMember = "Distance"
        Me.cmbDistance.FormattingEnabled = True
        Me.cmbDistance.Location = New System.Drawing.Point(271, 184)
        Me.cmbDistance.Name = "cmbDistance"
        Me.cmbDistance.Size = New System.Drawing.Size(179, 21)
        Me.cmbDistance.TabIndex = 14
        Me.cmbDistance.ValueMember = "Distance"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpBookdate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbDistance)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbLocation)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbToursite)
        Me.GroupBox1.Location = New System.Drawing.Point(124, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 236)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book a tour"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Date"
        '
        'dtpBookdate
        '
        Me.dtpBookdate.Location = New System.Drawing.Point(271, 50)
        Me.dtpBookdate.Name = "dtpBookdate"
        Me.dtpBookdate.Size = New System.Drawing.Size(181, 20)
        Me.dtpBookdate.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(322, 411)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 26)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Book Tour"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(577, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(586, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "ID"
        '
        'txtUserUser
        '
        Me.txtUserUser.Location = New System.Drawing.Point(660, 89)
        Me.txtUserUser.Name = "txtUserUser"
        Me.txtUserUser.Size = New System.Drawing.Size(115, 20)
        Me.txtUserUser.TabIndex = 19
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(660, 115)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.Size = New System.Drawing.Size(115, 20)
        Me.txtClientID.TabIndex = 20
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(505, 412)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(108, 26)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Timtim_App_Dataset
        '
        Me.Timtim_App_Dataset.DataSetName = "timtim_App_Dataset"
        Me.Timtim_App_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TourSiteBindingSource
        '
        Me.TourSiteBindingSource.DataMember = "Tour_Site"
        Me.TourSiteBindingSource.DataSource = Me.Timtim_App_Dataset
        '
        'Tour_SiteTableAdapter
        '
        Me.Tour_SiteTableAdapter.ClearBeforeFill = True
        '
        'frmTripBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtClientID)
        Me.Controls.Add(Me.txtUserUser)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTripBooking"
        Me.Text = "frmTripBooking"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Timtim_App_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TourSiteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbToursite As ComboBox
    Friend WithEvents cmbLocation As ComboBox
    Friend WithEvents cmbDistance As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpBookdate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUserUser As TextBox
    Friend WithEvents txtClientID As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Timtim_App_Dataset As timtim_App_Dataset
    Friend WithEvents TourSiteBindingSource As BindingSource
    Friend WithEvents Tour_SiteTableAdapter As timtim_App_DatasetTableAdapters.Tour_SiteTableAdapter
End Class
