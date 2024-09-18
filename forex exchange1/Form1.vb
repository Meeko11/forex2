Public Class form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CRT1.SelectedIndexChanged
        If CRT1.SelectedIndex = 0 Then
            PictureBox1.Image = My.Resources.USa
        End If

        If CRT1.SelectedIndex = 1 Then
            PictureBox1.Image = My.Resources.HK
        End If

        If CRT1.SelectedIndex = 2 Then
            PictureBox1.Image = My.Resources.CANDA
        End If

        If CRT1.SelectedIndex = 3 Then
            PictureBox1.Image = My.Resources.INDIA
        End If

        If CRT1.SelectedIndex = 4 Then
            PictureBox1.Image = My.Resources.SRi
        End If

        If CRT1.SelectedIndex = 5 Then
            PictureBox1.Image = My.Resources.EU
        End If

        If CRT1.SelectedIndex = 6 Then
            PictureBox1.Image = My.Resources.HKG
        End If

        If CRT1.SelectedIndex = 7 Then
            PictureBox1.Image = My.Resources.JP
        End If

        If CRT1.SelectedIndex = 8 Then
            PictureBox1.Image = My.Resources.EU
        End If

        If CRT1.SelectedIndex = 9 Then
            PictureBox1.Image = My.Resources.ph
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CRT2.SelectedIndexChanged
        If CRT2.SelectedIndex = 0 Then
            PictureBox2.Image = My.Resources.USa
        End If

        If CRT2.SelectedIndex = 1 Then
            PictureBox2.Image = My.Resources.HK
        End If

        If CRT2.SelectedIndex = 2 Then
            PictureBox2.Image = My.Resources.CANDA
        End If

        If CRT2.SelectedIndex = 3 Then
            PictureBox2.Image = My.Resources.INDIA
        End If

        If CRT2.SelectedIndex = 4 Then
            PictureBox2.Image = My.Resources.SRi
        End If

        If CRT2.SelectedIndex = 5 Then
            PictureBox2.Image = My.Resources.EU
        End If

        If CRT2.SelectedIndex = 6 Then
            PictureBox2.Image = My.Resources.HKG
        End If

        If CRT2.SelectedIndex = 7 Then
            PictureBox2.Image = My.Resources.JP
        End If

        If CRT2.SelectedIndex = 8 Then
            PictureBox2.Image = My.Resources.EU
        End If

        If CRT2.SelectedIndex = 9 Then
            PictureBox2.Image = My.Resources.ph
        End If
    End Sub

    Private Sub CPT_Click(sender As Object, e As EventArgs) Handles CPT.Click
        Dim cb1index As Integer = CRT1.SelectedIndex
        Dim cb2index As Integer = CRT2.SelectedIndex
        Dim amount As Double = Val(TextBox1.Text)
        'USA to USA
        If cb1index = 0 And cb2index = 0 Then
            TextBox2.Text = amount
            'USA to HK
        ElseIf cb1index = 0 And cb2index = 1 Then
            TextBox2.Text = amount * 7.79
            'USA to Canada
        ElseIf cb1index = 0 And cb2index = 2 Then
            TextBox2.Text = amount * 1.36
            'USA to india
        ElseIf cb1index = 0 And cb2index = 3 Then
            TextBox2.Text = amount * 83.72
            'USA to SRI
        ElseIf cb1index = 0 And cb2index = 4 Then
            TextBox2.Text = amount * 303.44
            'USA to EU
        ElseIf cb1index = 0 And cb2index = 4 Then
            TextBox2.Text = amount * 0.9
        End If



    End Sub
End Class
