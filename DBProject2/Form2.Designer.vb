<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_EID = New System.Windows.Forms.TextBox()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.TextBox_Surname = New System.Windows.Forms.TextBox()
        Me.TextBox_Age = New System.Windows.Forms.TextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.Delete_Btn = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblButton = New System.Windows.Forms.Button()
        Me.Search_Text = New System.Windows.Forms.TextBox()
        Me.RadioButton_Male = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Female = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker_DOB = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoadChart_Btn = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(47, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Sign Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(47, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "EID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(47, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(47, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Surname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(47, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Age"
        '
        'TextBox_EID
        '
        Me.TextBox_EID.Location = New System.Drawing.Point(125, 60)
        Me.TextBox_EID.Name = "TextBox_EID"
        Me.TextBox_EID.Size = New System.Drawing.Size(86, 20)
        Me.TextBox_EID.TabIndex = 6
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Location = New System.Drawing.Point(125, 85)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(86, 20)
        Me.TextBox_Name.TabIndex = 7
        '
        'TextBox_Surname
        '
        Me.TextBox_Surname.Location = New System.Drawing.Point(125, 110)
        Me.TextBox_Surname.Name = "TextBox_Surname"
        Me.TextBox_Surname.Size = New System.Drawing.Size(86, 20)
        Me.TextBox_Surname.TabIndex = 8
        '
        'TextBox_Age
        '
        Me.TextBox_Age.Location = New System.Drawing.Point(125, 135)
        Me.TextBox_Age.Name = "TextBox_Age"
        Me.TextBox_Age.Size = New System.Drawing.Size(86, 20)
        Me.TextBox_Age.TabIndex = 9
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(47, 240)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(73, 25)
        Me.SaveBtn.TabIndex = 10
        Me.SaveBtn.Text = "SAVE"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.Location = New System.Drawing.Point(130, 240)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(79, 25)
        Me.UpdateBtn.TabIndex = 11
        Me.UpdateBtn.Text = "UPDATE"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'Delete_Btn
        '
        Me.Delete_Btn.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_Btn.Location = New System.Drawing.Point(91, 269)
        Me.Delete_Btn.Name = "Delete_Btn"
        Me.Delete_Btn.Size = New System.Drawing.Size(73, 29)
        Me.Delete_Btn.TabIndex = 12
        Me.Delete_Btn.Text = "DELETE"
        Me.Delete_Btn.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(415, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 29)
        Me.ComboBox1.TabIndex = 13
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(316, 48)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(79, 30)
        Me.ListBox1.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(241, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(342, 130)
        Me.DataGridView1.TabIndex = 15
        '
        'TblButton
        '
        Me.TblButton.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold)
        Me.TblButton.Location = New System.Drawing.Point(241, 221)
        Me.TblButton.Name = "TblButton"
        Me.TblButton.Size = New System.Drawing.Size(113, 32)
        Me.TblButton.TabIndex = 16
        Me.TblButton.Text = "LOAD TABLE"
        Me.TblButton.UseVisualStyleBackColor = True
        '
        'Search_Text
        '
        Me.Search_Text.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Search_Text.Location = New System.Drawing.Point(360, 222)
        Me.Search_Text.Name = "Search_Text"
        Me.Search_Text.Size = New System.Drawing.Size(104, 33)
        Me.Search_Text.TabIndex = 17
        '
        'RadioButton_Male
        '
        Me.RadioButton_Male.AutoSize = True
        Me.RadioButton_Male.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_Male.Location = New System.Drawing.Point(105, 173)
        Me.RadioButton_Male.Name = "RadioButton_Male"
        Me.RadioButton_Male.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton_Male.TabIndex = 18
        Me.RadioButton_Male.TabStop = True
        Me.RadioButton_Male.Text = "Male"
        Me.RadioButton_Male.UseVisualStyleBackColor = False
        '
        'RadioButton_Female
        '
        Me.RadioButton_Female.AutoSize = True
        Me.RadioButton_Female.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_Female.Location = New System.Drawing.Point(152, 173)
        Me.RadioButton_Female.Name = "RadioButton_Female"
        Me.RadioButton_Female.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton_Female.TabIndex = 19
        Me.RadioButton_Female.TabStop = True
        Me.RadioButton_Female.Text = "Female"
        Me.RadioButton_Female.UseVisualStyleBackColor = False
        '
        'DateTimePicker_DOB
        '
        Me.DateTimePicker_DOB.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_DOB.Location = New System.Drawing.Point(105, 205)
        Me.DateTimePicker_DOB.Name = "DateTimePicker_DOB"
        Me.DateTimePicker_DOB.Size = New System.Drawing.Size(86, 20)
        Me.DateTimePicker_DOB.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(47, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 18)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(47, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 18)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "DOB"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(45, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Info"
        '
        'LoadChart_Btn
        '
        Me.LoadChart_Btn.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadChart_Btn.Location = New System.Drawing.Point(470, 222)
        Me.LoadChart_Btn.Name = "LoadChart_Btn"
        Me.LoadChart_Btn.Size = New System.Drawing.Size(113, 32)
        Me.LoadChart_Btn.TabIndex = 24
        Me.LoadChart_Btn.Text = "LOAD CHART"
        Me.LoadChart_Btn.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = -90
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(241, 261)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Name_VS_Age"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(342, 184)
        Me.Chart1.TabIndex = 25
        Me.Chart1.Text = "Chart1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(624, 457)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.LoadChart_Btn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker_DOB)
        Me.Controls.Add(Me.RadioButton_Female)
        Me.Controls.Add(Me.RadioButton_Male)
        Me.Controls.Add(Me.Search_Text)
        Me.Controls.Add(Me.TblButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Delete_Btn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.TextBox_Age)
        Me.Controls.Add(Me.TextBox_Surname)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.TextBox_EID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Employee Info"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_EID As TextBox
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents TextBox_Surname As TextBox
    Friend WithEvents TextBox_Age As TextBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents Delete_Btn As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TblButton As Button
    Friend WithEvents Search_Text As TextBox
    Friend WithEvents RadioButton_Male As RadioButton
    Friend WithEvents RadioButton_Female As RadioButton
    Friend WithEvents DateTimePicker_DOB As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LoadChart_Btn As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
