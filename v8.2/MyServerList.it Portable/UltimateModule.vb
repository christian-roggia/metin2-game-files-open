Module UltimateModule
    Public Function EXTENSION_1()
        Dim ultimate_text As New TextBox
        ultimate_text.Multiline = True
        ultimate_text.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Plugins\Ultimate.ini")
        'Modifica name per evitare doppioni
        Dim name As String
        name = "ULTIMATE_DATA_EXTENSION = "
        'Tipo = title
        For i = 0 To ultimate_text.Lines.Count - 1
            If Not ultimate_text.Lines(i).Length < name.Length Then
                If ultimate_text.Lines(i).Remove(name.Length, ultimate_text.Lines(i).Length - name.Length).ToString = name Then
                    Return ultimate_text.Lines(i).Replace(name, "").Replace(Chr(34), "").ToString
                    Exit For
                    Exit Function
                End If
            End If
        Next i
        Return "Unknown"
    End Function

    Public Function EXTENSION_2()
        Dim ultimate_text As New TextBox
        ultimate_text.Multiline = True
        ultimate_text.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Plugins\Ultimate.ini")
        'Modifica name per evitare doppioni
        Dim name As String
        name = "ULTIMATE_HEADER_EXTENSION = "
        'Tipo = title
        For i = 0 To ultimate_text.Lines.Count - 1
            If Not ultimate_text.Lines(i).Length < name.Length Then
                If ultimate_text.Lines(i).Remove(name.Length, ultimate_text.Lines(i).Length - name.Length).ToString = name Then
                    Return ultimate_text.Lines(i).Replace(name, "").Replace(Chr(34), "").ToString
                    Exit For
                    Exit Function
                End If
            End If
        Next i
        Return "Unknown"
    End Function
End Module
