Public Class Form1

    Private Sub ScreensaverForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Menampilkan animasi GIF pada PictureBox
        PictureBox1.Image = My.Resources.Always_Lock_Your_Computer_01
        ' Ganti "YourGif" dengan nama animasi GIF Anda di Resources
        ' Atur properti form untuk fullscreen
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.TopMost = True

        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    ' Menutup screensaver saat ada aktivitas mouse atau keyboard
    Private Sub ScreensaverForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Me.Close()
    End Sub

    Private Sub ScreensaverForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Me.Close()
    End Sub

    Private Sub ScreensaverForm_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Me.Close()
    End Sub

End Class
