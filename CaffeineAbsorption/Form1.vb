Public Class frmCaffeinAbsorption
    Const CaffeinePerCup As Double = 130.0
    Const Absorbed As Double = 0.13 ' hourly absorption at 13%

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        txt1.Text = Question1().ToString("N0") & " hours"
        txt2.Text = Question2().ToString("N") & " mg"
        txt3.Text = Question3().ToString("N") & " mg"

    End Sub

    Private Function Question1() As Integer
        ' When will 65mg remain? We start at 130mg, and it degrades at 13% per hour. So each hour, we multiply by 13%
        ' How many hours will be required for this to hit 65mg?
        Dim hours As Integer
        Dim amount As Double = CaffeinePerCup

        Do Until amount <= CaffeinePerCup / 2 ' run loop until it is half of the original amount
            amount = (1 - Absorbed) * amount ' .87 multiplied by the remaining amount
            hours += 1
        Loop

        Return hours
    End Function

    Private Function Question2() As Double
        ' Quantity after 24 hours
        Dim amount As Double = CaffeinePerCup

        For index = 1 To 24
            amount = (1 - Absorbed) * amount
        Next

        Return amount
    End Function

    Private Function Question3() As Double
        ' Hourly cups - Quantity after
        Dim amount As Double = CaffeinePerCup

        For index = 1 To 24
            amount = (1 - Absorbed) * amount + CaffeinePerCup
        Next

        Return amount
    End Function


End Class
