Imports System.Reflection
Imports DiscordRPC
Imports DiscordRPC.Logging

Public Class DiscordEasyRPC
    Public Shared Property Discord_App_ID As String
    Public Shared ReadOnly Property TimeLapsed As Timestamps = New Timestamps(Date.UtcNow)
    Public Shared Property RichPresenceArtAssets As Assets
    Public Shared Property ActionButtons As New List(Of Button)
    Public Shared Property DiscordClient As DiscordRpcClient
    Private Shared discord_status As RichPresence
    Shared rcP As New RichPresence()

    Public Shared Sub CreateClient()
        DiscordClient = New DiscordRpcClient(Discord_App_ID)
    End Sub

    Public Shared Sub StartClient(InitialState As String)
        rcP.Assets = RichPresenceArtAssets
        rcP.Timestamps = TimeLapsed
        rcP.State = InitialState
        rcP.Buttons = ActionButtons.ToArray()
        DiscordClient.SetPresence(rcP)
        Initialize()
        SaveCurrentPresence()
    End Sub

    Public Shared Sub Update(ByVal Optional detail As String = Nothing, ByVal Optional state As String = Nothing)
        If Not IsNothing(state) Then
            rcP.State = state
        End If
        If Not IsNothing(detail) Then
            rcP.Details = detail
        End If
        DiscordClient.SetPresence(rcP)
        DiscordClient.Invoke()
        SaveCurrentPresence()
    End Sub




    Private Shared Sub SaveCurrentPresence()
        discord_status = DiscordClient.CurrentPresence
    End Sub

    Public Shared Function SetArtAssets(LargeImageKey As String, SmallImageKey As String, SmallImageToolTip As String, LargeImageToolTip As String) As Boolean
        Try
            Dim tempAsset As New Assets()
            tempAsset.LargeImageKey = LargeImageKey
            tempAsset.LargeImageText = LargeImageToolTip
            tempAsset.SmallImageKey = SmallImageKey
            tempAsset.SmallImageText = SmallImageToolTip
            RichPresenceArtAssets = tempAsset
            'if no errors return true

            Return True
        Catch ex As Exception
            'if errors return false
            Throw ex
        End Try
    End Function

    Public Shared Sub Dispose()
        Try
            DiscordClient.Dispose()
        Catch ex As Exception

        End Try

    End Sub

    Public Shared Sub DeInitialize()
        Try
            DiscordClient.Deinitialize()
        Catch ex As Exception

        End Try
    End Sub

    Private Shared Sub Initialize()
        Try
            DiscordClient.Initialize()
        Catch ex As Exception

        End Try


    End Sub

#Region "Button Functions and Properties"
    Public Shared ReadOnly Property CanAddButtons As Boolean
        Get
            If ActionButtons.Count < 2 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public Shared Function AddActionButton(Label As String, URL As String) As Boolean
        If ActionButtons.Count < 2 Then
            ActionButtons.Add(New Button() With {.Label = Label, .Url = URL})

            Return True
        Else
            Throw New Exception("You can add a maximum of only two buttons to the Discord Presence")
        End If
    End Function
#End Region

End Class