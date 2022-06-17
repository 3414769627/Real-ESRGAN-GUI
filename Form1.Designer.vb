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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.联系作者LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.访问软件主页FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.访问作者哔哩哔哩主页BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.检查更新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.modules = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.format = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.result = New System.Windows.Forms.TextBox()
        Me.start = New System.Windows.Forms.Button()
        Me.stop0 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件FToolStripMenuItem, Me.关于AToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(835, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件FToolStripMenuItem
        '
        Me.文件FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.退出EToolStripMenuItem})
        Me.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem"
        Me.文件FToolStripMenuItem.Size = New System.Drawing.Size(58, 21)
        Me.文件FToolStripMenuItem.Text = "文件(&F)"
        '
        '退出EToolStripMenuItem
        '
        Me.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem"
        Me.退出EToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.退出EToolStripMenuItem.Text = "退出(&E)"
        '
        '关于AToolStripMenuItem
        '
        Me.关于AToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.联系作者LToolStripMenuItem, Me.访问软件主页FToolStripMenuItem, Me.访问作者哔哩哔哩主页BToolStripMenuItem, Me.检查更新ToolStripMenuItem})
        Me.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem"
        Me.关于AToolStripMenuItem.Size = New System.Drawing.Size(60, 21)
        Me.关于AToolStripMenuItem.Text = "关于(&A)"
        '
        '联系作者LToolStripMenuItem
        '
        Me.联系作者LToolStripMenuItem.Name = "联系作者LToolStripMenuItem"
        Me.联系作者LToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.联系作者LToolStripMenuItem.Text = "联系作者(&L)"
        '
        '访问软件主页FToolStripMenuItem
        '
        Me.访问软件主页FToolStripMenuItem.Name = "访问软件主页FToolStripMenuItem"
        Me.访问软件主页FToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.访问软件主页FToolStripMenuItem.Text = "访问软件主页(&A)"
        '
        '访问作者哔哩哔哩主页BToolStripMenuItem
        '
        Me.访问作者哔哩哔哩主页BToolStripMenuItem.Name = "访问作者哔哩哔哩主页BToolStripMenuItem"
        Me.访问作者哔哩哔哩主页BToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.访问作者哔哩哔哩主页BToolStripMenuItem.Text = "访问作者哔哩哔哩主页(&B)"
        '
        '检查更新ToolStripMenuItem
        '
        Me.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem"
        Me.检查更新ToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.检查更新ToolStripMenuItem.Text = "检查更新(&C)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.modules)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.format)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.mode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(586, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 315)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "程序配置"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 258)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(229, 36)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "打开视频输出文件夹(&P)"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 216)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(229, 36)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "打开图片输出文件夹(&O)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 87)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(229, 30)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "查看计算机信息(&D)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(229, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "选择文件(&S)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'modules
        '
        Me.modules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.modules.FormattingEnabled = True
        Me.modules.Location = New System.Drawing.Point(56, 185)
        Me.modules.Name = "modules"
        Me.modules.Size = New System.Drawing.Size(179, 25)
        Me.modules.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(6, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "模型："
        '
        'format
        '
        Me.format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.format.FormattingEnabled = True
        Me.format.Items.AddRange(New Object() {"png", "jpg", "webp"})
        Me.format.Location = New System.Drawing.Point(56, 154)
        Me.format.Name = "format"
        Me.format.Size = New System.Drawing.Size(179, 25)
        Me.format.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(6, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "格式："
        '
        'mode
        '
        Me.mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mode.FormattingEnabled = True
        Me.mode.Items.AddRange(New Object() {"图片", "视频"})
        Me.mode.Location = New System.Drawing.Point(56, 123)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(179, 25)
        Me.mode.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(6, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "模式："
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 22)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(229, 23)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "未选择输入文件"
        '
        'result
        '
        Me.result.Location = New System.Drawing.Point(12, 27)
        Me.result.Multiline = True
        Me.result.Name = "result"
        Me.result.ReadOnly = True
        Me.result.Size = New System.Drawing.Size(568, 411)
        Me.result.TabIndex = 1
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(586, 348)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(235, 42)
        Me.start.TabIndex = 2
        Me.start.Text = "开始(&T)"
        Me.start.UseVisualStyleBackColor = True
        '
        'stop0
        '
        Me.stop0.Location = New System.Drawing.Point(586, 396)
        Me.stop0.Name = "stop0"
        Me.stop0.Size = New System.Drawing.Size(235, 42)
        Me.stop0.TabIndex = 2
        Me.stop0.Text = "给我一个三连嘛~ QAQ(&Q)"
        Me.stop0.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "png文件|*.png|jpg文件|*.jpg"
        Me.OpenFileDialog1.Title = "打开"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.CheckFileExists = False
        Me.OpenFileDialog2.Title = "选择文件夹"
        Me.OpenFileDialog2.ValidateNames = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 450)
        Me.Controls.Add(Me.stop0)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "视频/图片画质增强工具"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mode As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents result As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents modules As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents format As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents start As Button
    Friend WithEvents stop0 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents 文件FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 联系作者LToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 访问软件主页FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 访问作者哔哩哔哩主页BToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 检查更新ToolStripMenuItem As ToolStripMenuItem
End Class
