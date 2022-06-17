Imports System.ComponentModel
Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readDir()
        result.Text = "[" & TimeString & "] 软件启动完成"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then
            MessageBox.Show("失败：用户取消了操作！")
        Else
            filepath = OpenFileDialog1.FileName
            TextBox2.Text = filepath
            file_name = Path.GetFileName(filepath)
        End If
    End Sub

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        If mode.SelectedItem = "" Or format.SelectedItem = "" Or modules.SelectedItem = "" Then
            MessageBox.Show("请检查是否已经全部配置！！！")
        End If
        If Not My.Computer.FileSystem.FileExists(filepath) Then
            MessageBox.Show("失败：文件不存在！")
            Exit Sub
        End If
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\main\main.exe") Or Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\main\ffmpeg.exe") Then
            MessageBox.Show("失败：核心文件不存在！", "警告", vbOK, icon:=vbObjectError)
            Exit Sub
        End If
        result.Text = result.Text & "[" & TimeString & "] " & "开始执行"
        If mode.SelectedItem = "视频" Then
            mkvideo()
        Else
            mkimg()
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("dxdiag")
    End Sub

    Private Sub mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mode.SelectedIndexChanged
        If mode.SelectedItem.ToString = "视频" Then
            OpenFileDialog1.Filter = "MP4视频文件|*.mp4"
            format.SelectedItem = "jpg"
            format.Enabled = False
            modules.SelectedItem = "realesr-animevideov3-x3"
        Else
            OpenFileDialog1.Filter = "png文件|*.png|jpg文件|*.jpg"
            format.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("explorer " & Application.StartupPath & "output")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("explorer " & Application.StartupPath & "video_output")

    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("确认关闭？", vbYesNo, "提示") = vbNo Then
            e.Cancel = True
        Else
            delTmpFile()
            Me.Dispose()
        End If
    End Sub

    Private Sub 联系作者LToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 联系作者LToolStripMenuItem.Click
        Shell("explorer http://wpa.qq.com/msgrd?v=3&uin=3414769627&site=qq&menu=yes")
    End Sub

    Private Sub 访问软件主页FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 访问软件主页FToolStripMenuItem.Click
        Shell("explorer https://www.linxi.info/2022/06/17/%e5%9b%be%e7%89%87-%e8%a7%86%e9%a2%91%e7%94%bb%e8%b4%a8%e5%a2%9e%e5%bc%ba/")
    End Sub

    Private Sub 访问作者哔哩哔哩主页BToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 访问作者哔哩哔哩主页BToolStripMenuItem.Click
        Shell("explorer https://space.bilibili.com/494988458")
    End Sub

    Private Sub 检查更新ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 检查更新ToolStripMenuItem.Click
        Dim ver = "10001"
        Dim net = curl("https://update.linxi.info/update/check.php", "ver=" & ver)
        If net = "NO_UPDATE" Then
            MessageBox.Show("软件是最新版本！")
        Else
            MessageBox.Show(net)
            If MessageBox.Show("发现新版本，是否前往下载？", "提示", vbYesNo, icon:=vbInformation) = vbYes Then

                Shell("explorer " & net)
            End If
        End If
    End Sub

    Private Sub stop0_Click(sender As Object, e As EventArgs) Handles stop0.Click
        Shell("explorer https://space.bilibili.com/494988458")
    End Sub

    Private Sub 退出EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出EToolStripMenuItem.Click
        End
    End Sub
End Class
