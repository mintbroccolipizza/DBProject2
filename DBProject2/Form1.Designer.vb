<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_UN = New System.Windows.Forms.TextBox()
        Me.TextBox_PW = New System.Windows.Forms.TextBox()
        Me.Login_Btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Check Connection"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(117, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(117, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'TextBox_UN
        '
        Me.TextBox_UN.Font = New System.Drawing.Font("MS PGothic", 9.0!)
        Me.TextBox_UN.Location = New System.Drawing.Point(117, 183)
        Me.TextBox_UN.Name = "TextBox_UN"
        Me.TextBox_UN.Size = New System.Drawing.Size(136, 19)
        Me.TextBox_UN.TabIndex = 3
        '
        'TextBox_PW
        '
        Me.TextBox_PW.Font = New System.Drawing.Font("MS PGothic", 9.0!)
        Me.TextBox_PW.Location = New System.Drawing.Point(117, 232)
        Me.TextBox_PW.Name = "TextBox_PW"
        Me.TextBox_PW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_PW.Size = New System.Drawing.Size(136, 19)
        Me.TextBox_PW.TabIndex = 4
        '
        'Login_Btn
        '
        Me.Login_Btn.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Login_Btn.Location = New System.Drawing.Point(117, 268)
        Me.Login_Btn.Name = "Login_Btn"
        Me.Login_Btn.Size = New System.Drawing.Size(135, 34)
        Me.Login_Btn.TabIndex = 5
        Me.Login_Btn.Text = "Sign In"
        Me.Login_Btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(91, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 44)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Log In"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(363, 394)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Login_Btn)
        Me.Controls.Add(Me.TextBox_PW)
        Me.Controls.Add(Me.TextBox_UN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_UN As TextBox
    Friend WithEvents TextBox_PW As TextBox
    Friend WithEvents Login_Btn As Button
    Friend WithEvents Label3 As Label
End Class