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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotale = New System.Windows.Forms.TextBox()
        Me.txtGuariti = New System.Windows.Forms.TextBox()
        Me.txtDeceduti = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDataOra = New System.Windows.Forms.TextBox()
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
        Me.cbRegioni.Location = New System.Drawing.Point(508, 13)
        Me.cbRegioni.Name = "cbRegioni"
        Me.cbRegioni.Size = New System.Drawing.Size(121, 23)
        Me.cbRegioni.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(508, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Totale casi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(508, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Dimessi guariti"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(508, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Deceduti"
        '
        'txtTotale
        '
        Me.txtTotale.Location = New System.Drawing.Point(623, 119)
        Me.txtTotale.Name = "txtTotale"
        Me.txtTotale.Size = New System.Drawing.Size(100, 23)
        Me.txtTotale.TabIndex = 6
        '
        'txtGuariti
        '
        Me.txtGuariti.Location = New System.Drawing.Point(623, 157)
        Me.txtGuariti.Name = "txtGuariti"
        Me.txtGuariti.Size = New System.Drawing.Size(100, 23)
        Me.txtGuariti.TabIndex = 7
        '
        'txtDeceduti
        '
        Me.txtDeceduti.Location = New System.Drawing.Point(623, 201)
        Me.txtDeceduti.Name = "txtDeceduti"
        Me.txtDeceduti.Size = New System.Drawing.Size(100, 23)
        Me.txtDeceduti.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(508, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Data e ora"
        '
        'txtDataOra
        '
        Me.txtDataOra.Location = New System.Drawing.Point(623, 86)
        Me.txtDataOra.Name = "txtDataOra"
        Me.txtDataOra.Size = New System.Drawing.Size(100, 23)
        Me.txtDataOra.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDataOra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDeceduti)
        Me.Controls.Add(Me.txtGuariti)
        Me.Controls.Add(Me.txtTotale)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbRegioni)
        Me.Controls.Add(Me.rtbJsonData)
        Me.Controls.Add(Me.Carica)
        Me.Name = "Form1"
        Me.Text = "Data e ora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Carica As Button
    Friend WithEvents rtbJsonData As RichTextBox
    Friend WithEvents cbRegioni As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotale As TextBox
    Friend WithEvents txtGuariti As TextBox
    Friend WithEvents txtDeceduti As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDataOra As TextBox
End Class
