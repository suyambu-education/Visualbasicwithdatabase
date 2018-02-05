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
        Me.usrname = New System.Windows.Forms.TextBox()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.Closebtn = New System.Windows.Forms.Button()
        Me.shhdbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'usrname
        '
        Me.usrname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.usrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrname.Location = New System.Drawing.Point(12, 36)
        Me.usrname.Name = "usrname"
        Me.usrname.Size = New System.Drawing.Size(296, 31)
        Me.usrname.TabIndex = 0
        '
        'PasswordTxt
        '
        Me.PasswordTxt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PasswordTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTxt.Location = New System.Drawing.Point(12, 104)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(43)
        Me.PasswordTxt.Size = New System.Drawing.Size(259, 31)
        Me.PasswordTxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = " User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " Password"
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.Orange
        Me.LoginButton.FlatAppearance.BorderSize = 0
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.Location = New System.Drawing.Point(12, 156)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(98, 35)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "LogIn"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.Orange
        Me.clearBtn.FlatAppearance.BorderSize = 0
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.Color.White
        Me.clearBtn.Location = New System.Drawing.Point(116, 156)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(84, 35)
        Me.clearBtn.TabIndex = 4
        Me.clearBtn.Text = " Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'Closebtn
        '
        Me.Closebtn.BackColor = System.Drawing.Color.Orange
        Me.Closebtn.FlatAppearance.BorderSize = 0
        Me.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Closebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closebtn.ForeColor = System.Drawing.Color.White
        Me.Closebtn.Location = New System.Drawing.Point(206, 156)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(102, 35)
        Me.Closebtn.TabIndex = 3
        Me.Closebtn.Text = "Close"
        Me.Closebtn.UseVisualStyleBackColor = False
        '
        'shhdbtn
        '
        Me.shhdbtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.shhdbtn.BackgroundImage = Global.LoginWithTable.My.Resources.Resources.show_hide_password_12_512
        Me.shhdbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.shhdbtn.FlatAppearance.BorderSize = 0
        Me.shhdbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.shhdbtn.Location = New System.Drawing.Point(269, 105)
        Me.shhdbtn.Name = "shhdbtn"
        Me.shhdbtn.Size = New System.Drawing.Size(41, 29)
        Me.shhdbtn.TabIndex = 8
        Me.shhdbtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(327, 213)
        Me.Controls.Add(Me.shhdbtn)
        Me.Controls.Add(Me.Closebtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.usrname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usrname As TextBox
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents Closebtn As Button
    Friend WithEvents shhdbtn As Button
End Class
