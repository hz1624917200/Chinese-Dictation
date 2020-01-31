Public Class FormOption
    Private Sub FormOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextLine.Text = FormMain.lines + 1
        RepeatCheck.Checked = FormMain.repeat
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Me.Close()
    End Sub

    Private Sub FormOption_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim l As Integer
        l = Val(TextLine.Text)
        If l > 0 And l <= 28 And l - 1 <> FormMain.lines Then
            FormMain.lines = TextLine.Text - 1
            FormMain.clear()
        End If
        If Not FormMain.repeat = RepeatCheck.Checked Then
            FormMain.repeat = RepeatCheck.Checked
            FormMain.clear()
        End If
    End Sub

    Private Sub ButtonOutput_Click(sender As Object, e As EventArgs) Handles ButtonOutput.Click
        Me.Close()
        FormMain.export()
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Me.Close()
        FormMain.clear()
    End Sub
End Class