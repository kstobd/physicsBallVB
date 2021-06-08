Public Class BallPhysicsKst
    Dim V0, A, S, L, H, wind As Single
    Dim Graph1 As Graphics
    Dim Pen1 As New Pen(Color.Black, A)
    Dim Pen2 As New Pen(Color.Blue, 3)
    Dim drawBrush As New SolidBrush(Color.Black)
    Dim drawFont As New Font("Arial", 10)
    Dim X, Y, T As Single
    Function Сompute()
        L = S * Math.Tan(A * Pi / 180) - (G * S ^ 2) / (2 * (V0 + wind) ^ 2 * Math.Cos(A * Pi / 180) ^ 2)
        LTB.Text = L
    End Function
    Function Result()
        Select Case L
            Case Is < 0
                resTB.Text = "Heдoлeт"
            Case Is > H
                resTB.Text = "Пepeлeт"
            Case Else
                resTB.Text = "Попадание"
        End Select
    End Function
    Function Draw()
        Graph1 = Me.PictureBox1.CreateGraphics()
        Graph1.Clear(Color.White)
        For X = 0 To 400 Step 50
            Graph1.DrawString(X / 10, drawFont, drawBrush, X, 200)
        Next X
        For Y = 20 To 220 Step 50
            Graph1.DrawString((Y - 20) / 10, drawFont, drawBrush, 0, 220 - Y)
        Next Y
        Graph1.ScaleTransform(1, -1)
        Graph1.TranslateTransform(0, -200)
        Graph1.DrawLine(Pen1, 0, 0, 400, 0)
        Graph1.DrawLine(Pen1, 0, -20, 0, 200)
        Graph1.DrawLine(Pen1, S * 10, 0, S * 10, H * 10)
        For T = 0 To 10 Step 0.1
            Y = (V0 + wind) * Math.Sin(A * Pi / 180) * T - G * T * T / 2
            X = (V0 + wind) * Math.Cos(A * Pi / 180) * T
            If (X * 10 < S * 10) And (L < H) And (Y > 0) Then
                Graph1.DrawEllipse(Pen2, X * 10, Y * 10, 1, 1)
            ElseIf (L > H) And (Y > 0) Then
                Graph1.DrawEllipse(Pen2, X * 10, Y * 10, 1, 1)
            End If
        Next T
    End Function
    Function Work()
        Сompute()
        Result()
        Draw()
    End Function

    Private Sub windNum_ValueChanged(sender As Object, e As EventArgs) Handles windNum.ValueChanged
        wind = Val(windNum.Value)
        If poR.Checked Then
            wind *= -1
        End If
        Work()
    End Sub

    Private Sub poR_CheckedChanged(sender As Object, e As EventArgs) Handles poR.CheckedChanged
        wind = Val(windNum.Value) * -1
        Work()
    End Sub

    Private Sub protR_CheckedChanged(sender As Object, e As EventArgs) Handles protR.CheckedChanged
        wind = Val(windNum.Value)
        Work()
    End Sub

    Private Sub BallPhysicsKst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Draw()
    End Sub

    Private Sub aNum_ValueChanged(sender As Object, e As EventArgs) Handles aNum.ValueChanged
        A = Val(aNum.Value)
        Work()
    End Sub

    Private Sub sNum_ValueChanged(sender As Object, e As EventArgs) Handles sNum.ValueChanged
        S = Val(sNum.Value)
        Work()
    End Sub

    Private Sub hNum_ValueChanged(sender As Object, e As EventArgs) Handles hNum.ValueChanged
        H = Val(hNum.Value)
        Work()
    End Sub

    Private Sub v0Num_ValueChanged(sender As Object, e As EventArgs) Handles v0Num.ValueChanged
        V0 = Val(v0Num.Value)
        Work()
    End Sub

    Const G As Single = 9.81
    Const Pi As Single = 3.14

End Class
