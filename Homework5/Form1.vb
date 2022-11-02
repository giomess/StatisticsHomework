Imports System.Drawing.Drawing2D

Public Class Form1
    Private Const MIN_VALUE As Single = 0
    Private Const MAX_VALUE As Single = 100

    Private m_DataValues(9) As Single

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal _
    e As System.EventArgs) Handles MyBase.Load
        Dim rnd As New Random

        ' Create data.
        For i As Integer = 0 To m_DataValues.GetUpperBound(0)
            m_DataValues(i) = rnd.Next(MIN_VALUE + 5, MAX_VALUE _
            - 5)
        Next i
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e _
    As System.Windows.Forms.PaintEventArgs) Handles _
    PictureBox1.Paint
        e.Graphics.Clear(PictureBox1.BackColor)

        ' Flip vertically and scale to fit.
        Dim scalex As Single = PictureBox1.Width /
            (m_DataValues.GetUpperBound(0) + 1)
        Dim scaley As Single = -PictureBox1.Height / MAX_VALUE
        e.Graphics.ScaleTransform(
            scalex, scaley, MatrixOrder.Append)

        ' Translate so (0, MAX_VALUE) maps to the origin.
        e.Graphics.TranslateTransform(0, PictureBox1.Height,
            MatrixOrder.Append)

        ' Draw the histogram.
        For i As Integer = 0 To m_DataValues.GetUpperBound(0)
            Dim rect As New Rectangle(i, 0, 1, m_DataValues(i))
            Dim clr As Color = Color.FromArgb(&HFF000000 Or
                QBColor(i Mod 16))
            Dim the_brush As New SolidBrush(clr)
            Dim the_pen As New Pen(Color.Black, 0)
            e.Graphics.FillRectangle(the_brush, rect)
            e.Graphics.DrawRectangle(the_pen, rect)
            the_brush.Dispose()
            the_pen.Dispose()
        Next i

        e.Graphics.ResetTransform()
        e.Graphics.DrawRectangle(Pens.Black, 0, 0,
            PictureBox1.Width - 1, PictureBox1.Height - 1)
    End Sub

    Private Sub pictureBox_MouseDown(ByVal sender As Object,
    ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
    PictureBox1.MouseDown
        ' Determine which data value was clicked.
        Dim bar_wid As Single = PictureBox1.Width /
            (m_DataValues.GetUpperBound(0) + 1)
        Dim i As Integer = Int(e.X / bar_wid)
        MessageBox.Show("Colonna numero " & i & ": " & m_DataValues(i), "Value",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

