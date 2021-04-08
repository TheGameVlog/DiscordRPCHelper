# DiscordRPCHelper
Simple and Easy to setup Discord RPC based on discord-rpc-csharp


# Easy to Use
'set the app id
DiscordEasyRPC.Discord_App_ID = txtDiscordAppID.Text
DiscordEasyRPC.SetArtAssets(txtLargeImgKey.Text, txtSmallImageKey.Text, txtSmallImageToolTip.Text, txtLargeImgTooltip.Text)
'dont forget to create client
DiscordEasyRPC.CreateClient()
'then start the client
DiscordEasyRPC.StartClient("Test")

# Add Button Support
DiscordEasyRPC.AddActionButton(label, url)

# Includes Example Solution

# Credits and Dependencies 
https://github.com/Lachee/discord-rpc-csharp
