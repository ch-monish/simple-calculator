Imports MediaFoundation.OPM
Imports System.Math
Public Class Form1
    Dim value1 As Double
    Dim value2 As Double
    Dim Operat As Char

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        result.Text = result.Text + "3"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        result.Text = result.Text + "9"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        result.Text = result.Text + "0"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click

        result.Text = result.Text + "1"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        result.Text = result.Text + "2"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        result.Text = result.Text + "4"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        result.Text = result.Text + "5"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        result.Text = result.Text + "6"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        result.Text = result.Text + "7"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        result.Text = result.Text + "8"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        result.Text = 0
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        result.Text = result.Text + "."
    End Sub




    'METHODS FOR OPERATIONS
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        value1 = Double.Parse(result.Text)
        result.Text = 0

        Operat = "+"
        result.Text = 0




    End Sub



    '-operation
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        value1 = Double.Parse(result.Text)
        result.Text = 0

        Operat = "-"
        result.Text = 0

    End Sub


    '*operator
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        value1 = Double.Parse(result.Text)
        result.Text = 0

        Operat = "*"
        result.Text = 0

    End Sub



    '/operator
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        value1 = Double.Parse(result.Text)
        result.Text = 0

        Operat = "/"
        result.Text = 0

    End Sub
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        value1 = Double.Parse(result.Text)
        result.Text = 0
        Operat = "p"
        result.Text = 0
    End Sub
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        value1 = Double.Parse(result.Text)
        result.Text = 0
        'Operat = "q"
        result.Text = Sqrt(value1)
    End Sub


    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        If (Operat = "+") Then


            value2 = Double.Parse(result.Text)
            result.Text = (value1 + value2).ToString
            'result.Text = Operat
        End If


        If (Operat = "-") Then


            value2 = Double.Parse(result.Text)
            result.Text = (value1 - value2).ToString
            'result.Text = Operat
        End If

        If (Operat = "*") Then


            value2 = Double.Parse(result.Text)
            result.Text = (value1 * value2).ToString
            'result.Text = Operat
        End If

        If (Operat = "/") Then


            value2 = Double.Parse(result.Text)
            result.Text = (value1 / value2).ToString
            'result.Text = Operat
        End If

        If (Operat = "p") Then


            value2 = Double.Parse(result.Text)
            result.Text = (Pow(value1, value2)).ToString
            'result.Text = Operat
        End If




        If (Operat = "q") Then


            value2 = Double.Parse(result.Text)
            'value2 = (1 / value2)
            result.Text = (Sqrt(value1)).ToString
            'result.Text = Operat
        End If
    End Sub
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click

        value1 = Double.Parse(result.Text)
        result.Text = Log10(value1).ToString
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        'result.Text = result.Text + "sin("
        Operat = "sin("
        value1 = Double.Parse(result.Text)
        result.Text = Sin(value1 * (PI / 180)).ToString


    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        value1 = Double.Parse(result.Text)
        result.Text = Cos(value1 * (PI / 180)).ToString
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        value1 = Double.Parse(result.Text)
        result.Text = Tan(value1 * (PI / 180)).ToString
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        value1 = Double.Parse(result.Text)
        result.Text = (1 / Tan(value1 * (PI / 180))).ToString
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        value1 = Double.Parse(result.Text)
        result.Text = (1 / Cos(value1 * (PI / 180))).ToString
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        value1 = Double.Parse(result.Text)
        result.Text = (1 / Sin(value1 * (PI / 180))).ToString
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        result.Text = 0

    End Sub
End Class
