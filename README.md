# DiscordRPCHelper
Simple and Easy to setup Discord RPC based on discord-rpc-csharp

# Why this when we have Lachee's RPC?
This isnt a fork / replacement for Lachee's infact this uses Lachee's amazing csharp wrapper, DiscordRPCHelper is only usefull when you just want to implement the Rich Presense quickly in your app.

# Easy to Use
```Visual Basic

DiscordEasyRPC.Discord_App_ID = txtDiscordAppID.Text

DiscordEasyRPC.SetArtAssets(txtLargeImgKey.Text, txtSmallImageKey.Text, txtSmallImageToolTip.Text, txtLargeImgTooltip.Text)

DiscordEasyRPC.CreateClient()

DiscordEasyRPC.StartClient("Test")

```
# Add Button Support
```Visual Basic
DiscordEasyRPC.AddActionButton(label, url)
```
# Includes Example Solution

# Credits and Dependencies 
https://github.com/Lachee/discord-rpc-csharp
