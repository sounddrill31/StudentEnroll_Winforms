Public Class Form1
    Private Sub ClrBtn_Click(sender As Object, e As EventArgs) Handles ClrBtn.Click
        NameBox.ResetText()
        CourseBox.ResetText()
        SemBox.ResetText()
        MarksBox.ResetText()
    End Sub

    Private Sub Result_Click(sender As Object, e As EventArgs) Handles Result.Click
        MsgBox("Details " + vbCrLf +
               "Name: " + vbCrLf + NameBox.Text +
               "Course: " + vbCrLf + CourseBox.Text +
               "Semester: " + vbCrLf + SemBox.Text +
               "Marks: " + MarksBox.Text)
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Close()
    End Sub
End Class
