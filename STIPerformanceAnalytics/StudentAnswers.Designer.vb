<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentAnswers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        StudentName = New Label()
        textStudentName = New Label()
        Label1 = New Label()
        textStudentid = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' StudentName
        ' 
        StudentName.AutoSize = True
        StudentName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StudentName.Location = New Point(12, 9)
        StudentName.Name = "StudentName"
        StudentName.Size = New Size(119, 21)
        StudentName.TabIndex = 16
        StudentName.Text = "Student Name:"
        ' 
        ' textStudentName
        ' 
        textStudentName.AutoSize = True
        textStudentName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        textStudentName.Location = New Point(137, 9)
        textStudentName.Name = "textStudentName"
        textStudentName.Size = New Size(162, 21)
        textStudentName.TabIndex = 17
        textStudentName.Text = "<textStudentName>"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 21)
        Label1.TabIndex = 18
        Label1.Text = "Student ID:"
        ' 
        ' textStudentid
        ' 
        textStudentid.AutoSize = True
        textStudentid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        textStudentid.Location = New Point(137, 30)
        textStudentid.Name = "textStudentid"
        textStudentid.Size = New Size(133, 21)
        textStudentid.TabIndex = 19
        textStudentid.Text = "<textStudentid>"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 21)
        Label2.TabIndex = 20
        Label2.Text = "Answers"
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Location = New Point(12, 91)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(776, 347)
        Panel1.TabIndex = 25
        ' 
        ' StudentAnswers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(textStudentid)
        Controls.Add(Label1)
        Controls.Add(textStudentName)
        Controls.Add(StudentName)
        Name = "StudentAnswers"
        Text = "StudentAnswers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StudentName As Label
    Friend WithEvents textStudentName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textStudentid As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
