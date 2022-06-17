Imports System
Imports System.IO
Imports System.Text
Module Module1
    Public filepath As String
    Public dir_path As String
    Public file_name As String
    Public Function readDir()
        Try
            Dim num As Integer
            Dim filename() As String
            Dim result() As String
            ' Only get files that begin with the letter "c."
            Dim dirs As String() = Directory.GetFiles(Application.StartupPath.ToString & "\main\models\", "*.param") '列出C:\下c开头的文件，你需要稍微修改，你的路径，列出所有文件是*.*
            Console.WriteLine("The number of files starting with c is {0}.", dirs.Length)
            Dim dir As String
            For Each dir In dirs
                'path(num) = dir
                'Form1.modules.Items.Add(dir)
                Form1.modules.Items.Add(Path.GetFileNameWithoutExtension(dir))

            Next
        Catch e As Exception
            Console.WriteLine("The process failed: {0}", e.ToString())
        End Try

    End Function
    Public Sub mkimg()
        Try
            Dim cmd As New Process
            cmd.StartInfo.FileName = Application.StartupPath & "\main\main.exe"
            cmd.StartInfo.UseShellExecute = False
            cmd.StartInfo.RedirectStandardInput = True
            cmd.StartInfo.RedirectStandardOutput = True
            cmd.StartInfo.CreateNoWindow = True
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            cmd.StartInfo.Arguments = " -i " & filepath & " -o output\" & file_name & "_ok." & Form1.format.SelectedItem.ToString & " -f " & Form1.format.SelectedItem.ToString & " -n " & Form1.modules.SelectedItem.ToString
            cmd.Start()
            Form1.result.Text = Form1.result.Text & vbCrLf & "[" & TimeString & "] " & "进程ID：" & cmd.Id & "已退出"
            If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\output\" & file_name & "_ok." & Form1.format.SelectedItem.ToString) Then
                Form1.result.Text = Form1.result.Text & vbCrLf & "[" & TimeString & "] " & "程序执行失败，请检查此计算机是否支持DirectX 11.1或以上版本和Vulkan Runtime"
            End If
            cmd.StandardInput.Close()
            Form1.result.Text = Form1.result.Text & vbCrLf & cmd.StandardOutput.ReadToEnd()
            cmd.WaitForExit()
            cmd.Close()
        Catch ex As Exception
            Form1.result.Text = Form1.result.Text & vbCrLf & ex.Message
            Form1.result.Text = Form1.result.Text & vbCrLf & "软件出现错误，请截图此区域发送给程序作者！QQ:3414769627,请注明来意！"
            delTmpFile()
        End Try

    End Sub
    Public Sub mkvideo()
        Try
            Dim cmd As New Process
            cmd.StartInfo.FileName = Application.StartupPath & "\main\ffmpeg.exe"
            cmd.StartInfo.UseShellExecute = False
            cmd.StartInfo.RedirectStandardInput = True
            cmd.StartInfo.RedirectStandardOutput = True
            cmd.StartInfo.CreateNoWindow = True
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            cmd.StartInfo.Arguments = " -i " & filepath & " -qscale:v 1 -qmin 1 -qmax 1 -vsync 0 main/tmp_frames/frame%08d.jpg"
            cmd.Start()
            Form1.result.Text = Form1.result.Text & vbCrLf & "[" & TimeString & "] " & "进程ID：" & cmd.Id & "已退出,视频分割完成，等待进行推断"
            cmd.StandardInput.Close()
            Form1.result.Text = Form1.result.Text & vbCrLf & cmd.StandardOutput.ReadToEnd()
            cmd.WaitForExit()
            cmd.Close()
            cmd.StartInfo.FileName = Application.StartupPath & "\main\main.exe"
            cmd.StartInfo.UseShellExecute = False
            cmd.StartInfo.RedirectStandardInput = True
            cmd.StartInfo.RedirectStandardOutput = True
            cmd.StartInfo.CreateNoWindow = True
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            cmd.StartInfo.Arguments = " -i main\tmp_frames -o main\out_frames -n realesr-animevideov3 -s 2 -f jpg"
            cmd.Start()
            Form1.result.Text = Form1.result.Text & vbCrLf & "[" & TimeString & "] " & "进程ID：" & cmd.Id & "已退出,等待视频进行合成"
            cmd.StandardInput.Close()
            Form1.result.Text = Form1.result.Text & vbCrLf & cmd.StandardOutput.ReadToEnd()
            cmd.WaitForExit()
            cmd.Close()
            cmd.StartInfo.FileName = Application.StartupPath & "\main\ffmpeg.exe"
            cmd.StartInfo.UseShellExecute = False
            cmd.StartInfo.RedirectStandardInput = True
            cmd.StartInfo.RedirectStandardOutput = True
            cmd.StartInfo.CreateNoWindow = True
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            Dim name As String = DateTime.Now.Ticks
            name = "output_" & name & "_audio.mp4"
            cmd.StartInfo.Arguments = " -i  main/out_frames/frame%08d.jpg -i " & filepath & " -map 0:v:0 -map 1:a:0 -c:a copy -c:v libx264 -r 23.98 -pix_fmt yuv420p video_output/" & name
            cmd.Start()
            Form1.result.Text = Form1.result.Text & vbCrLf & "[" & TimeString & "] " & "进程ID：" & cmd.Id & "已退出"
            If Not My.Computer.FileSystem.FileExists(Application.StartupPath & name) Then
                Form1.result.Text = Form1.result.Text & vbCrLf & "[" & TimeString & "] " & "filename:" & name
                Form1.result.Text = Form1.result.Text & vbCrLf & "[" & TimeString & "] 任务全部完成，请检查输出文件夹。"
            Else
                Form1.result.Text = Form1.result.Text & vbCrLf & "[" & TimeString & "] 任务失败，请检查是否有权限写入！"
            End If
            cmd.StandardInput.Close()
            Form1.result.Text = Form1.result.Text & vbCrLf & cmd.StandardOutput.ReadToEnd()
            cmd.WaitForExit()
            cmd.Close()

        Catch ex As Exception
            Form1.result.Text = Form1.result.Text & vbCrLf & ex.Message
            Form1.result.Text = Form1.result.Text & vbCrLf & "软件出现错误，请截图此区域发送给程序作者！QQ:3414769627,请注明来意！"
            delTmpFile()
        End Try
    End Sub

    Public Sub delTmpFile()
        Try
            Form1.result.Text = Form1.result.Text & vbCrLf & "正在清理临时文件..."
            Shell("del /q " & Application.StartupPath & "main/out_frames/*")
            Shell("del /q " & Application.StartupPath & "main/tmp_frames/*")
        Catch ex As Exception

        End Try

    End Sub
    Public Function curl(URL As String, parameter As String) As String
        Dim result As String = ""
        Try
            Dim i As Integer = Int(Rnd(Now.Second) * 10 + 1)
            Dim web As New System.Net.WebClient()
            web.Headers.Add("Content-Type", "application/x-www-form-urlencoded")
            Dim data As Byte() = System.Text.Encoding.UTF8.GetBytes(parameter)
            Dim res As Byte() = web.UploadData(URL, "POST", data)
            result = Encoding.UTF8.GetString(res)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function
End Module
