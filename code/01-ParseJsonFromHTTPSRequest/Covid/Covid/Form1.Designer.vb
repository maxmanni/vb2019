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
        Me.Carica = New System.Windows.Forms.Button()
        Me.rtbJsonData = New System.Windows.Forms.RichTextBox()
        Me.cbRegioni = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Carica
        '
        Me.Carica.Location = New System.Drawing.Point(35, 12)
        Me.Carica.Name = "Carica"
        Me.Carica.Size = New System.Drawing.Size(75, 23)
        Me.Carica.TabIndex = 0
        Me.Carica.Text = "Carica"
        Me.Carica.UseVisualStyleBackColor = True
        '
        'rtbJsonData
        '
        Me.rtbJsonData.Location = New System.Drawing.Point(35, 54)
        Me.rtbJsonData.Name = "rtbJsonData"
        Me.rtbJsonData.Size = New System.Drawing.Size(424, 310)
        Me.rtbJsonData.TabIndex = 1
        Me.rtbJsonData.Text = ""
        '
        'cbRegioni
        '
        Me.cbRegioni.FormattingEnabled = True
        Me.cbRegioni.Location = New System.Drawing.Point(552, 54)
        Me.cbRegioni.Name = "cbRegioni"
        Me.cbRegioni.Size = New System.Drawing.Size(121, 23)
        Me.cbRegioni.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbRegioni)
        Me.Controls.Add(Me.rtbJsonData)
        Me.Controls.Add(Me.Carica)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Carica As Button
    Friend WithEvents rtbJsonData As RichTextBox
    Friend WithEvents cbRegioni As ComboBox
End Class
