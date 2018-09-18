<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaffeinAbsorption
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1Cup: When will 65mg remain?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1Cup: Quantity after 24hrs"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hourly cups: Quantity after 24hrs"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(207, 26)
        Me.txt1.Name = "txt1"
        Me.txt1.ReadOnly = True
        Me.txt1.Size = New System.Drawing.Size(142, 20)
        Me.txt1.TabIndex = 3
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(207, 69)
        Me.txt2.Name = "txt2"
        Me.txt2.ReadOnly = True
        Me.txt2.Size = New System.Drawing.Size(142, 20)
        Me.txt2.TabIndex = 4
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(207, 113)
        Me.txt3.Name = "txt3"
        Me.txt3.ReadOnly = True
        Me.txt3.Size = New System.Drawing.Size(142, 20)
        Me.txt3.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(35, 158)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(314, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Values"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmCaffeinAbsorption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 210)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCaffeinAbsorption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caffeine Absorption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents btnCalculate As Button
End Class
