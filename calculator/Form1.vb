Public Class Form1
    Dim value1 As String = ""
    Dim value2 As String = ""
    Dim value3 As Double = 0.0

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button1.Text = value1 Then
            Button1.Text = sender.text
        ElseIf Button1.Text = "0." Then
            Button1.Text = sender.text
        ElseIf Button1.Text = value3 Then
            Button1.Text = sender.text
        Else
            Button1.Text = Button1.Text & sender.text

        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        value1 = ""
        value2 = ""
        value3 = 0.0
        Button1.Text = 0.0


    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        End
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If value1 > "" And value2 = "+" Then
            Button1.Text = Val(value1) + Val(Button1.Text)
            value3 = Button1.Text
        ElseIf value1 > "" And value2 = "-" Then
            Button1.Text = Val(value1) - Val(Button1.Text)
            value3 = Button1.Text
        ElseIf value1 > "" And value2 = "*" Then
            Button1.Text = Val(value1) * Val(Button1.Text)
            value3 = Button1.Text
        ElseIf value1 > "" And value2 = "/" Then
            Button1.Text = Val(value1) / Val(Button1.Text)
            value3 = Button1.Text
        Else


        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        value2 = sender.text
        value1 = Button1.Text

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        value2 = sender.text
        value1 = Button1.Text
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        value2 = sender.text
        value1 = Button1.Text
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        value2 = sender.text
        value1 = Button1.Text
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If Button1.Text = value1 Then
            Button1.Text = "0."
        ElseIf Button1.Text = "0." Then
            Button1.Text = "0."
        ElseIf Button1.Text = "0" Then
            Button1.Text = "0."
        ElseIf Button1.Text = value1 Then
            Button1.Text = "0."
        Else : Button1.Text = Button1.Text & "0"

        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If Button1.Text = "0." Then
            Button1.Text = "."
        ElseIf Button1.Text = value3 Then
            Button1.Text = "."
        ElseIf Button1.Text = value1 Then
            Button1.Text = "."
        Else
            If Button1.Text.Contains(".") Then
            Else
                Button1.Text = Button1.Text & "."

            End If
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If Button1.Text = value1 Then
            Button1.Text = sender.text
        ElseIf Button1.Text = "0." Then
            Button1.Text = sender.text
        ElseIf Button1.Text = value3 Then
            Button1.Text = sender.text
        Else
            Button1.Text = Button1.Text & sender.text

        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If Button1.Text = value1 Then
            Button1.Text = sender.text
        ElseIf Button1.Text = "0." Then
            Button1.Text = sender.text
        ElseIf Button1.Text = value3 Then
            Button1.Text = sender.text
        Else
            Button1.Text = Button1.Text & sender.text

        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If Button1.Text = value1 Then
            Button1.Text = sender.text
        ElseIf Button1.Text = "0." Then
            Button1.Text = sender.text
        ElseIf Button1.Text = value3 Then
            Button1.Text = sender.text
        Else
            Button1.Text = Button1.Text & sender.text

        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Button1.Text = value1 Then
            Button1.Text = sender.text
        ElseIf Button1.Text = "0." Then
            Button1.Text = sender.text
        ElseIf Button1.Text = value3 Then
            Button1.Text = sender.text
        Else
            Button1.Text = Button1.Text & sender.text

        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Button1.Text = value1 Then
            Button1.Text = sender.text
        ElseIf Button1.Text = "0." Then
            Button1.Text = sender.text
        ElseIf Button1.Text = value3 Then
            Button1.Text = sender.text
        Else
            Button1.Text = Button1.Text & sender.text

        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Button1.Text = value1 Then
            Button1.Text = sender.text
        ElseIf Button1.Text = "0." Then
            Button1.Text = sender.text
        ElseIf Button1.Text = value3 Then
            Button1.Text = sender.text
        Else
            Button1.Text = Button1.Text & sender.text

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button1.Text = value1 Then
            Button1.Text = sender.text
        ElseIf Button1.Text = "0." Then
            Button1.Text = sender.text
        ElseIf Button1.Text = value3 Then
            Button1.Text = sender.text
        Else
            Button1.Text = Button1.Text & sender.text

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button1.Text = value1 Then
            Button1.Text = sender.text
        ElseIf Button1.Text = "0." Then
            Button1.Text = sender.text
        ElseIf Button1.Text = value3 Then
            Button1.Text = sender.text
        Else
            Button1.Text = Button1.Text & sender.text

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button18_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button18.DoubleClick
        Application.Exit()


    End Sub

    Private Sub Form1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
