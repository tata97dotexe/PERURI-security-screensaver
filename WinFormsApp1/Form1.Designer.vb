<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        img = New PictureBox()
        mousePos = New Label()
        count = New Timer(components)
        move = New Timer(components)
        CType(img, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' img
        ' 
        img.Location = New Point(0, 0)
        img.Name = "img"
        img.Size = New Size(1600, 900)
        img.SizeMode = PictureBoxSizeMode.AutoSize
        img.TabIndex = 0
        img.TabStop = False
        ' 
        ' mousePos
        ' 
        mousePos.AutoSize = True
        mousePos.Font = New Font("Microsoft Sans Serif", 1.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mousePos.Location = New Point(12, 729)
        mousePos.Name = "mousePos"
        mousePos.Size = New Size(0, 2)
        mousePos.TabIndex = 1
        mousePos.Visible = False
        ' 
        ' count
        ' 
        count.Enabled = True
        count.Interval = 1000
        ' 
        ' move
        ' 
        move.Interval = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1600, 900)
        Controls.Add(mousePos)
        Controls.Add(img)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        ShowInTaskbar = False
        Text = "Form1"
        TransparencyKey = Color.Black
        WindowState = FormWindowState.Maximized
        CType(img, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents img As PictureBox
    Friend WithEvents mousePos As Label
    Friend WithEvents count As Timer
    Friend WithEvents move As Timer

End Class
