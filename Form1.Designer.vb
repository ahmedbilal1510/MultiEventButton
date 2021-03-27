<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnWelcome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnWelcome
        '
        Me.btnWelcome.Location = New System.Drawing.Point(247, 131)
        Me.btnWelcome.Name = "btnWelcome"
        Me.btnWelcome.Size = New System.Drawing.Size(276, 111)
        Me.btnWelcome.TabIndex = 0
        Me.btnWelcome.Text = "Welcome"
        Me.btnWelcome.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnWelcome)
        Me.Name = "Form1"
        Me.Text = "MultiEvent Ex"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnWelcome As Button
End Class
