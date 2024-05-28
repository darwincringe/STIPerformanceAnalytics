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
        Label1 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        loginButton = New Button()
        LinkLabel1 = New LinkLabel()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        LinkLabel2 = New LinkLabel()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(196, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(385, 40)
        Label1.TabIndex = 0
        Label1.Text = "STI Performance Analytics "
        ' 
        ' loginButton
        ' 
        loginButton.Location = New Point(495, 244)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(86, 25)
        loginButton.TabIndex = 1
        loginButton.Text = "Login"
        loginButton.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(196, 247)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(99, 17)
        LinkLabel1.TabIndex = 2
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Login as admin?"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(274, 136)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(307, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(274, 165)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(307, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(196, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 17)
        Label2.TabIndex = 5
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(196, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 17)
        Label3.TabIndex = 6
        Label3.Text = "Password:"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LinkLabel2.Location = New Point(482, 191)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(106, 17)
        LinkLabel2.TabIndex = 7
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Forgot Password?"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 8
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(495, 17)
        ToolStripStatusLabel1.Text = "2024 Created By Ariella Lariba, Earl Buscagan, Eggy Ladiao, Janine Sutiangso, and John Garcia"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(800, 450)
        Controls.Add(StatusStrip1)
        Controls.Add(LinkLabel2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(loginButton)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents loginButton As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel

End Class
