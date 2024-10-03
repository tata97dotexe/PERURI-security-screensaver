Public Class Form1
    Dim i As Integer = 0
    Dim num, x, cX, cY, direction As String

    Private Sub mousePos_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mousePos.TextChanged
        If Me.TransparencyKey = Nothing Then
            move.Stop()
            System.Windows.Forms.Cursor.Show()
            i = 0
            img.Image = Nothing
            Me.TransparencyKey = Color.Black

        End If
    End Sub

    Private Sub count_Tick(sender As Object, e As EventArgs) Handles count.Tick
        mousePos.Text = MousePosition.X & MousePosition.Y
        If Me.TransparencyKey = Color.Black Then
            i += 1
            num = i
        End If
        If i = 5 Then 'Delay to show Screensaver i put 5 to be short for this tutorial
            Me.WindowState = FormWindowState.Maximized
            Me.TopMost = True
            System.Windows.Forms.Cursor.Hide()
            i = 0
            x = 0
            img.Location = New Point((SystemInformation.VirtualScreen.Width / 2) - (img.Width / 2), (SystemInformation.VirtualScreen.Height / 2) - (img.Height / 2))

            img.Image = My.Resources.Always_Lock_Your_Computer__1_

            Me.TransparencyKey = Nothing
            move.Start()
        End If
    End Sub

    Private Sub move_Tick(sender As Object, e As EventArgs) Handles move.Tick
        cX = img.Location.X
        cY = img.Location.Y
        If x = 0 Then
            img.Location = New Point(img.Location.X - 1, img.Location.Y - 1)
        ElseIf direction = "TRight" Then
            img.Location = New Point(img.Location.X + 1, img.Location.Y - 1)
        ElseIf direction = "DRight" Then
            img.Location = New Point(img.Location.X + 1, img.Location.Y + 1)
        ElseIf direction = "DLeft" Then
            img.Location = New Point(img.Location.X - 1, img.Location.Y + 1)
        End If
        If img.Location.X < cX And img.Location.Y < cY Then
            direction = "TLeft"
        ElseIf img.Location.X > cX And img.Location.Y < cY Then
            direction = "TRight"
        ElseIf img.Location.X < cX And img.Location.Y > cY Then
            direction = "DLeft"
        ElseIf img.Location.X > cX And img.Location.Y > cY Then
            direction = "DRight"
        End If
        If img.Location.X = 0 And direction = "TLeft" Then
            x = 1
            direction = "TRight"
        ElseIf img.Location.Y = 0 And direction = "TLeft" Then
            x = 1
            direction = "DLeft"
        ElseIf img.Location.Y = 0 And direction = "TRight" Then
            x = 1
            direction = "DRight"
        ElseIf img.Location.X = Val(SystemInformation.VirtualScreen.Width - img.Width) And direction = "TRight" Then
            x = 0
            direction = "TLeft"
        ElseIf img.Location.X = Val(SystemInformation.VirtualScreen.Width - img.Width) And direction = "DRight" Then
            x = 1
            direction = "DLeft"
        ElseIf img.Location.X = 0 And direction = "DLeft" Then
            x = 1
            direction = "DRight"
        ElseIf img.Location.Y = Val(SystemInformation.VirtualScreen.Height - img.Height) And direction = "DLeft" Then
            x = 0
            direction = "TLeft"
        ElseIf img.Location.Y = Val(SystemInformation.VirtualScreen.Height - img.Height) And direction = "DRight" Then
            x = 0
            direction = "TRight"
        End If
    End Sub


End Class
