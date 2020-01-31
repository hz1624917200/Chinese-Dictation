<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.ButtonReadFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LabelFile = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ButtonSaveFile = New System.Windows.Forms.Button()
        Me.RBFileT = New System.Windows.Forms.RadioButton()
        Me.RBFileF = New System.Windows.Forms.RadioButton()
        Me.PanelFile = New System.Windows.Forms.Panel()
        Me.TextBoxWord = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxLoc = New System.Windows.Forms.TextBox()
        Me.TextBoxPron = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxRank = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelPrev = New System.Windows.Forms.Label()
        Me.ButtonPrev = New System.Windows.Forms.Button()
        Me.PanelFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonReadFile
        '
        Me.ButtonReadFile.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.ButtonReadFile.Location = New System.Drawing.Point(404, 76)
        Me.ButtonReadFile.Name = "ButtonReadFile"
        Me.ButtonReadFile.Size = New System.Drawing.Size(105, 42)
        Me.ButtonReadFile.TabIndex = 6
        Me.ButtonReadFile.Text = "修改读入文件"
        Me.ButtonReadFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "文本文件|*.txt"
        '
        'LabelFile
        '
        Me.LabelFile.AutoSize = True
        Me.LabelFile.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LabelFile.Location = New System.Drawing.Point(12, 25)
        Me.LabelFile.Name = "LabelFile"
        Me.LabelFile.Size = New System.Drawing.Size(88, 21)
        Me.LabelFile.TabIndex = 10
        Me.LabelFile.Text = "生成字典:  "
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.Filter = "文本文件|*.txt"
        Me.SaveFileDialog1.OverwritePrompt = False
        '
        'ButtonSaveFile
        '
        Me.ButtonSaveFile.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.ButtonSaveFile.Location = New System.Drawing.Point(543, 76)
        Me.ButtonSaveFile.Name = "ButtonSaveFile"
        Me.ButtonSaveFile.Size = New System.Drawing.Size(105, 42)
        Me.ButtonSaveFile.TabIndex = 7
        Me.ButtonSaveFile.Text = "修改输出文件"
        Me.ButtonSaveFile.UseVisualStyleBackColor = True
        '
        'RBFileT
        '
        Me.RBFileT.AutoSize = True
        Me.RBFileT.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RBFileT.Location = New System.Drawing.Point(20, 3)
        Me.RBFileT.Name = "RBFileT"
        Me.RBFileT.Size = New System.Drawing.Size(108, 25)
        Me.RBFileT.TabIndex = 8
        Me.RBFileT.Text = "从文件读入"
        Me.RBFileT.UseVisualStyleBackColor = True
        '
        'RBFileF
        '
        Me.RBFileF.AutoSize = True
        Me.RBFileF.Checked = True
        Me.RBFileF.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.RBFileF.Location = New System.Drawing.Point(159, 3)
        Me.RBFileF.Name = "RBFileF"
        Me.RBFileF.Size = New System.Drawing.Size(92, 25)
        Me.RBFileF.TabIndex = 9
        Me.RBFileF.TabStop = True
        Me.RBFileF.Text = "手动输入"
        Me.RBFileF.UseVisualStyleBackColor = True
        '
        'PanelFile
        '
        Me.PanelFile.Controls.Add(Me.RBFileT)
        Me.PanelFile.Controls.Add(Me.RBFileF)
        Me.PanelFile.Location = New System.Drawing.Point(384, 20)
        Me.PanelFile.Name = "PanelFile"
        Me.PanelFile.Size = New System.Drawing.Size(274, 31)
        Me.PanelFile.TabIndex = 20
        '
        'TextBoxWord
        '
        Me.TextBoxWord.Font = New System.Drawing.Font("楷体", 25.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxWord.Location = New System.Drawing.Point(48, 76)
        Me.TextBoxWord.Name = "TextBoxWord"
        Me.TextBoxWord.Size = New System.Drawing.Size(241, 46)
        Me.TextBoxWord.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "位置"
        '
        'TextBoxLoc
        '
        Me.TextBoxLoc.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.TextBoxLoc.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBoxLoc.Location = New System.Drawing.Point(60, 169)
        Me.TextBoxLoc.Name = "TextBoxLoc"
        Me.TextBoxLoc.ShortcutsEnabled = False
        Me.TextBoxLoc.Size = New System.Drawing.Size(72, 29)
        Me.TextBoxLoc.TabIndex = 1
        '
        'TextBoxPron
        '
        Me.TextBoxPron.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.TextBoxPron.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBoxPron.Location = New System.Drawing.Point(234, 169)
        Me.TextBoxPron.Name = "TextBoxPron"
        Me.TextBoxPron.ShortcutsEnabled = False
        Me.TextBoxPron.Size = New System.Drawing.Size(72, 29)
        Me.TextBoxPron.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(186, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "发音"
        '
        'TextBoxTone
        '
        Me.TextBoxTone.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.TextBoxTone.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBoxTone.Location = New System.Drawing.Point(404, 169)
        Me.TextBoxTone.Name = "TextBoxTone"
        Me.TextBoxTone.ShortcutsEnabled = False
        Me.TextBoxTone.Size = New System.Drawing.Size(72, 29)
        Me.TextBoxTone.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(356, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "声调"
        '
        'TextBoxRank
        '
        Me.TextBoxRank.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.TextBoxRank.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBoxRank.Location = New System.Drawing.Point(576, 169)
        Me.TextBoxRank.Name = "TextBoxRank"
        Me.TextBoxRank.ShortcutsEnabled = False
        Me.TextBoxRank.Size = New System.Drawing.Size(72, 29)
        Me.TextBoxRank.TabIndex = 4
        Me.TextBoxRank.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(528, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "评级"
        '
        'ButtonNext
        '
        Me.ButtonNext.Font = New System.Drawing.Font("微软雅黑", 13.0!)
        Me.ButtonNext.Location = New System.Drawing.Point(485, 230)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(131, 44)
        Me.ButtonNext.TabIndex = 21
        Me.ButtonNext.Text = "下一条"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 21)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "上一条:"
        '
        'LabelPrev
        '
        Me.LabelPrev.AutoSize = True
        Me.LabelPrev.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.LabelPrev.Location = New System.Drawing.Point(80, 242)
        Me.LabelPrev.Name = "LabelPrev"
        Me.LabelPrev.Size = New System.Drawing.Size(0, 21)
        Me.LabelPrev.TabIndex = 23
        '
        'ButtonPrev
        '
        Me.ButtonPrev.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.ButtonPrev.Location = New System.Drawing.Point(332, 240)
        Me.ButtonPrev.Name = "ButtonPrev"
        Me.ButtonPrev.Size = New System.Drawing.Size(76, 31)
        Me.ButtonPrev.TabIndex = 24
        Me.ButtonPrev.Text = "上一条"
        Me.ButtonPrev.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 298)
        Me.Controls.Add(Me.ButtonPrev)
        Me.Controls.Add(Me.LabelPrev)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.TextBoxRank)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxTone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxPron)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxLoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxWord)
        Me.Controls.Add(Me.PanelFile)
        Me.Controls.Add(Me.ButtonSaveFile)
        Me.Controls.Add(Me.LabelFile)
        Me.Controls.Add(Me.ButtonReadFile)
        Me.Name = "FormMain"
        Me.Text = "Dictionary Manager"
        Me.PanelFile.ResumeLayout(False)
        Me.PanelFile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonReadFile As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LabelFile As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ButtonSaveFile As Button
    Friend WithEvents RBFileT As RadioButton
    Friend WithEvents RBFileF As RadioButton
    Friend WithEvents PanelFile As Panel
    Friend WithEvents TextBoxWord As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxLoc As TextBox
    Friend WithEvents TextBoxPron As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxTone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxRank As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonNext As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelPrev As Label
    Friend WithEvents ButtonPrev As Button
End Class
