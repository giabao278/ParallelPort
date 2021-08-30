Public Class Form1
    Private Sub dec_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dec_textbox.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim dec_txtb As Integer = Val(dec_textbox.Text)

            hex_textbox.Text = UCase(Convert.ToString(dec_txtb, 16))
            oct_textbox.Text = Convert.ToString(dec_txtb, 8)

            Dim bin_txtb As String = Convert.ToString(dec_txtb, 2)

            If Len(bin_txtb) < 8 Then
                Dim lgt As Integer = 8 - Len(bin_txtb)
                Do Until lgt >= 8
                    bin_txtb = Convert.ToString(0) & bin_txtb
                    lgt = Len(bin_txtb)
                Loop
            End If
            bin_textbox.Text = bin_txtb

            'check led function
            For cnt = 1 To 8
                checkLed((cnt - 1), Mid(bin_txtb, 9 - cnt, 1))
            Next
        End If
    End Sub

    Private Sub hex_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hex_textbox.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim hex_txtb As String = hex_textbox.Text
            Dim hex_convert As Integer = Convert.ToInt16(hex_txtb, 16)

            dec_textbox.Text = Convert.ToString(hex_convert, 10)
            oct_textbox.Text = Convert.ToString(hex_convert, 8)
            hex_textbox.Text = UCase(hex_textbox.Text)

            Dim bin_txtb As String = Convert.ToString(hex_convert, 2)

            If Len(bin_txtb) < 8 Then
                Dim lgt As Integer = 8 - Len(bin_txtb)
                Do Until lgt >= 8
                    bin_txtb = Convert.ToString(0) & bin_txtb
                    lgt = Len(bin_txtb)
                Loop
            End If
            bin_textbox.Text = bin_txtb

            'check led function
            For cnt = 1 To 8
                checkLed((cnt - 1), Mid(bin_txtb, 9 - cnt, 1))
            Next

        End If
    End Sub

    Private Sub oct_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles oct_textbox.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim oct_txtb As String = oct_textbox.Text
            Dim oct_convert As Integer = Convert.ToInt16(oct_txtb, 8)

            dec_textbox.Text = Convert.ToString(oct_convert, 10)
            hex_textbox.Text = UCase(Convert.ToString(oct_convert, 16))

            Dim bin_txtb As String = Convert.ToString(oct_convert, 2)

            If Len(bin_txtb) < 8 Then
                Dim lgt As Integer = 8 - Len(bin_txtb)
                Do Until lgt >= 8
                    bin_txtb = Convert.ToString(0) & bin_txtb
                    lgt = Len(bin_txtb)
                Loop
            End If
            bin_textbox.Text = bin_txtb

            'check led function
            For cnt = 1 To 8
                checkLed((cnt - 1), Mid(bin_txtb, 9 - cnt, 1))
            Next
        End If
    End Sub

    Private Sub bin_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bin_textbox.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim bin_txtb As Integer = Val(bin_textbox.Text)
            Dim bin_convert As Integer = Convert.ToInt16(bin_txtb, 2)

            dec_textbox.Text = Convert.ToString(bin_convert, 10)
            hex_textbox.Text = UCase(Convert.ToString(bin_convert, 16))
            oct_textbox.Text = Convert.ToString(bin_convert, 8)

            Dim bin_cmp As String = Convert.ToString(bin_convert, 2)

            If Len(bin_cmp) < 8 Then
                Dim lgt As Integer = 8 - Len(bin_cmp)
                Do Until lgt >= 8
                    bin_cmp = Convert.ToString(0) & bin_cmp
                    lgt = Len(bin_cmp)
                Loop
            End If
            bin_textbox.Text = Convert.ToString(bin_cmp)

            'check led function
            For cnt = 1 To 8
                checkLed((cnt - 1), Mid(bin_cmp, 9 - cnt, 1))
            Next
        End If
    End Sub

    Public Sub checkLed(numOfLed As Integer, logicVal As Integer)
        Select Case numOfLed
            Case 0
                If logicVal = 1 Then
                    Led0_btn.FillColor = Color.Red
                ElseIf logicVal = 0 Then
                    Led0_btn.FillColor = Color.FromArgb(94, 148, 255)
                End If
            Case 1
                If logicVal = 1 Then
                    Led1_btn.FillColor = Color.Red
                ElseIf logicVal = 0 Then
                    Led1_btn.FillColor = Color.FromArgb(94, 148, 255)
                End If
            Case 2
                If logicVal = 1 Then
                    Led2_btn.FillColor = Color.Red
                ElseIf logicVal = 0 Then
                    Led2_btn.FillColor = Color.FromArgb(94, 148, 255)
                End If
            Case 3
                If logicVal = 1 Then
                    Led3_btn.FillColor = Color.Red
                ElseIf logicVal = 0 Then
                    Led3_btn.FillColor = Color.FromArgb(94, 148, 255)
                End If
            Case 4
                If logicVal = 1 Then
                    Led4_btn.FillColor = Color.Red
                ElseIf logicVal = 0 Then
                    Led4_btn.FillColor = Color.FromArgb(94, 148, 255)
                End If
            Case 5
                If logicVal = 1 Then
                    Led5_btn.FillColor = Color.Red
                ElseIf logicVal = 0 Then
                    Led5_btn.FillColor = Color.FromArgb(94, 148, 255)
                End If
            Case 6
                If logicVal = 1 Then
                    Led6_btn.FillColor = Color.Red
                ElseIf logicVal = 0 Then
                    Led6_btn.FillColor = Color.FromArgb(94, 148, 255)
                End If
            Case 7
                If logicVal = 1 Then
                    Led7_btn.FillColor = Color.Red
                ElseIf logicVal = 0 Then
                    Led7_btn.FillColor = Color.FromArgb(94, 148, 255)
                End If
        End Select
    End Sub

    Private Sub Led7_btn_Click(sender As Object, e As EventArgs) Handles Led7_btn.Click

    End Sub
End Class