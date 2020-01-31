<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonOption = New System.Windows.Forms.Button()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.List2 = New System.Windows.Forms.ListBox()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonPrev = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'ButtonOption
        '
        Me.ButtonOption.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.ButtonOption.Location = New System.Drawing.Point(628, 458)
        Me.ButtonOption.Name = "ButtonOption"
        Me.ButtonOption.Size = New System.Drawing.Size(101, 37)
        Me.ButtonOption.TabIndex = 6
        Me.ButtonOption.Text = "选项"
        Me.ButtonOption.UseVisualStyleBackColor = True
        '
        'List1
        '
        Me.List1.Font = New System.Drawing.Font("微软雅黑", 20.0!)
        Me.List1.FormattingEnabled = True
        Me.List1.ItemHeight = 35
        Me.List1.Items.AddRange(New Object() {"点击  下一个", "以开始听写"})
        Me.List1.Location = New System.Drawing.Point(35, 10)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(248, 494)
        Me.List1.TabIndex = 0
        '
        'List2
        '
        Me.List2.Font = New System.Drawing.Font("微软雅黑", 20.0!)
        Me.List2.FormattingEnabled = True
        Me.List2.ItemHeight = 35
        Me.List2.Items.AddRange(New Object() {" "})
        Me.List2.Location = New System.Drawing.Point(339, 10)
        Me.List2.Name = "List2"
        Me.List2.Size = New System.Drawing.Size(248, 494)
        Me.List2.TabIndex = 1
        '
        'ButtonNext
        '
        Me.ButtonNext.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.ButtonNext.Location = New System.Drawing.Point(628, 33)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(101, 45)
        Me.ButtonNext.TabIndex = 2
        Me.ButtonNext.Text = "下一个"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonPrev
        '
        Me.ButtonPrev.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.ButtonPrev.Location = New System.Drawing.Point(628, 138)
        Me.ButtonPrev.Name = "ButtonPrev"
        Me.ButtonPrev.Size = New System.Drawing.Size(101, 45)
        Me.ButtonPrev.TabIndex = 3
        Me.ButtonPrev.Text = "上一个"
        Me.ButtonPrev.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "文本文件|*.txt"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 516)
        Me.Controls.Add(Me.ButtonPrev)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.List2)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.ButtonOption)
        Me.Name = "FormMain"
        Me.Text = "中文听写"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonOption As Button
    Friend WithEvents List1 As ListBox
    Friend WithEvents List2 As ListBox
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonPrev As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
