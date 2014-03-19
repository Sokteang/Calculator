Public Class frmcalcu
    Dim number, number1, operation As String

    Private Sub frmcalcu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnDivide.Text = Chr(247)
        btnNegative.Text = Chr(177)
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        number &= "1"
        txtDisplay.Text = number
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        number &= "2"
        txtDisplay.Text = number
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        number &= "3"
        txtDisplay.Text = number
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        number &= "4"
        txtDisplay.Text = number
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        number &= "5"
        txtDisplay.Text = number
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        number &= "6"
        txtDisplay.Text = number
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        number &= "7"
        txtDisplay.Text = number
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        number &= "8"
        txtDisplay.Text = number
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        number &= "9"
        txtDisplay.Text = number
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        number &= "0"
        txtDisplay.Text = number
    End Sub

    Private Sub btnAddition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddition.Click
        operation = "+"
        number1 = txtDisplay.Text
        number = ""
    End Sub

    Private Sub btnSubstract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubstract.Click
        operation = "-"
        number1 = txtDisplay.Text
        number = ""
    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        number1 = txtDisplay.Text
        number = ""
    End Sub

    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        number1 = txtDisplay.Text
        number = ""
    End Sub

    Private Sub btnPower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPower.Click
        number1 = txtDisplay.Text
        number = ""
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        number = ""
        txtDisplay.Text = ""
    End Sub

    Private Sub btnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click
        number = txtDisplay.Text
        If operation = "+" Then
            txtDisplay.Text = CDbl(number1) + CDbl(number)
        ElseIf operation = "-" Then
            txtDisplay.Text = CDbl(number1) - CDbl(number)
        ElseIf operation = "*" Then
            txtDisplay.Text = CDbl(number1) - CDbl(number)
        ElseIf operation = "/" Then
            txtDisplay.Text = CDbl(number1) - CDbl(number)

        End If

    End Sub

    Private Sub btnNegative_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNegative.Click
        txtDisplay.Text = CDbl(txtDisplay.Text) * -1
    End Sub

    Private Sub btndot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndot.Click
        number &= "."
        txtDisplay.Text = number
    End Sub
End Class
