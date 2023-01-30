Public Class Attendance
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AttendancecheckDataSet.attendance' table. You can move, or remove it, as needed.
        Me.AttendanceTableAdapter.Fill(Me.AttendancecheckDataSet.attendance)
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo SaveErr
        AttendanceBindingSource.EndEdit()
        AttendanceTableAdapter.Update(AttendancecheckDataSet.attendance)
        MsgBox("Saved", MsgBoxStyle.Information)
        AttendanceBindingSource.AddNew()
SaveErr:
        Exit Sub
    End Sub
End Class