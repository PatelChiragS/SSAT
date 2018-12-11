'
' Created by SharpDevelop.
' User: Chirag
' Date: 3/12/2016
' Time: 6:05 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Viewer
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Viewer))
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.connectToDBExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.disconnectToDBExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.queryWithCurrentConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.databaseEngineQueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
		Me.mDXQueryAnalysisServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.dMXQyeryAnalysisServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.xLMAQueryAnalysisServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.sQLSerCompactQueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
		Me.projetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.policyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.fIleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.fileWithNewConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.fileDisconnectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
		Me.projectSolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
		Me.policyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.addToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.newProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
		Me.existingProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
		Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.closeSolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
		Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.saveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
		Me.pageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.printToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.printDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.printDialog1 = New System.Windows.Forms.PrintDialog()
		Me.pageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
		Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.toolStripbtnNQuery = New System.Windows.Forms.ToolStripButton()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.toolStripbtnOpen = New System.Windows.Forms.ToolStripButton()
		Me.toolStripbtnSave = New System.Windows.Forms.ToolStripButton()
		Me.toolStripbtnPrint = New System.Windows.Forms.ToolStripButton()
		Me.toolStrip2 = New System.Windows.Forms.ToolStrip()
		Me.cmbservername = New System.Windows.Forms.ToolStripComboBox()
		Me.cmbdbname = New System.Windows.Forms.ToolStripComboBox()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.btnexecute = New System.Windows.Forms.ToolStripButton()
		Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.tabControlEx1 = New SSAT.TabControlEx()
		Me.tabCounter = New System.Windows.Forms.TextBox()
		Me.menuStrip1.SuspendLayout
		Me.toolStrip1.SuspendLayout
		Me.toolStrip2.SuspendLayout
		Me.SuspendLayout
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.helpToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(1596, 24)
		Me.menuStrip1.TabIndex = 0
		Me.menuStrip1.Text = "menuStrip1"
		'
		'fileToolStripMenuItem
		'
		Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.connectToDBExplorerToolStripMenuItem, Me.disconnectToDBExplorerToolStripMenuItem, Me.toolStripSeparator4, Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.toolStripSeparator5, Me.addToolStripMenuItem, Me.toolStripSeparator6, Me.closeToolStripMenuItem, Me.closeSolutionToolStripMenuItem, Me.toolStripSeparator7, Me.saveToolStripMenuItem, Me.toolStripMenuItem1, Me.saveAllToolStripMenuItem, Me.toolStripSeparator8, Me.pageSetupToolStripMenuItem, Me.printToolStripMenuItem, Me.exitToolStripMenuItem})
		Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
		Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.fileToolStripMenuItem.Text = "File"
		'
		'connectToDBExplorerToolStripMenuItem
		'
		Me.connectToDBExplorerToolStripMenuItem.Name = "connectToDBExplorerToolStripMenuItem"
		Me.connectToDBExplorerToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
		Me.connectToDBExplorerToolStripMenuItem.Text = "Connect to DB Explorer"
		AddHandler Me.connectToDBExplorerToolStripMenuItem.Click, AddressOf Me.ConnectToDBExplorerToolStripMenuItemClick
		'
		'disconnectToDBExplorerToolStripMenuItem
		'
		Me.disconnectToDBExplorerToolStripMenuItem.Name = "disconnectToDBExplorerToolStripMenuItem"
		Me.disconnectToDBExplorerToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
		Me.disconnectToDBExplorerToolStripMenuItem.Text = "Disconnect to DB Explorer"
		AddHandler Me.disconnectToDBExplorerToolStripMenuItem.Click, AddressOf Me.DisconnectToDBExplorerToolStripMenuItemClick
		'
		'toolStripSeparator4
		'
		Me.toolStripSeparator4.Name = "toolStripSeparator4"
		Me.toolStripSeparator4.Size = New System.Drawing.Size(207, 6)
		'
		'newToolStripMenuItem
		'
		Me.newToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.queryWithCurrentConnectionToolStripMenuItem, Me.databaseEngineQueryToolStripMenuItem, Me.toolStripSeparator9, Me.mDXQueryAnalysisServicesToolStripMenuItem, Me.dMXQyeryAnalysisServicesToolStripMenuItem, Me.xLMAQueryAnalysisServicesToolStripMenuItem, Me.sQLSerCompactQueryToolStripMenuItem, Me.toolStripSeparator10, Me.projetToolStripMenuItem, Me.policyToolStripMenuItem})
		Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
		Me.newToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
		Me.newToolStripMenuItem.Text = "New"
		'
		'queryWithCurrentConnectionToolStripMenuItem
		'
		Me.queryWithCurrentConnectionToolStripMenuItem.Name = "queryWithCurrentConnectionToolStripMenuItem"
		Me.queryWithCurrentConnectionToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
		Me.queryWithCurrentConnectionToolStripMenuItem.Text = "Query with Current Connection"
		AddHandler Me.queryWithCurrentConnectionToolStripMenuItem.Click, AddressOf Me.QueryWithCurrentConnectionToolStripMenuItemClick
		'
		'databaseEngineQueryToolStripMenuItem
		'
		Me.databaseEngineQueryToolStripMenuItem.Name = "databaseEngineQueryToolStripMenuItem"
		Me.databaseEngineQueryToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
		Me.databaseEngineQueryToolStripMenuItem.Text = "Database Engine Query"
		'
		'toolStripSeparator9
		'
		Me.toolStripSeparator9.Name = "toolStripSeparator9"
		Me.toolStripSeparator9.Size = New System.Drawing.Size(237, 6)
		'
		'mDXQueryAnalysisServicesToolStripMenuItem
		'
		Me.mDXQueryAnalysisServicesToolStripMenuItem.Name = "mDXQueryAnalysisServicesToolStripMenuItem"
		Me.mDXQueryAnalysisServicesToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
		Me.mDXQueryAnalysisServicesToolStripMenuItem.Text = "MDX Query (Analysis Services)"
		AddHandler Me.mDXQueryAnalysisServicesToolStripMenuItem.Click, AddressOf Me.MDXQueryAnalysisServicesToolStripMenuItemClick
		'
		'dMXQyeryAnalysisServicesToolStripMenuItem
		'
		Me.dMXQyeryAnalysisServicesToolStripMenuItem.Name = "dMXQyeryAnalysisServicesToolStripMenuItem"
		Me.dMXQyeryAnalysisServicesToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
		Me.dMXQyeryAnalysisServicesToolStripMenuItem.Text = "DMX Qyery (Analysis Services)"
		'
		'xLMAQueryAnalysisServicesToolStripMenuItem
		'
		Me.xLMAQueryAnalysisServicesToolStripMenuItem.Name = "xLMAQueryAnalysisServicesToolStripMenuItem"
		Me.xLMAQueryAnalysisServicesToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
		Me.xLMAQueryAnalysisServicesToolStripMenuItem.Text = "XLMA Query (Analysis Services)"
		'
		'sQLSerCompactQueryToolStripMenuItem
		'
		Me.sQLSerCompactQueryToolStripMenuItem.Name = "sQLSerCompactQueryToolStripMenuItem"
		Me.sQLSerCompactQueryToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
		Me.sQLSerCompactQueryToolStripMenuItem.Text = "SQL Ser Compact Query"
		'
		'toolStripSeparator10
		'
		Me.toolStripSeparator10.Name = "toolStripSeparator10"
		Me.toolStripSeparator10.Size = New System.Drawing.Size(237, 6)
		'
		'projetToolStripMenuItem
		'
		Me.projetToolStripMenuItem.Name = "projetToolStripMenuItem"
		Me.projetToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
		Me.projetToolStripMenuItem.Text = "Project"
		'
		'policyToolStripMenuItem
		'
		Me.policyToolStripMenuItem.Name = "policyToolStripMenuItem"
		Me.policyToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
		Me.policyToolStripMenuItem.Text = "Policy"
		'
		'openToolStripMenuItem
		'
		Me.openToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fIleToolStripMenuItem1, Me.fileWithNewConnectionToolStripMenuItem, Me.fileDisconnectedToolStripMenuItem, Me.toolStripSeparator11, Me.projectSolutionToolStripMenuItem, Me.toolStripSeparator12, Me.policyToolStripMenuItem1})
		Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
		Me.openToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
		Me.openToolStripMenuItem.Text = "Open"
		'
		'fIleToolStripMenuItem1
		'
		Me.fIleToolStripMenuItem1.Name = "fIleToolStripMenuItem1"
		Me.fIleToolStripMenuItem1.Size = New System.Drawing.Size(208, 22)
		Me.fIleToolStripMenuItem1.Text = "File"
		AddHandler Me.fIleToolStripMenuItem1.Click, AddressOf Me.FIleToolStripMenuItem1Click
		'
		'fileWithNewConnectionToolStripMenuItem
		'
		Me.fileWithNewConnectionToolStripMenuItem.Name = "fileWithNewConnectionToolStripMenuItem"
		Me.fileWithNewConnectionToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
		Me.fileWithNewConnectionToolStripMenuItem.Text = "File with new Connection"
		'
		'fileDisconnectedToolStripMenuItem
		'
		Me.fileDisconnectedToolStripMenuItem.Name = "fileDisconnectedToolStripMenuItem"
		Me.fileDisconnectedToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
		Me.fileDisconnectedToolStripMenuItem.Text = "File Disconnected"
		'
		'toolStripSeparator11
		'
		Me.toolStripSeparator11.Name = "toolStripSeparator11"
		Me.toolStripSeparator11.Size = New System.Drawing.Size(205, 6)
		'
		'projectSolutionToolStripMenuItem
		'
		Me.projectSolutionToolStripMenuItem.Name = "projectSolutionToolStripMenuItem"
		Me.projectSolutionToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
		Me.projectSolutionToolStripMenuItem.Text = "Project / Solution"
		'
		'toolStripSeparator12
		'
		Me.toolStripSeparator12.Name = "toolStripSeparator12"
		Me.toolStripSeparator12.Size = New System.Drawing.Size(205, 6)
		'
		'policyToolStripMenuItem1
		'
		Me.policyToolStripMenuItem1.Name = "policyToolStripMenuItem1"
		Me.policyToolStripMenuItem1.Size = New System.Drawing.Size(208, 22)
		Me.policyToolStripMenuItem1.Text = "Policy"
		'
		'toolStripSeparator5
		'
		Me.toolStripSeparator5.Name = "toolStripSeparator5"
		Me.toolStripSeparator5.Size = New System.Drawing.Size(207, 6)
		'
		'addToolStripMenuItem
		'
		Me.addToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newProjectToolStripMenuItem, Me.toolStripSeparator13, Me.existingProjectToolStripMenuItem})
		Me.addToolStripMenuItem.Name = "addToolStripMenuItem"
		Me.addToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
		Me.addToolStripMenuItem.Text = "Add"
		'
		'newProjectToolStripMenuItem
		'
		Me.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem"
		Me.newProjectToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
		Me.newProjectToolStripMenuItem.Text = "New Project"
		'
		'toolStripSeparator13
		'
		Me.toolStripSeparator13.Name = "toolStripSeparator13"
		Me.toolStripSeparator13.Size = New System.Drawing.Size(151, 6)
		'
		'existingProjectToolStripMenuItem
		'
		Me.existingProjectToolStripMenuItem.Name = "existingProjectToolStripMenuItem"
		Me.existingProjectToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
		Me.existingProjectToolStripMenuItem.Text = "Existing Project"
		'
		'toolStripSeparator6
		'
		Me.toolStripSeparator6.Name = "toolStripSeparator6"
		Me.toolStripSeparator6.Size = New System.Drawing.Size(207, 6)
		'
		'closeToolStripMenuItem
		'
		Me.closeToolStripMenuItem.Name = "closeToolStripMenuItem"
		Me.closeToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
		Me.closeToolStripMenuItem.Text = "Close"
		'
		'closeSolutionToolStripMenuItem
		'
		Me.closeSolutionToolStripMenuItem.Name = "closeSolutionToolStripMenuItem"
		Me.closeSolutionToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
		Me.closeSolutionToolStripMenuItem.Text = "Close Solution"
		'
		'toolStripSeparator7
		'
		Me.toolStripSeparator7.Name = "toolStripSeparator7"
		Me.toolStripSeparator7.Size = New System.Drawing.Size(207, 6)
		'
		'saveToolStripMenuItem
		'
		Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
		Me.saveToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
		Me.saveToolStripMenuItem.Text = "Save"
		AddHandler Me.saveToolStripMenuItem.Click, AddressOf Me.SaveToolStripMenuItemClick
		'
		'toolStripMenuItem1
		'
		Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
		Me.toolStripMenuItem1.Size = New System.Drawing.Size(210, 22)
		Me.toolStripMenuItem1.Text = "Save As"
		AddHandler Me.toolStripMenuItem1.Click, AddressOf Me.ToolStripMenuItem1Click
		'
		'saveAllToolStripMenuItem
		'
		Me.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem"
		Me.saveAllToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
		Me.saveAllToolStripMenuItem.Text = "Save All"
		AddHandler Me.saveAllToolStripMenuItem.Click, AddressOf Me.SaveAllToolStripMenuItemClick
		'
		'toolStripSeparator8
		'
		Me.toolStripSeparator8.Name = "toolStripSeparator8"
		Me.toolStripSeparator8.Size = New System.Drawing.Size(207, 6)
		'
		'pageSetupToolStripMenuItem
		'
		Me.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem"
		Me.pageSetupToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
		Me.pageSetupToolStripMenuItem.Text = "Page Setup"
		'
		'printToolStripMenuItem
		'
		Me.printToolStripMenuItem.Name = "printToolStripMenuItem"
		Me.printToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
		Me.printToolStripMenuItem.Text = "Print"
		'
		'exitToolStripMenuItem
		'
		Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
		Me.exitToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
		Me.exitToolStripMenuItem.Text = "Exit"
		'
		'helpToolStripMenuItem
		'
		Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem})
		Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
		Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.helpToolStripMenuItem.Text = "Help"
		'
		'aboutToolStripMenuItem
		'
		Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
		Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
		Me.aboutToolStripMenuItem.Text = "About"
		'
		'printDialog1
		'
		Me.printDialog1.UseEXDialog = true
		'
		'toolStrip1
		'
		Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripbtnNQuery, Me.toolStripSeparator1, Me.toolStripbtnOpen, Me.toolStripbtnSave, Me.toolStripbtnPrint})
		Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
		Me.toolStrip1.Name = "toolStrip1"
		Me.toolStrip1.Size = New System.Drawing.Size(1596, 25)
		Me.toolStrip1.TabIndex = 1
		Me.toolStrip1.Text = "toolStrip1"
		'
		'toolStripbtnNQuery
		'
		Me.toolStripbtnNQuery.Image = CType(resources.GetObject("toolStripbtnNQuery.Image"),System.Drawing.Image)
		Me.toolStripbtnNQuery.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripbtnNQuery.Name = "toolStripbtnNQuery"
		Me.toolStripbtnNQuery.Size = New System.Drawing.Size(86, 22)
		Me.toolStripbtnNQuery.Text = "New Query"
		AddHandler Me.toolStripbtnNQuery.Click, AddressOf Me.ToolStripbtnNQueryClick
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'toolStripbtnOpen
		'
		Me.toolStripbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.toolStripbtnOpen.Image = CType(resources.GetObject("toolStripbtnOpen.Image"),System.Drawing.Image)
		Me.toolStripbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripbtnOpen.Name = "toolStripbtnOpen"
		Me.toolStripbtnOpen.Size = New System.Drawing.Size(23, 22)
		AddHandler Me.toolStripbtnOpen.Click, AddressOf Me.ToolStripbtnOpenClick
		'
		'toolStripbtnSave
		'
		Me.toolStripbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.toolStripbtnSave.Image = CType(resources.GetObject("toolStripbtnSave.Image"),System.Drawing.Image)
		Me.toolStripbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripbtnSave.Name = "toolStripbtnSave"
		Me.toolStripbtnSave.Size = New System.Drawing.Size(23, 22)
		AddHandler Me.toolStripbtnSave.Click, AddressOf Me.ToolStripbtnSaveClick
		'
		'toolStripbtnPrint
		'
		Me.toolStripbtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.toolStripbtnPrint.Image = CType(resources.GetObject("toolStripbtnPrint.Image"),System.Drawing.Image)
		Me.toolStripbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripbtnPrint.Name = "toolStripbtnPrint"
		Me.toolStripbtnPrint.Size = New System.Drawing.Size(23, 22)
		'
		'toolStrip2
		'
		Me.toolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbservername, Me.cmbdbname, Me.toolStripSeparator2, Me.btnexecute, Me.toolStripSeparator3})
		Me.toolStrip2.Location = New System.Drawing.Point(0, 49)
		Me.toolStrip2.Name = "toolStrip2"
		Me.toolStrip2.Size = New System.Drawing.Size(1596, 25)
		Me.toolStrip2.TabIndex = 2
		Me.toolStrip2.Text = "toolStrip2"
		'
		'cmbservername
		'
		Me.cmbservername.Name = "cmbservername"
		Me.cmbservername.Size = New System.Drawing.Size(121, 25)
		'
		'cmbdbname
		'
		Me.cmbdbname.Name = "cmbdbname"
		Me.cmbdbname.Size = New System.Drawing.Size(121, 25)
		AddHandler Me.cmbdbname.Click, AddressOf Me.CmbdbnameClick
		'
		'toolStripSeparator2
		'
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
		'
		'btnexecute
		'
		Me.btnexecute.Image = CType(resources.GetObject("btnexecute.Image"),System.Drawing.Image)
		Me.btnexecute.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnexecute.Name = "btnexecute"
		Me.btnexecute.Size = New System.Drawing.Size(67, 22)
		Me.btnexecute.Text = "Execute"
		'
		'toolStripSeparator3
		'
		Me.toolStripSeparator3.Name = "toolStripSeparator3"
		Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
		'
		'tabControlEx1
		'
		Me.tabControlEx1.Location = New System.Drawing.Point(46, 77)
		Me.tabControlEx1.Name = "tabControlEx1"
		Me.tabControlEx1.SelectedIndex = 0
		Me.tabControlEx1.Size = New System.Drawing.Size(1550, 794)
		Me.tabControlEx1.TabIndex = 3
		'
		'tabCounter
		'
		Me.tabCounter.Location = New System.Drawing.Point(1568, 4)
		Me.tabCounter.Name = "tabCounter"
		Me.tabCounter.Size = New System.Drawing.Size(16, 20)
		Me.tabCounter.TabIndex = 4
		Me.tabCounter.Visible = false
		'
		'Viewer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1596, 873)
		Me.Controls.Add(Me.tabCounter)
		Me.Controls.Add(Me.tabControlEx1)
		Me.Controls.Add(Me.toolStrip2)
		Me.Controls.Add(Me.toolStrip1)
		Me.Controls.Add(Me.menuStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "Viewer"
		Me.Text = "Viewer"
		AddHandler Load, AddressOf Me.ViewerLoad
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.toolStrip1.ResumeLayout(false)
		Me.toolStrip1.PerformLayout
		Me.toolStrip2.ResumeLayout(false)
		Me.toolStrip2.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private tabCounter As System.Windows.Forms.TextBox
	Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private existingProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
	Private newProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
	Private policyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private projectSolutionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private fileDisconnectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private fileWithNewConnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private fIleToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private policyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private projetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
	Private sQLSerCompactQueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private xLMAQueryAnalysisServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private dMXQyeryAnalysisServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
	Private mDXQueryAnalysisServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private databaseEngineQueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private queryWithCurrentConnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private printToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private pageSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private saveAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private saveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private closeSolutionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private closeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private addToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private disconnectToDBExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private connectToDBExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private tabControlEx1 As SSAT.TabControlEx
	Private toolStripbtnPrint As System.Windows.Forms.ToolStripButton
	Private toolStripbtnSave As System.Windows.Forms.ToolStripButton
	Private toolStripbtnOpen As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Private btnexecute As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Public Withevents cmbdbname As System.Windows.Forms.ToolStripComboBox
	Public Withevents cmbservername As System.Windows.Forms.ToolStripComboBox
	Private toolStrip2 As System.Windows.Forms.ToolStrip
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private toolStripbtnNQuery As System.Windows.Forms.ToolStripButton
	Private toolStrip1 As System.Windows.Forms.ToolStrip
	Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Private pageSetupDialog1 As System.Windows.Forms.PageSetupDialog
	Private printDialog1 As System.Windows.Forms.PrintDialog
	Private printDocument1 As System.Drawing.Printing.PrintDocument
	Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
End Class
