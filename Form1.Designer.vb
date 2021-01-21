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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEvaluate = New System.Windows.Forms.Button()
        Me.tbA = New System.Windows.Forms.TextBox()
        Me.tbB = New System.Windows.Forms.TextBox()
        Me.tbAtimesB = New System.Windows.Forms.TextBox()
        Me.tbAdividedB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "B: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "A*B:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "A/B:"
        '
        'btnEvaluate
        '
        Me.btnEvaluate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEvaluate.Location = New System.Drawing.Point(397, 70)
        Me.btnEvaluate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(126, 48)
        Me.btnEvaluate.TabIndex = 1
        Me.btnEvaluate.Text = "Evaluate"
        Me.btnEvaluate.UseVisualStyleBackColor = True
        '
        'tbA
        '
        Me.tbA.Location = New System.Drawing.Point(55, 24)
        Me.tbA.Name = "tbA"
        Me.tbA.Size = New System.Drawing.Size(100, 30)
        Me.tbA.TabIndex = 2
        '
        'tbB
        '
        Me.tbB.Location = New System.Drawing.Point(238, 24)
        Me.tbB.Name = "tbB"
        Me.tbB.Size = New System.Drawing.Size(100, 30)
        Me.tbB.TabIndex = 2
        '
        'tbAtimesB
        '
        Me.tbAtimesB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tbAtimesB.Enabled = False
        Me.tbAtimesB.Location = New System.Drawing.Point(82, 97)
        Me.tbAtimesB.Name = "tbAtimesB"
        Me.tbAtimesB.Size = New System.Drawing.Size(139, 30)
        Me.tbAtimesB.TabIndex = 2
        '
        'tbAdividedB
        '
        Me.tbAdividedB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tbAdividedB.Enabled = False
        Me.tbAdividedB.Location = New System.Drawing.Point(82, 150)
        Me.tbAdividedB.Name = "tbAdividedB"
        Me.tbAdividedB.Size = New System.Drawing.Size(139, 30)
        Me.tbAdividedB.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 218)
        Me.Controls.Add(Me.tbAdividedB)
        Me.Controls.Add(Me.tbAtimesB)
        Me.Controls.Add(Me.tbB)
        Me.Controls.Add(Me.tbA)
        Me.Controls.Add(Me.btnEvaluate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Operator Overloading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEvaluate As Button
    Friend WithEvents tbA As TextBox
    Friend WithEvents tbB As TextBox
    Friend WithEvents tbAtimesB As TextBox
    Friend WithEvents tbAdividedB As TextBox
End Class
