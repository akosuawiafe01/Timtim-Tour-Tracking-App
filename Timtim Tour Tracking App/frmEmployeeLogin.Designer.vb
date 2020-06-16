<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeLogin
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
        Me.btnUserLoginEmp = New System.Windows.Forms.Button()
        Me.txtPasswordEmp = New System.Windows.Forms.TextBox()
        Me.txtUsernameEmp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnUserLoginEmp
        '
        Me.btnUserLoginEmp.Location = New System.Drawing.Point(341, 299)
        Me.btnUserLoginEmp.Name = "btnUserLoginEmp"
        Me.btnUserLoginEmp.Size = New System.Drawing.Size(114, 34)
        Me.btnUserLoginEmp.TabIndex = 13
        Me.btnUserLoginEmp.Text = "Login"
        Me.btnUserLoginEmp.UseVisualStyleBackColor = True
        '
        'txtPasswordEmp
        '
        Me.txtPasswordEmp.Location = New System.Drawing.Point(385, 211)
        Me.txtPasswordEmp.Name = "txtPasswordEmp"
        Me.txtPasswordEmp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordEmp.Size = New System.Drawing.Size(175, 20)
        Me.txtPasswordEmp.TabIndex = 12
        '
        'txtUsernameEmp
        '
        Me.txtUsernameEmp.Location = New System.Drawing.Point(385, 162)
        Me.txtUsernameEmp.Name = "txtUsernameEmp"
        Me.txtUsernameEmp.Size = New System.Drawing.Size(175, 20)
        Me.txtUsernameEmp.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Employee Login"
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
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "TimTim Tour Services"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEmployeeLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnUserLoginEmp)
        Me.Controls.Add(Me.txtPasswordEmp)
        Me.Controls.Add(Me.txtUsernameEmp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEmployeeLogin"
        Me.Text = "frmEmployeeLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUserLoginEmp As Button
    Friend WithEvents txtPasswordEmp As TextBox
    Friend WithEvents txtUsernameEmp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
