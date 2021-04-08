Imports DiscordRPCVB
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class Form1


    'RegEx to check valid urls
    Dim pattern As String = "http(s)?://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'check if u can add more buttons
        If DiscordEasyRPC.CanAddButtons Then
            Dim label As String = InputBox("Enter Button Label : ")
            Dim url As String = InputBox("Enter URL : ")
            If Regex.IsMatch(url, pattern) Then
                'simple and easy way to add a button to ur discord rpc
                DiscordEasyRPC.AddActionButton(label, url)
                txtButtons.AppendText("===============" & vbCrLf & "Button Label : " & label & vbCrLf & "Button URL : " & url & vbCrLf)
            Else
                MsgBox("Not a Proper URL Try Again")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'set the app id
        DiscordEasyRPC.Discord_App_ID = txtDiscordAppID.Text

        DiscordEasyRPC.SetArtAssets(txtLargeImgKey.Text, txtSmallImageKey.Text, txtSmallImageToolTip.Text, txtLargeImgTooltip.Text)

        'dont forget to create client
        DiscordEasyRPC.CreateClient()
        'then start the client
        DiscordEasyRPC.StartClient("Test")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'update client
        DiscordEasyRPC.Update(txtUpdate.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        DiscordEasyRPC.DeInitialize()
        DiscordEasyRPC.Dispose()
    End Sub
End Class
