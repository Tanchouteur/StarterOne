Imports System.IO


Public Class StarterOne

    Dim volumeDefault As Integer = 30
    Dim url_radio As String = "http://icecast.skyrock.net/s/natio_mp3_128k"

    Private Sub pause_Click(sender As Object, e As EventArgs) Handles pause.Click

        'Lancer la radio
        player.URL = url_radio

        play.Show()
        pause.Hide()
    End Sub

    Private Sub StarterOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On charge et lance la radio d'ès l'ouverture du programme


        If File.Exists(settings) Then

            Dim lines() = File.ReadAllLines(settings)

            volumeDefault = lines(0)

            If lines(1) = 1 Then
                player.URL = url_radio
                pause.Hide()
                play.Show()
            Else
                pause.Show()
                play.Hide()
            End If

        Else
            player.URL = url_radio
        End If

        player.settings.volume = volumeDefault

        bar.Value = volumeDefault

    End Sub

    Private Sub play_Click(sender As Object, e As EventArgs) Handles play.Click

        'Arreter la radio
        player.Ctlcontrols.stop()

        pause.Show()
        play.Hide()
    End Sub

    Private Sub bar_Scroll(sender As Object, e As EventArgs) Handles bar.Scroll
        Dim volume As Integer = bar.Value

        player.settings.volume = volume
        'volVal = bar.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        options.ShowDialog()
    End Sub
End Class
