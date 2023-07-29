Public Class Form1
    Dim bmp01, bmp02, bmpTemp As Bitmap
    Dim clr, clrTemp As Color
    Dim intR, intG, intB, intTemp As Integer

    Private Sub buttonLoad_Click(sender As Object, e As EventArgs) Handles buttonLoad.Click
        Dim intResponse As Integer
        Dim sngMul As Single

        openFileDialog.Filter = "Bitmap Files|*.bmp|JPEG Files|*.jpg|GIF Files|*.gif"
        If openFileDialog.ShowDialog Then
            bmp01 = New Bitmap(Image.FromFile(openFileDialog.FileName))

            If bmp01.Width > 640 Or bmp01.Height > 580 Then
                intResponse = MsgBox _
            ("Resolusi gambar terlalu besar. mau di resize biar muat?",
            vbYesNo + vbQuestion)
            End If

            If intResponse = vbNo Then
                Exit Sub
            ElseIf intResponse = vbYes Then
                If (bmp01.Width / 4) >= (bmp01.Height / 3) Then
                    sngMul = 1 / (bmp01.Width / 640)
                Else
                    sngMul = 1 / (bmp01.Height / 480)
                End If
                bmpTemp = New Bitmap(bmp01, (bmp01.Width * sngMul), (bmp01.Height * sngMul))
                bmpTemp.SetResolution(bmp01.HorizontalResolution, bmp01.VerticalResolution)
                bmp01 = bmpTemp
            End If

            bmp02 = New Bitmap(bmp01)
            bmpTemp = New Bitmap(bmp01)
            pictureDisplay.Image = bmp01
            Me.Text = "ImageStudio(" & openFileDialog.FileName & ")"
        End If


    End Sub

    Private Sub convertImage_Click(sender As Object, e As EventArgs) Handles convertImage.Click
        If pictureDisplay.Image Is Nothing Then
            Exit Sub
        End If

        Dim partWidth As Integer = bmp02.Width \ 3

        For y As Integer = 0 To bmp02.Height - 1
            For x As Integer = 0 To bmp02.Width - 1
                Dim partIndex As Integer = x \ partWidth
                clr = bmp02.GetPixel(x, y)

                Dim originalColor As Color = bmp02.GetPixel(x, y)


                Select Case partIndex
                    Case 0
                        clrTemp = Color.FromArgb(originalColor.A, originalColor.R, 0, 0)
                    Case 1
                        clrTemp = Color.FromArgb(originalColor.A, 0, originalColor.G, 0)
                    Case 2
                        clrTemp = Color.FromArgb(originalColor.A, 0, 0, originalColor.B)

                End Select


                bmp02.SetPixel(x, y, clrTemp)
                bmpTemp.SetPixel(x, y, clrTemp)
            Next
        Next

        pictureDisplay.Image = bmp02

    End Sub


End Class
