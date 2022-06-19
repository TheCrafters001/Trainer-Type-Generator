Public Class Form1
    Private Sub generate_btn_Click(sender As Object, e As EventArgs) Handles generate_btn.Click
        ' Create seperator for the output
        Dim seperator As String = "#-------------------------------"
        ' Create strings for each txtbox
        Dim trainerID As String = trainerID_txt.Text.ToUpper
        Dim trainerName As String = trainerName_txt.Text
        Dim trainerGender As String

        ' Select the radio button that is checked
        If trainerGenderMale_rad.Checked = True Then
            trainerGender = "Male"
        ElseIf trainerGenderFemale_rad.Checked = True Then
            trainerGender = "Female"
        ElseIf trainerGenderUnknown_rad.Checked = True Then
            trainerGender = "Unknown"
        Else
            trainerGender = "Unknown"
        End If

        Dim baseMoney As String = baseMoney_txt.Text
        Dim IntroBGM As String = introBGM_txt.Text
        Dim BattleBGM As String = battleBGM_txt.Text
        Dim VictoryBGM As String = victoryBGM_txt.Text

        ' Combine all the strings into one string, seperated by a new line
        Dim output As String = seperator & vbCrLf & "[" & trainerID & "]" & vbCrLf & "Name = " & trainerName & vbCrLf & "Gender = " & trainerGender & vbCrLf &
            "BaseMoney = " & baseMoney & vbCrLf & "IntroBGM = " & IntroBGM & vbCrLf & "BattleBGM = " & BattleBGM & vbCrLf & "VictoryBGM = " & VictoryBGM

        ' Send Output to Output RichTextBox
        output_rchTxt.Text = output

    End Sub

    Private Sub generateExport_btn_Click(sender As Object, e As EventArgs) Handles generateExport_btn.Click
        ' Create seperator for the output
        Dim seperator As String = "#-------------------------------"
        ' Create strings for each txtbox
        Dim trainerID As String = trainerID_txt.Text.ToUpper
        Dim trainerName As String = trainerName_txt.Text
        Dim trainerGender As String

        ' Select the radio button that is checked
        If trainerGenderMale_rad.Checked = True Then
            trainerGender = "Male"
        ElseIf trainerGenderFemale_rad.Checked = True Then
            trainerGender = "Female"
        ElseIf trainerGenderUnknown_rad.Checked = True Then
            trainerGender = "Unknown"
        Else
            trainerGender = "Unknown"
        End If

        Dim baseMoney As String = baseMoney_txt.Text
        Dim IntroBGM As String = introBGM_txt.Text
        Dim BattleBGM As String = battleBGM_txt.Text
        Dim VictoryBGM As String = victoryBGM_txt.Text

        ' Combine all the strings into one string, seperated by a new line
        Dim output As String = seperator & vbCrLf & "[" & trainerID & "]" & vbCrLf & "Name = " & trainerName & vbCrLf & "Gender = " & trainerGender & vbCrLf &
            "BaseMoney = " & baseMoney & vbCrLf & "IntroBGM = " & IntroBGM & vbCrLf & "BattleBGM = " & BattleBGM & vbCrLf & "VictoryBGM = " & VictoryBGM

        ' Send Output to Output RichTextBox
        output_rchTxt.Text = output

        ' Try and save to file called trainer_types.txt using the saveFileDialog
        Try
            trainerTypesTXT_SaveDiag.FileName = "trainer_types.txt"
            trainerTypesTXT_SaveDiag.Filter = "Trainer Types TXT File|trainer_types.txt"
            If trainerTypesTXT_SaveDiag.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(trainerTypesTXT_SaveDiag.FileName, output, True)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
End Class
