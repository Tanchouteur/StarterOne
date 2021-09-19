Imports System.IO

Public Class options

    Dim volume As Integer = 0
    Dim start As Integer = 1
    Dim lecture As Integer = 1

    Private Sub startVol_Scroll(sender As Object, e As EventArgs) Handles startVol.Scroll

    End Sub

    Private Sub start_win_CheckedChanged(sender As Object, e As EventArgs) Handles start_win.CheckedChanged

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Directory.Exists(repertoire) = False Then
            Directory.CreateDirectory(repertoire)
        End If
        volume = startVol.Value
        If start_radio.Checked = True Then
            lecture = 1
        Else
            lecture = 0
        End If
        If start_win.Checked = True Then
            start = 1
        Else
            start = 0
        End If

        Dim Registry As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser
        Dim key As Microsoft.Win32.RegistryKey = Registry.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)


        If start = 1 Then
            key.SetValue(Application.ProductName, Application.ExecutablePath, Microsoft.Win32.RegistryValueKind.String)
        Else
            key.DeleteValue(Application.ProductName)
        End If

        Dim sw As New StreamWriter(settings)
        sw.WriteLine(volume)
        sw.WriteLine(lecture)
        sw.WriteLine(start)
        sw.Close()

        Me.Close()
    End Sub

    Private Sub start_radio_CheckedChanged(sender As Object, e As EventArgs) Handles start_radio.CheckedChanged



    End Sub

    Private Sub options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lines() As String = File.ReadAllLines(settings)

        startVol.Value = lines(0)

        If lines(1) = 1 Then
            start_radio.Checked = True
        Else
            start_radio.Checked = False
        End If
        If lines(2) = 1 Then
            start_win.Checked = True
        Else
            start_win.Checked = False
        End If
    End Sub
End Class