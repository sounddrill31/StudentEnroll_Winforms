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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        NameBox = New TextBox()
        MarksBox = New TextBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        CourseBox = New ComboBox()
        SemBox = New ComboBox()
        ClrBtn = New Button()
        Result = New Button()
        ExitBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(356, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enrollment Form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(220, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 15)
        Label2.TabIndex = 1
        Label2.Text = "Student Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(220, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 15)
        Label3.TabIndex = 2
        Label3.Text = "Course"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(220, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 3
        Label4.Text = "Marks"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(220, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 4
        Label5.Text = "Semester"
        ' 
        ' NameBox
        ' 
        NameBox.Location = New Point(356, 131)
        NameBox.Name = "NameBox"
        NameBox.Size = New Size(236, 23)
        NameBox.TabIndex = 5
        ' 
        ' MarksBox
        ' 
        MarksBox.Location = New Point(356, 249)
        MarksBox.Name = "MarksBox"
        MarksBox.Size = New Size(236, 23)
        MarksBox.TabIndex = 6
        ' 
        ' CourseBox
        ' 
        CourseBox.FormattingEnabled = True
        CourseBox.Location = New Point(356, 171)
        CourseBox.Name = "CourseBox"
        CourseBox.Size = New Size(236, 23)
        CourseBox.TabIndex = 7
        ' 
        ' SemBox
        ' 
        SemBox.FormattingEnabled = True
        SemBox.Location = New Point(356, 215)
        SemBox.Name = "SemBox"
        SemBox.Size = New Size(236, 23)
        SemBox.TabIndex = 8
        ' 
        ' ClrBtn
        ' 
        ClrBtn.Location = New Point(277, 294)
        ClrBtn.Name = "ClrBtn"
        ClrBtn.Size = New Size(75, 23)
        ClrBtn.TabIndex = 9
        ClrBtn.Text = "Clear"
        ClrBtn.UseVisualStyleBackColor = True
        ' 
        ' Result
        ' 
        Result.Location = New Point(377, 294)
        Result.Name = "Result"
        Result.Size = New Size(75, 23)
        Result.TabIndex = 10
        Result.Text = "Result"
        Result.UseVisualStyleBackColor = True
        ' 
        ' ExitBtn
        ' 
        ExitBtn.Location = New Point(479, 294)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(75, 23)
        ExitBtn.TabIndex = 11
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ExitBtn)
        Controls.Add(Result)
        Controls.Add(ClrBtn)
        Controls.Add(SemBox)
        Controls.Add(CourseBox)
        Controls.Add(MarksBox)
        Controls.Add(NameBox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents MarksBox As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CourseBox As ComboBox
    Friend WithEvents SemBox As ComboBox
    Friend WithEvents ClrBtn As Button
    Friend WithEvents Result As Button
    Friend WithEvents ExitBtn As Button

End Class
