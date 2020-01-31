<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOption
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextLine = New System.Windows.Forms.TextBox()
        Me.ButtonOutput = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.RepeatCheck = New System.Windows.Forms.CheckBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(28, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "单次显示条数"
        '
        'TextLine
        '
        Me.TextLine.Font = New System.Drawing.Font("微软雅黑", 13.0!)
        Me.TextLine.Location = New System.Drawing.Point(166, 34)
        Me.TextLine.Name = "TextLine"
        Me.TextLine.Size = New System.Drawing.Size(173, 30)
        Me.TextLine.TabIndex = 1
        '
        'ButtonOutput
        '
        Me.ButtonOutput.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ButtonOutput.Location = New System.Drawing.Point(28, 76)
        Me.ButtonOutput.Name = "ButtonOutput"
        Me.ButtonOutput.Size = New System.Drawing.Size(118, 34)
        Me.ButtonOutput.TabIndex = 2
        Me.ButtonOutput.Text = "导出听写内容"
        Me.ButtonOutput.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Font = New System.Drawing.Font("微软雅黑", 13.0!)
        Me.ButtonOK.Location = New System.Drawing.Point(282, 102)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(109, 44)
        Me.ButtonOK.TabIndex = 4
        Me.ButtonOK.Text = "确定"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'RepeatCheck
        '
        Me.RepeatCheck.AutoSize = True
        Me.RepeatCheck.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.RepeatCheck.Location = New System.Drawing.Point(167, 114)
        Me.RepeatCheck.Name = "RepeatCheck"
        Me.RepeatCheck.Size = New System.Drawing.Size(88, 24)
        Me.RepeatCheck.TabIndex = 5
        Me.RepeatCheck.Text = "允许重复"
        Me.RepeatCheck.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ButtonClear.Location = New System.Drawing.Point(28, 122)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(118, 34)
        Me.ButtonClear.TabIndex = 6
        Me.ButtonClear.Text = "清空听写记录"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'FormOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 168)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.RepeatCheck)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ButtonOutput)
        Me.Controls.Add(Me.TextLine)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormOption"
        Me.Text = "选项"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextLine As TextBox
    Friend WithEvents ButtonOutput As Button
    Friend WithEvents ButtonOK As Button
    Friend WithEvents RepeatCheck As CheckBox
    Friend WithEvents ButtonClear As Button
End Class
