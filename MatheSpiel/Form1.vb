Public Class Form1

    Private Sub CreateExercise(addition As Boolean, subtraction As Boolean, multiplication As Boolean, division As Boolean)

        Dim token1, token2, token3, token4, token5 As String

        Dim rechenwuerfel As Random = New Random

        ' nur eine rechenart

        If addition And Not subtraction And Not multiplication And Not division Then
            'wuerfel ob rechenzeichen an token2 oder token4
            If (CInt(Math.Ceiling(Rnd() * 10)) + 1) > 5 Then 'an token2
                token2 = "+"
                token1 = CInt(Math.Ceiling(Rnd() * 22)) + 1
                token3 = CInt(Math.Ceiling(Rnd() * 22)) + 1
                token4 = "="
                token5 = CInt(token1) + CInt(token3)
            Else ' an token4
                token2 = "="
                token5 = CInt(Math.Ceiling(Rnd() * 22)) + 1
                token3 = CInt(Math.Ceiling(Rnd() * 22)) + 1
                token4 = "+"
                token1 = CInt(token5) + CInt(token3)
            End If

            tb_token1.Text = token1
            tb_token2.Text = token2
            tb_token3.Text = token3
            tb_token4.Text = token4
            tb_token5.Text = token5

            If Label2.Text = "Label2" Then
                Label2.Text = "add"
            ElseIf Label2.Text = "add" Then
                Label2.Text = "ADD"
            ElseIf Label2.Text = "ADD" Then
                Label2.Text = "add"
            End If


        End If


        If Not addition And subtraction And Not multiplication And Not division Then

        End If

        If Not addition And Not subtraction And multiplication And Not division Then

        End If

        If Not addition And Not subtraction And Not multiplication And division Then

        End If




    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        CreateExercise(chkb_add.Checked, chkb_sub.Checked, chkb_mult.Checked, chkb_div.Checked)


    End Sub


    Private Sub act_code()

        Dim rechenarten() As Boolean = {chkb_add.Checked, chkb_sub.Checked, chkb_mult.Checked, chkb_div.Checked}
        Dim dings As String = ""

        For Each schalter In rechenarten
            If schalter Then
                dings = dings + "1"
            Else
                dings = dings + "0"
            End If

        Next

        Label1.Text = dings

    End Sub

    Private Sub chkb_add_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkb_add.CheckedChanged
        act_code()
    End Sub
    Private Sub chkb_sub_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkb_sub.CheckedChanged
        act_code()
    End Sub
    Private Sub chkb_mult_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkb_mult.CheckedChanged
        act_code()
    End Sub
    Private Sub chkb_div_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkb_div.CheckedChanged
        act_code()
    End Sub



End Class
