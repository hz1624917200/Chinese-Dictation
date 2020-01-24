Module Zoom

    ''' <summary>
    ''' If you want to use the auto zoom function in your object
    ''' you should first add the sub 'zoomInitialize' to Load sub (sender is 'Me')
    ''' then add the sub 'setcontrols' to the event {form_name}_Resize
    ''' Good Luck!
    ''' Jan 24, 2020 ,By Zheng Huang
    ''' </summary>

    Public Sub setTag(sender As Object)
        For Each con As Control In sender.controls
            con.Tag = con.Width & ":" & con.Height & ":" & con.Left & ":" &
            con.Top & ":" & con.Font.Size
            If con.Controls.Count > 0 Then
                setTag(con)
            End If
        Next
    End Sub

    Public Sub zoomInitialize(sender As Object)
        With sender
            .x = .width
            .y = .height
        End With
        setTag(sender)
    End Sub

    Public Sub setControls(newx As Single, newy As Single, sender As Object)
        For Each con As Control In sender.controls
            'con.Autosize = False 
            Dim mytag() As String = con.Tag.ToString.Split(":")
            If Not con.GetType Is GetType(Label) Then
                con.Width = mytag(0) * newx
                con.Height = mytag(1) * newy
            End If
            con.Left = mytag(2) * newx
            con.Top = mytag(3) * newy
            Dim currentSize As Single = newy * mytag(4)
            con.Font = New Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit)
            If con.Controls.Count > 0 Then
                setControls(newx, newy, con)
            End If
        Next
    End Sub
End Module
