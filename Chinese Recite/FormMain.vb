Public Class FormMain
    Const RankMax As Integer = 5
    Public lines As Integer = 27
    Public repeat As Boolean = False
    Public x As Single = 0
    Public y As Single = 0

    Private Structure Words
        Dim s As String
        Dim loc As String
        Dim rank As Integer
        Dim pro As String
        Dim ton As Integer
        Dim flag As Boolean
    End Structure

    Dim word() As Words
    Dim n As Integer
    Dim nleft As Integer
    Dim Ranksum As Integer = 0
    Dim listindex(27) As Integer
    Dim hisc As Integer = 0, indc As Integer = 0
    Dim history()() As Integer
    Dim map() As Integer 'map(i) is the index+1 of word that in the rank place i
    Dim mapc As Integer = 0 'reflect index

    '''<summary>
    ''' library format:
    ''' 1:(s as string,loc as integer
    ''' (one or more, splited with '.'),rank as integer>=1)
    ''' 2:(s as string,pro as string,ton as integer,
    ''' loc(the same as 1),rank as integer)
    ''' </summary>
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        zoomInitialize(Me)

        Dim st， str() As String
        Dim i As Integer = 0, j As Integer
        Dim u As Integer
        Dim fname As String
        Dim fstream As IO.StreamReader

        Randomize()

#Region "settings"
        fname = Application.StartupPath & "\settings.ini"
        If IO.File.Exists(fname) Then
            fstream = New IO.StreamReader(fname)
            If Not fstream.EndOfStream Then
                st = fstream.ReadLine
                u = Val(st) 'temp virant
                st = fstream.ReadLine
                repeat = st
                If u > 0 And u < lines Then lines = u
            End If
            fstream.Close()
        End If
#End Region

#Region "Read Library"
        fname = Application.StartupPath & "\library.txt"
        OpenFileDialog1.InitialDirectory = fname
        OpenFileDialog1.FileName = "library.txt"
        OpenFileDialog1.ShowDialog()
        fname = OpenFileDialog1.FileName
        If IO.File.Exists(fname) Then
            fstream = New IO.StreamReader(fname)
            Do While Not fstream.EndOfStream
                ReDim Preserve word(i)
                st = fstream.ReadLine
                str = Split(st, ",")
                u = UBound(str)
                word(i).s = str(0)
                word(i).flag = False
                If u >= 1 Then
                    If IsNumeric(str(1)) Then
                        word(i).loc = str(1)
                        If u = 2 Then word(i).rank = Val(str(2))
                    Else
                        word(i).pro = str(1)
                        word(i).ton = Val(str(2))
                        If u >= 3 Then word(i).loc = str(3)
                        If u = 4 Then word(i).rank = Val(str(4))
                    End If
                    Ranksum += word(i).rank
                    ReDim Preserve map(Ranksum - 1)
                    For j = mapc To Ranksum - 1
                        map(j) = i
                    Next
                    mapc = Ranksum
                Else
                    i -= 1
                End If
                i += 1
            Loop
            fstream.Close()
        End If
        n = i - 1
        nleft = n + 1
        If n = -1 Then
            MsgBox("Can't find the file or file is empty", MsgBoxStyle.Critical, "Error")
            Me.Close()
            Exit Sub
        End If
#End Region
    End Sub
#Region "Zoom"

    Private Sub FormMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        setControls(Me.Width / x, Me.Height / y, Me)
    End Sub

#End Region
    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles ButtonOption.Click
        FormOption.Show()
    End Sub

    Private Sub ButtonPrev_Click(sender As Object, e As EventArgs) Handles ButtonPrev.Click
        PageSwitch(-1)
    End Sub

#Region "Core"
    Public Sub export()
        Debug.Print("exported")
        If indc = 0 Then Exit Sub

        Dim fname As String = Application.StartupPath & "\History.txt"
        Dim fout As IO.StreamWriter
        Dim i As Integer, j As Integer
        Dim temp As String

        If indc = hisc + 1 Then
            ReDim Preserve history(hisc)
            ReDim Preserve history(hisc)(27)
            For i = 0 To lines
                history(hisc)(i) = listindex(i)
            Next
        End If
        hisc += 1

        fout = New IO.StreamWriter(fname)

        For i = 0 To hisc - 1
            For j = 0 To lines
                With word(history(i)(j) - 1)
                    temp = Str(i * (lines + 1) + j + 1) & ")  " & .s & " " & .loc
                    If Not .pro Is Nothing Then temp = temp & " " & .pro & " " & .ton
                End With
                fout.WriteLine(temp)
            Next
        Next
        fout.Close()
        MsgBox("听写记录已经导出到 History.txt", MsgBoxStyle.Information, "导出")
        hisc = hisc - 1
    End Sub

    Public Sub clear()
        Dim i As Integer
        Debug.Print("cleared")
        hisc = 0
        indc = 0
        nleft = n + 1
        ReDim history(hisc)
        For i = 0 To 27
            listindex(i) = 0
        Next
        For i = 0 To n
            word(i).flag = False
        Next
        List1.Items.Clear()
        List2.Items.Clear()
        List1.Items.Add("点击  下一个")
        List1.Items.Add("以开始听写")
        List1.Refresh()
        List2.Refresh()
    End Sub

    Private Sub PageSwitch(dir As Integer)

        Dim i As Integer
        If indc = hisc + 1 Then
            ReDim Preserve history(hisc)
            ReDim Preserve history(hisc)(27)
            For i = 0 To 27
                history(hisc)(i) = listindex(i)
            Next
        End If
        If dir + indc - 1 < 0 Or dir + indc - 1 > hisc Then Exit Sub
        indc += dir
        For i = 0 To 27
            listindex(i) = history(indc - 1)(i)
        Next
        '
        '
        'Dim i As Integer
        'For i = 0 To 14
        '    listindex(i) = i + 1
        'Next
        '
        '
        ListShow()
    End Sub

    Private Sub Display() Handles ButtonNext.Click
        Dim t As Integer

        Debug.Print("displayed")

        If indc <= hisc And hisc > 0 Then
            PageSwitch(1)
            Exit Sub
        End If

        If nleft = 0 Then
            MsgBox("字库已全部显示，若要重新开始听写，请在 Option 中执行 清空听写记录" &
                   vbCrLf & "若要重复听写，请在 Option 中勾选 允许重复", MsgBoxStyle.Information, "字库末端")
            Exit Sub
        End If
        ReDim Preserve history(hisc)
        ReDim Preserve history(hisc)(27)
        For t = 0 To 27
            history(hisc)(t) = listindex(t)
        Next
        If listindex(0) = 0 Then hisc = hisc - 1
        hisc = hisc + 1
        For t = 0 To 27
            listindex(t) = 0
        Next
        Dim i As Integer
        Dim c As Integer
        Dim f As Boolean
        For i = 0 To lines

            If nleft = 0 Then Exit For
            t = Rnd() * Ranksum
            If t = Ranksum Then t -= 1
            t = map(t)
            If Not repeat Then
                c = 0
                f = False
                Do While word(t).flag
                    t = Rnd() * Ranksum
                    If t = Ranksum Then t -= 1
                    t = map(t)
                    c += 1
                    If c > 100 Then
                        f = True
                        Exit Do
                    End If
                Loop
                If f Then
                    For t = 0 To n
                        If Not word(t).flag Then
                            word(t).flag = True
                            listindex(i) = t + 1
                            Exit For
                        End If
                    Next
                End If
                nleft -= 1
                word(t).flag = True
            End If
            listindex(i) = t + 1
        Next
        indc += 1
        ListShow()
        Debug.Print("hisc:" & hisc)
        Debug.Print("indc:" & indc)
    End Sub
#End Region

    Private Sub ListShow()
        Dim i As Integer, j As Integer
        Dim u As Integer
        Dim temp As String
        Dim location() As String
        List1.Items.Clear()
        List2.Items.Clear()
        List1.Refresh()
        List2.Refresh()
        For i = 0 To lines
            If listindex(i) = 0 Then Exit For
            With word(listindex(i) - 1)
                If .pro Is Nothing Then
                    temp = .s & " " & .pro & " " & .loc
                Else
                    'create main string
                    location = Split(.loc, ".")
                    u = UBound(location)
                    'If location(0) > 1 Then
                    temp = Mid(.s, 1, Val(location(0) - 1))
                    'Else
                    'temp = ""
                    'End If
                    For j = 1 To u
                        temp = temp & "__" & Mid(.s, Val(location(j - 1)) + 1, Val(location(j)) - Val(location(j - 1)) - 1)
                    Next
                    temp = temp & "__" & Mid(.s, Val(location(u)) + 1, .s.Length - Val(location(u)))
                    'end create

                    temp = temp & " " & .pro
                    If Not .ton = 0 Then temp = temp & " " & .ton
                End If
            End With
            If i <= lines \ 2 Then
                List1.Items.Add(temp)
            Else
                List2.Items.Add(temp)
            End If
        Next
    End Sub

    Private Sub KeyDownProcess(sender As Object, e As KeyEventArgs) Handles List1.KeyDown, List2.KeyDown
        Select Case e.KeyData
            Case Keys.Space
                Debug.Print("Space")
                Display()
            Case Keys.Back
                Debug.Print("Back")
                PageSwitch(-1)
        End Select
    End Sub

    Private Sub FormMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim fout As IO.StreamWriter
        Dim fname As String
        fname = Application.StartupPath & "\settings.ini"
        fout = New IO.StreamWriter(fname)
        fout.WriteLine(lines)
        fout.WriteLine(repeat)
        fout.Close()
    End Sub

#Region "List selection"
    Private Sub List1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List1.SelectedIndexChanged
        If Not List1.SelectedIndex = -1 Then List2.SelectedIndex = -1
    End Sub

    Private Sub List2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List2.SelectedIndexChanged
        If Not List2.SelectedIndex = -1 Then List1.SelectedIndex = -1
    End Sub
#End Region
End Class