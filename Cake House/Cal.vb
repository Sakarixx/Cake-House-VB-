Public Class Cal
    Dim op As String
    Dim number1, number2 As Integer
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Me.Close()
    End Sub

    Private Sub Cal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAddition.Click
        number1 = Result.Text
        Result.Text = ""
        op = "+"
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        number2 = Result.Text
        If op = "+" Then
            Result.Text = number1 + number2
        ElseIf op = "-" Then
            Result.Text = number1 - number2
        ElseIf op = "x" Then
            Result.Text = number1 * number2
        ElseIf op = "/" Then
            Result.Text = number1 / number2
        End If
    End Sub

    Private Sub bttSubtraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttSubtraction.Click
        number1 = Result.Text
        Result.Text = ""
        op = "-"
    End Sub

    Private Sub bttMultiplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttMultiplication.Click
        number1 = Result.Text
        Result.Text = ""
        op = "x"
    End Sub

    Private Sub bttDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttDivision.Click
        number1 = Result.Text
        Result.Text = ""
        op = "/"
    End Sub

    Private Sub num0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num0.Click
        Result.Text = Result.Text & "0"
    End Sub

    Private Sub num1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num1.Click
        Result.Text = Result.Text & "1"
    End Sub

    Private Sub num2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num2.Click
        Result.Text = Result.Text & "2"
    End Sub

    Private Sub num3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num3.Click
        Result.Text = Result.Text & "3"
    End Sub

    Private Sub num4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num4.Click
        Result.Text = Result.Text & "4"
    End Sub

    Private Sub num5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num5.Click
        Result.Text = Result.Text & "5"
    End Sub

    Private Sub num6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num6.Click
        Result.Text = Result.Text & "6"
    End Sub

    Private Sub num7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num7.Click
        Result.Text = Result.Text & "7"
    End Sub

    Private Sub num8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num8.Click
        Result.Text = Result.Text & "8"
    End Sub

    Private Sub num9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num9.Click
        Result.Text = Result.Text & "9"
    End Sub
End Class