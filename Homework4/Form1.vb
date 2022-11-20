Public Class Form1
    Public b As Bitmap
    Public g As Graphics
    Public r As New Random
    Public PenTrajectory As New Pen(Color.OrangeRed, 2)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.b = New Bitmap(Me.PictureBox1.Width, Me.PictureBox1.Height)
        Me.g = Graphics.FromImage(b)

        Dim TrialsCount As Integer = 1000
        Dim NumerOfTrajectories As Integer = 30
        Dim SuccessProbability As Double = 0.5

        Dim minX As Double = 0
        Dim maxX As Double = TrialsCount
        Dim minY As Double = 0
        Dim maxY As Double = TrialsCount


        For i As Integer = 1 To NumerOfTrajectories

            Dim Punti As New List(Of Point)
            Dim Y As Double = 0
            For X As Integer = 1 To TrialsCount
                Dim Uniform As Double = r.NextDouble
                If Uniform < SuccessProbability Then
                    Y = Y + 1
                End If
                Dim xDevice As Integer = FromXRealToXVirtual(0, TrialsCount, PictureBox1.Width, X)
                Dim YDevice As Integer = FromYRealToYVirtual(0, TrialsCount, PictureBox1.Height, Y)
                Punti.Add(New Point(xDevice, YDevice))
            Next
            g.DrawLines(PenTrajectory, Punti.ToArray)
        Next

        Me.PictureBox1.Image = b

    End Sub

    Function FromXRealToXVirtual(minX As Double,
                                 maxX As Double, W As Integer,
                                 X As Double) As Integer

        If (maxX - minX) = 0 Then
            Return 0
        End If

        Return W * (X - minX) / (maxX - minX)

    End Function

    Function FromYRealToYVirtual(minY As Double,
                                maxY As Double, H As Integer,
                                Y As Double) As Integer

        If (maxY - minY) = 0 Then
            Return 0
        End If

        Return H - H * (Y - minY) / (maxY - minY)

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.b = New Bitmap(Me.PictureBox1.Width, Me.PictureBox1.Height)
        Me.g = Graphics.FromImage(b)

        Dim TrialsCount As Integer = 1000
        Dim NumerOfTrajectories As Integer = 30
        Dim SuccessProbability As Double = 0.5

        Dim minX As Double = 0
        Dim maxX As Double = TrialsCount
        Dim minY As Double = 0
        Dim maxY As Double = TrialsCount


        For i As Integer = 1 To NumerOfTrajectories

            Dim Punti As New List(Of Point)
            Dim Y As Double = 0
            For X As Integer = 1 To TrialsCount
                Dim Uniform As Double = r.NextDouble
                If Uniform < SuccessProbability Then
                    Y = Y + 1
                End If
                Dim xDevice As Integer = FromXRealToXVirtual(0, TrialsCount, PictureBox1.Height, X)
                Dim YDevice As Integer = FromYRealToYVirtual(0, TrialsCount, PictureBox1.Width, Y * TrialsCount / (X + 1))
                Punti.Add(New Point(xDevice, YDevice))
            Next
            g.DrawLines(PenTrajectory, Punti.ToArray)
        Next

        Me.PictureBox1.Image = b
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.b = New Bitmap(Me.PictureBox1.Width, Me.PictureBox1.Height)
        Me.g = Graphics.FromImage(b)

        Dim TrialsCount As Integer = 1000
        Dim NumerOfTrajectories As Integer = 30
        Dim SuccessProbability As Double = 0.5

        Dim minX As Double = 0
        Dim maxX As Double = TrialsCount
        Dim minY As Double = 0
        Dim maxY As Double = TrialsCount


        For i As Integer = 1 To NumerOfTrajectories

            Dim Punti As New List(Of Point)
            Dim Y As Double = 0
            For X As Integer = 1 To TrialsCount
                Dim Uniform As Double = r.NextDouble
                If Uniform < SuccessProbability Then
                    Y = Y + 1
                End If
                Dim xDevice As Integer = FromXRealToXVirtual(0, TrialsCount, PictureBox1.Height, X)
                Dim YDevice As Integer = FromYRealToYVirtual(0, TrialsCount, PictureBox1.Width, Y * Math.Sqrt(TrialsCount) / Math.Sqrt((X + 1)))
                Punti.Add(New Point(xDevice, YDevice))
            Next
            g.DrawLines(PenTrajectory, Punti.ToArray)
        Next

        Me.PictureBox1.Image = b
    End Sub
End Class
