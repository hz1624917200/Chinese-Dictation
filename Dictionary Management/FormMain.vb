Imports System.ComponentModel

Public Class FormMain
    Public x As Integer
    Public y As Integer

    Dim n As Integer = 0, pn As Integer = 0
    Dim word() As String
    Dim pron() As String, ind() As Integer
    Dim indw As Integer, indp As Integer
    Dim prevStr As String

    Dim CurrentFileName As String
    Dim InName, OutName As String

    Dim OutStream As IO.StreamWriter

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        zoomInitialize(Me)

#Region "Initialize directory"
        OpenFileDialog1.FileName = ""
        SaveFileDialog1.FileName = "library.txt"
        OpenFileDialog1.InitialDirectory = Application.StartupPath
        SaveFileDialog1.InitialDirectory = Application.StartupPath
        'ButtonReadFile_Click(Nothing, Nothing)
        InName = "手动输入"
        ButtonSaveFile_Click(Nothing, Nothing)
#End Region

    End Sub

    Private Function InitializeReading() As Boolean
        Dim i As Integer
        Dim temp As String
        Dim fstream As IO.StreamWriter

        'Initialize Input file 
        If Not word Is Nothing Then
            If Not word(0) = "" And indw <= n Then
                If Not MsgBox("录入未结束，是否结束本次录入？", MsgBoxStyle.Question & MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Return False
                Else
                    'Put the remaining words to the current File
                    If Not prevStr = "" Then
                        OutStream.WriteLine(prevStr)
                        prevStr = ""
                        LabelPrev.Text = ""
                    End If
                    fstream = New IO.StreamWriter(CurrentFileName)
                    If indp > 0 Then
                        If ind(indp - 1) = indw - 1 Then indp -= 1
                    End If
                    For i = indw - 1 To n
                            temp = word(i)
                            If ind(indp) = i Then
                                temp = temp & " " & pron(indp)
                                indp += 1
                                If indp > UBound(ind) Then indp -= 1
                            End If
                            fstream.WriteLine(temp)
                        Next
                        fstream.Close()
                    End If
                End If
        End If

        n = 0 : pn = 0 : indp = 0 : indw = 0
        ReDim word(0) : ReDim pron(0) : ReDim ind(0)
        word(0) = ""
        Return True
    End Function

#Region "Input Select"
    Dim DenyChange = False
    Private Sub RBFileT_CheckedChanged(sender As Object, e As EventArgs) Handles RBFileT.CheckedChanged
        If RBFileT.Checked Then
            If Not DenyChange Then
                ButtonReadFile_Click(Nothing, Nothing)
                TextBoxWord.ReadOnly = True
                'Initialize Main
            Else
                DenyChange = True
            End If
        Else
            If InitializeReading() Then
                DenyChange = False
                InName = "手动输入"
                'Initialize Main
                TextBoxWord.ReadOnly = False
                Refresh_MainLable()
            Else
                DenyChange = True
                RBFileT.Checked = True
            End If
        End If
    End Sub
#End Region

#Region "Redirect"

    Private Sub ButtonReadFile_Click(sender As Object, e As EventArgs) Handles ButtonReadFile.Click
        If Not InitializeReading() Then Exit Sub

        OpenFileDialog1.ShowDialog()
        Debug.Print(OpenFileDialog1.FileName)
        'check and open sub

#Region "Read Library"
        Dim fstream As IO.StreamReader
        Dim temp As String
        Dim s As Integer, f As Integer

        If IO.File.Exists(OpenFileDialog1.FileName) Then
            Try
                fstream = New IO.StreamReader(OpenFileDialog1.FileName)
                Do While Not fstream.EndOfStream
                    temp = fstream.ReadLine()
                    s = 0
                    Do While Not Asc(temp(s)) < 0
                        s += 1
                        If s = Len(temp) Then Exit Do
                    Loop
                    If s = Len(temp) Then Continue Do
                    f = s
                    Do While Asc(temp(f)) < 0
                        f += 1
                        If f = Len(temp) Then Exit Do
                    Loop
                    ReDim Preserve word(n)
                    word(n) = Mid(temp, s + 1, f - s)
                    'Debug.Print(n & "  " & word(n))
                    temp = Mid(temp, f + 1)
                    'Debug.Print(temp)
                    'Get pronunciation
                    If Not Trim(temp) Is "" Then
                        ReDim Preserve pron(pn)
                        ReDim Preserve ind(pn)
                        pron(pn) = Trim(temp)
                        ind(pn) = n
                        Debug.Print(pron(pn))
                        pn += 1
                    End If
                    n += 1
                Loop
                fstream.Close()
            Catch
                Debug.Print("ERROR while file reading")
            End Try
        End If
        n -= 1
        If n = -1 Then
            MsgBox("This File is empty or error," & vbCrLf & "Please select File again", MsgBoxStyle.Critical)
            ButtonReadFile_Click(Nothing, Nothing)
        Else
            CurrentFileName = OpenFileDialog1.FileName

            Dim t() As String
            t = Split(CurrentFileName, "\")
            InName = t(UBound(t))
            Refresh_LabelFile()
        End If

#End Region

        Refresh_MainLable()

    End Sub

    Private Sub ButtonSaveFile_Click(sender As Object, e As EventArgs) Handles ButtonSaveFile.Click
        If Not prevStr = "" Then
            OutStream.WriteLine(prevStr)
            prevStr = ""
            LabelPrev.Text = ""
        End If
        Try
            OutStream.Close()
        Catch ex As Exception

        End Try
        SaveFileDialog1.ShowDialog()
        Debug.Print(SaveFileDialog1.FileName)
        Dim t() As String
        t = Split(SaveFileDialog1.FileName, "\")
        OutName = t(UBound(t))
        Refresh_LabelFile()
        'Add select and setting sub
        If IO.File.Exists(SaveFileDialog1.FileName) Then
            Dim Append As Boolean
            If MsgBox("该文件已经存在，是否将输出追加到文件末尾？" & vbCrLf & "（若选择""否""，则原文件将被清空）",
                   MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Append = True
            If Append Then
                OutStream = New IO.StreamWriter(SaveFileDialog1.FileName, True)
            Else
                OutStream = New IO.StreamWriter(SaveFileDialog1.FileName, False)
            End If
        End If

        'OutStream.WriteLine("Hello")
        'OutStream.Close()
    End Sub
#End Region

    Private Sub Refresh_MainLable()
        TextBoxWord.Text = ""
        TextBoxPron.Text = ""
        TextBoxTone.Text = ""
        TextBoxLoc.Text = ""
        TextBoxRank.Text = "1"
        TextBoxWord.Focus()
        If RBFileT.Checked = True Then
            If indw = n + 1 Then
                MsgBox("字典生成已全部完成"， MsgBoxStyle.Information)
                If Not prevStr = "" Then
                    OutStream.WriteLine(prevStr)
                    prevStr = ""
                    LabelPrev.Text = ""
                    RBFileF.Checked = True
                End If
                Refresh_MainLable()
                Exit Sub
            End If
            TextBoxLoc.Focus()
            TextBoxWord.Text = word(indw)
            If ind(indp) = indw Then
                TextBoxPron.Text = pron(indp)
                indp += 1
            End If
            indw += 1
        End If
    End Sub

    Private Sub Refresh_LabelFile()
        LabelFile.Text = String.Format("生成字典：{0,-15} --> {1,-15}", InName, OutName)
    End Sub

    Private Sub FormMain_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        setControls(Me.Width / x, Me.Height / y, Me)
    End Sub

    Private Sub FormMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not InitializeReading() Then e.Cancel = True
        If Not prevStr = "" Then
            OutStream.WriteLine(prevStr)
            prevStr = ""
        End If
        OutStream.Close()
    End Sub

    Private Sub NextWord(sender As Object, e As EventArgs) Handles ButtonNext.Click
        Debug.Print("Next")
        'limit
        If TextBoxLoc.Text = "" Then Exit Sub
        If Trim(TextBoxRank.Text) = "" Then TextBoxRank.Text = "1"
        If Not TextBoxTone.Text = "" And TextBoxPron.Text = "" Then Exit Sub
        'sort loc
        Dim loc As String = TextBoxLoc.Text
        Dim i, j, k As Integer
        Dim l As Integer = Len(loc) - 1
        For i = 0 To l
            k = i
            For j = i + 1 To l
                If loc(j) < loc(k) Then k = j
            Next
            If k > i Then
                Debug.Print(Strings.Left(loc, i))
                loc = Strings.Left(loc, i) & loc(k) & Mid(loc, i + 2, k - i - 1) & loc(i) & Mid(loc, k + 2)
            End If
        Next
        Debug.Print(loc)

        If Not prevStr = "" Then OutStream.WriteLine(prevStr)
        prevStr = TextBoxWord.Text & ","
        If Not TextBoxPron.Text = "" Then
            If TextBoxTone.Text = "" Then TextBoxTone.Text = "0"
            prevStr = prevStr & TextBoxPron.Text & "," & TextBoxTone.Text & ","
        End If
        For i = 0 To Len(loc) - 2
            prevStr = prevStr & loc(i) & "."
        Next
        prevStr = prevStr & loc(Len(loc) - 1) & "," & TextBoxRank.Text
        'prestr done
        LabelPrev.Text = prevStr
        Refresh_MainLable()
    End Sub

    Private Sub ButtonPrev_Click(sender As Object, e As EventArgs) Handles ButtonPrev.Click
        If RBFileT.Checked Then
            If Not prevStr = "" Then
                If indp > 0 Then
                    If ind(indp - 1) = indw - 2 Then indp -= 1
                End If
                indw -= 2
                prevStr = ""
                LabelPrev.Text = ""
                Refresh_MainLable()
            End If
            Else
            prevStr = ""
            Refresh_MainLable()
        End If
    End Sub

#Region "Input Limit and process"
    Private Function IsDuplicated(sender As Object, c As Char) As Boolean
        Dim i As Integer
        For i = 0 To Len(sender.text) - 1
            If sender.text(i) = c Then Return True
        Next
        Return False
    End Function

    Private Sub TextBoxLoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLoc.KeyPress
        'Defult error
        Dim t As Integer = Asc(e.KeyChar)
        If t = 8 Then Exit Sub
        If t = Keys.Enter Then NextWord(Nothing, Nothing)
        If t < 49 Or t > 57 Then e.Handled = True
        If Len(sender.text) >= Len(TextBoxWord.Text) Then e.Handled = True
        If IsDuplicated(sender, e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub TextBoxPron_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPron.KeyPress
        Debug.Print(Asc(e.KeyChar))
        'Defult nothing
        Dim t As Integer = Asc(e.KeyChar)
        If t = 8 Then Exit Sub
        If t = Keys.Enter Then NextWord(Nothing, Nothing)
        If t < 65 Or t > 90 And t < 97 Or t > 122 Then e.Handled = True
    End Sub

    Private Sub TextBoxRank_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxRank.KeyPress
        'Defult 1
        Dim t As Integer = Asc(e.KeyChar)
        If t = 8 Then Exit Sub
        If t = Keys.Enter Then NextWord(Nothing, Nothing)
        If t < 49 Or t > 53 Then e.Handled = True
        If Not sender.text = "" Then e.Handled = True
    End Sub

    Private Sub TextBoxTone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTone.KeyPress
        'Defult 0
        Dim t As Integer = Asc(e.KeyChar)
        If t = 8 Then Exit Sub
        If t = Keys.Enter Then NextWord(Nothing, Nothing)
        If t < 48 Or t > 52 Then e.Handled = True
        If Not sender.text = "" Then e.Handled = True
    End Sub
#End Region
End Class