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
        Me.components = New System.ComponentModel.Container()
        Me.txtUserLog = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtPassLog = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblSignup = New System.Windows.Forms.Label()
        Me.lblAdminLog = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUserLog
        '
        Me.txtUserLog.Location = New System.Drawing.Point(178, 86)
        Me.txtUserLog.Name = "txtUserLog"
        Me.txtUserLog.Size = New System.Drawing.Size(193, 20)
        Me.txtUserLog.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'txtPassLog
        '
        Me.txtPassLog.Location = New System.Drawing.Point(178, 142)
        Me.txtPassLog.Name = "txtPassLog"
        Me.txtPassLog.Size = New System.Drawing.Size(193, 20)
        Me.txtPassLog.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(216, 207)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(133, 58)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblSignup
        '
        Me.lblSignup.AutoSize = True
        Me.lblSignup.Location = New System.Drawing.Point(225, 331)
        Me.lblSignup.Name = "lblSignup"
        Me.lblSignup.Size = New System.Drawing.Size(43, 13)
        Me.lblSignup.TabIndex = 7
        Me.lblSignup.Text = "Sign up"
        '
        'lblAdminLog
        '
        Me.lblAdminLog.AutoSize = True
        Me.lblAdminLog.Location = New System.Drawing.Point(296, 331)
        Me.lblAdminLog.Name = "lblAdminLog"
        Me.lblAdminLog.Size = New System.Drawing.Size(36, 13)
        Me.lblAdminLog.TabIndex = 8
        Me.lblAdminLog.Text = "Admin"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 454)
        Me.Controls.Add(Me.lblAdminLog)
        Me.Controls.Add(Me.lblSignup)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassLog)
        Me.Controls.Add(Me.txtUserLog)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUserLog As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents txtPassLog As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblSignup As Label
    Friend WithEvents lblAdminLog As Label
End Class
