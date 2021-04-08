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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiscordAppID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUpdate = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.discButtonPanel = New System.Windows.Forms.GroupBox()
        Me.txtButtons = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSmallImageToolTip = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSmallImageKey = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLargeImgTooltip = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLargeImgKey = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.discButtonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Discord App ID"
        '
        'txtDiscordAppID
        '
        Me.txtDiscordAppID.Location = New System.Drawing.Point(146, 28)
        Me.txtDiscordAppID.Name = "txtDiscordAppID"
        Me.txtDiscordAppID.Size = New System.Drawing.Size(244, 20)
        Me.txtDiscordAppID.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUpdate)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.discButtonPanel)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtSmallImageToolTip)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSmallImageKey)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtLargeImgTooltip)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLargeImgKey)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDiscordAppID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 453)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discord Helper Settings"
        '
        'txtUpdate
        '
        Me.txtUpdate.Location = New System.Drawing.Point(85, 395)
        Me.txtUpdate.Name = "txtUpdate"
        Me.txtUpdate.Size = New System.Drawing.Size(244, 20)
        Me.txtUpdate.TabIndex = 14
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(110, 421)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(193, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(290, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Add Button"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'discButtonPanel
        '
        Me.discButtonPanel.Controls.Add(Me.txtButtons)
        Me.discButtonPanel.Location = New System.Drawing.Point(23, 213)
        Me.discButtonPanel.Name = "discButtonPanel"
        Me.discButtonPanel.Size = New System.Drawing.Size(367, 147)
        Me.discButtonPanel.TabIndex = 11
        Me.discButtonPanel.TabStop = False
        Me.discButtonPanel.Text = "Discord Buttons"
        '
        'txtButtons
        '
        Me.txtButtons.BackColor = System.Drawing.Color.White
        Me.txtButtons.Location = New System.Drawing.Point(10, 18)
        Me.txtButtons.Multiline = True
        Me.txtButtons.Name = "txtButtons"
        Me.txtButtons.ReadOnly = True
        Me.txtButtons.Size = New System.Drawing.Size(346, 123)
        Me.txtButtons.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(106, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Initialize Discord Presence"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSmallImageToolTip
        '
        Me.txtSmallImageToolTip.Location = New System.Drawing.Point(146, 146)
        Me.txtSmallImageToolTip.Name = "txtSmallImageToolTip"
        Me.txtSmallImageToolTip.Size = New System.Drawing.Size(244, 20)
        Me.txtSmallImageToolTip.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Small Image Tooltip"
        '
        'txtSmallImageKey
        '
        Me.txtSmallImageKey.Location = New System.Drawing.Point(146, 116)
        Me.txtSmallImageKey.Name = "txtSmallImageKey"
        Me.txtSmallImageKey.Size = New System.Drawing.Size(244, 20)
        Me.txtSmallImageKey.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Small Image Key"
        '
        'txtLargeImgTooltip
        '
        Me.txtLargeImgTooltip.Location = New System.Drawing.Point(146, 88)
        Me.txtLargeImgTooltip.Name = "txtLargeImgTooltip"
        Me.txtLargeImgTooltip.Size = New System.Drawing.Size(244, 20)
        Me.txtLargeImgTooltip.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Large Image Tooltip"
        '
        'txtLargeImgKey
        '
        Me.txtLargeImgKey.Location = New System.Drawing.Point(146, 58)
        Me.txtLargeImgKey.Name = "txtLargeImgKey"
        Me.txtLargeImgKey.Size = New System.Drawing.Size(244, 20)
        Me.txtLargeImgKey.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Large Image Key"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "DiscordRPC Helper Tester"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.discButtonPanel.ResumeLayout(False)
        Me.discButtonPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDiscordAppID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtLargeImgTooltip As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLargeImgKey As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSmallImageToolTip As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSmallImageKey As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents discButtonPanel As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txtButtons As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents txtUpdate As TextBox
End Class
