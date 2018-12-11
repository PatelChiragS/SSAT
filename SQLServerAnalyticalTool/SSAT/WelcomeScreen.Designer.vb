'
' Created by SharpDevelop.
' User: Chirag
' Date: 3/12/2016
' Time: 5:46 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.cmbservertype = New System.Windows.Forms.ComboBox()
		Me.cmbservername = New System.Windows.Forms.ComboBox()
		Me.cmbauthentication = New System.Windows.Forms.ComboBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.username = New System.Windows.Forms.TextBox()
		Me.password = New System.Windows.Forms.TextBox()
		Me.btnconnect = New System.Windows.Forms.Button()
		Me.btncancel = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("High Tower Text", 17!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.label1.Location = New System.Drawing.Point(19, 16)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(367, 42)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Connect to SQL Server Access Tool"
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(34, 87)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Server Type:"
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(34, 114)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Server Name:"
		AddHandler Me.label3.Click, AddressOf Me.Label3Click
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(34, 142)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 3
		Me.label4.Text = "Authentication:"
		'
		'cmbservertype
		'
		Me.cmbservertype.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.cmbservertype.FormattingEnabled = true
		Me.cmbservertype.Items.AddRange(New Object() {"Database Engine", "Reporting Services", "Analysis Services", "Integration Services"})
		Me.cmbservertype.Location = New System.Drawing.Point(146, 84)
		Me.cmbservertype.Name = "cmbservertype"
		Me.cmbservertype.Size = New System.Drawing.Size(205, 21)
		Me.cmbservertype.TabIndex = 4
		'
		'cmbservername
		'
		Me.cmbservername.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.cmbservername.FormattingEnabled = true
		Me.cmbservername.Items.AddRange(New Object() {"Chirag-PC", "localhost", "Development", "UAT", "Production"})
		Me.cmbservername.Location = New System.Drawing.Point(146, 111)
		Me.cmbservername.Name = "cmbservername"
		Me.cmbservername.Size = New System.Drawing.Size(205, 21)
		Me.cmbservername.TabIndex = 5
		'
		'cmbauthentication
		'
		Me.cmbauthentication.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.cmbauthentication.FormattingEnabled = true
		Me.cmbauthentication.Items.AddRange(New Object() {"Windows Authentication", "SQL Server Authentication"})
		Me.cmbauthentication.Location = New System.Drawing.Point(146, 139)
		Me.cmbauthentication.Name = "cmbauthentication"
		Me.cmbauthentication.Size = New System.Drawing.Size(205, 21)
		Me.cmbauthentication.TabIndex = 6
		AddHandler Me.cmbauthentication.SelectedIndexChanged, AddressOf Me.CmbauthenticationSelectedIndexChanged
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(68, 179)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(80, 23)
		Me.label5.TabIndex = 7
		Me.label5.Text = "UserName:"
		AddHandler Me.label5.Click, AddressOf Me.Label5Click
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(68, 207)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(80, 23)
		Me.label6.TabIndex = 8
		Me.label6.Text = "Password:"
		'
		'username
		'
		Me.username.Location = New System.Drawing.Point(146, 176)
		Me.username.Name = "username"
		Me.username.Size = New System.Drawing.Size(205, 20)
		Me.username.TabIndex = 9
		'
		'password
		'
		Me.password.Location = New System.Drawing.Point(146, 204)
		Me.password.Name = "password"
		Me.password.Size = New System.Drawing.Size(205, 20)
		Me.password.TabIndex = 10
		'
		'btnconnect
		'
		Me.btnconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnconnect.Location = New System.Drawing.Point(119, 283)
		Me.btnconnect.Name = "btnconnect"
		Me.btnconnect.Size = New System.Drawing.Size(75, 23)
		Me.btnconnect.TabIndex = 11
		Me.btnconnect.Text = "Connect"
		Me.btnconnect.UseVisualStyleBackColor = true
		AddHandler Me.btnconnect.Click, AddressOf Me.BtnconnectClick
		'
		'btncancel
		'
		Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btncancel.Location = New System.Drawing.Point(218, 283)
		Me.btncancel.Name = "btncancel"
		Me.btncancel.Size = New System.Drawing.Size(75, 23)
		Me.btncancel.TabIndex = 12
		Me.btncancel.Text = "Cancel"
		Me.btncancel.UseVisualStyleBackColor = true
		AddHandler Me.btncancel.Click, AddressOf Me.BtncancelClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(403, 330)
		Me.Controls.Add(Me.btncancel)
		Me.Controls.Add(Me.btnconnect)
		Me.Controls.Add(Me.password)
		Me.Controls.Add(Me.username)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.cmbauthentication)
		Me.Controls.Add(Me.cmbservername)
		Me.Controls.Add(Me.cmbservertype)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.MaximizeBox = false
		Me.Name = "MainForm"
		Me.Text = "Connect to Database Engine"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btncancel As System.Windows.Forms.Button
	Private btnconnect As System.Windows.Forms.Button
	Private password As System.Windows.Forms.TextBox
	Private username As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private cmbauthentication As System.Windows.Forms.ComboBox
	Private cmbservername As System.Windows.Forms.ComboBox
	Private cmbservertype As System.Windows.Forms.ComboBox
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
End Class
