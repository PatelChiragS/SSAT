Option Strict On
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient 
Imports System.IO
Imports System.IO.Ports 
Imports System.ComponentModel


Public Partial Class Viewer
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
	End Sub
	
	'Public declaration of variables
	Public Class GlobalVariables
		Public Shared UserName As String = "Chirag Patel"
		Public Shared UserId As Integer = 12
		Public Shared Txtbox As New RichTextBox 
		Public Shared Tabcount As Int32
		Public Shared dgv As DataGridView 
		Public Shared tabpagetext As String 
		Public Shared ResultTxtbox As New TextBox
		Public Shared cntrow As Integer 
		Public Shared testsqlstr As String
		Public Shared psbar As New StatusBar()
	End Class
	
	
	Sub CreateQueryArea()
		
		Dim DbN As String 
		If cmbdbname.Text = String.Empty Then 
			DbN = "master"
		Else 
			DbN = cmbdbname.Text 
		End If
		
		
		TabControlEx1.Size = New Size(1640,873)
		
		Dim tx As New RichTextBox()
		Dim rtx As New TextBox()
		Dim tabpage As New TabPage
		Dim dg As New DataGridView 
		Dim resulttabpage As New TabPage 
		Dim messagestabpage As New TabPage 
		Dim rnmdg As New DataGridView 
		Dim rnmtx As New TextBox()
		Dim sbar As New StatusBar()
		Dim sbarpanel1 As New StatusBarPanel()
		
' Increments tabs by one always -- DO NOT REMOVE THE TEXT BOX tabCounter FROM THE FORM)
		tabCounter.Text = (Val(tabCounter.Text) + 1).ToString()
		
		Me.tabControlEx1.SizeMode = TabSizeMode.Fixed
		Me.tabControlEx1.ShowToolTips = True 
		tabpage.Text = "SQLQuery" & tabCounter.Text & ".sql" & " - " & cmbdbname.Text
		tabpage.ToolTipText = "SQLQuery" & tabCounter.Text & ".sql" & " - " & cmbdbname.Text
		
' Creates Query Pan
			
		tx.AutoSize = True
		tx.Multiline = True 
		tx.WordWrap = False ' False: Enables Horizontal Scrollbar
		tx.Parent = tabpage
		tx.Location = New Point(0)
		tx.Size = New Size(1633,150)
		tx.Name = "Txtbox" & tabCounter.Text 
		tx.Visible = True 
		
' Creates Datagridview for each tabpage
		
		dg.Parent = tabpage 
		dg.VirtualMode = True
		dg.Location = New Point(0,150)
		dg.Size = New Size(1633,590)
		dg.Name = "DGView" & tabCounter.Text 
		dg.ReadOnly = True 
		dg.Visible = True
		dg.AllowUserToAddRows = False  	'False: Removes last empty Row
		
		'dg.RowHeadersVisible = False 	'False: hide the left most column of datagridview
		'dg.BackgroundColor = Color.LightGray
		
' Creates Result pan for each tab page
		
		rtx.Multiline = True 
		rtx.WordWrap = False 
		rtx.Parent = tabpage 
		rtx.Location = New Point(0,740)
		rtx.Size = New Size(1633,85)
		rtx.Name = "Txtbox" & tabCounter.Text 
		rtx.Visible = True 
		rtx.ReadOnly = True 
		rtx.BackColor = Color.White 
		rtx.BorderStyle = BorderStyle.None 
		
'Creates Status bar for each tab page
		
		sbarpanel1.BorderStyle = StatusBarPanelBorderStyle.Sunken
		sbar.Parent = tabpage
		sbar.Location = New Point(0,826)
		sbar.Size = New Size(1633,25)
		sbar.Visible = True
		sbar.BackColor = Color.Yellow
		sbar.Panels.Add(sbarpanel1)
		
		
		tabControlEx1.TabPages.Add(tabpage)
		
' Selects tabpage as an active tab on tab control using selected tab
		Me.tabControlEx1.SelectedTab = tabpage
'Assign value of created text box to global declared variable
		GlobalVariables.Txtbox = tx
'Assign created datagrid view from local to global
		GlobalVariables.dgv = dg
'Assign tabpage.text from local to global
		GlobalVariables.tabpagetext = tabpage.Text 
'Assign value of Result textbox to global declared variable
		GlobalVariables.ResultTxtbox = rtx
		
		
		cmbdbname.Enabled = True
		
		
	End Sub
	
	
	Sub OpenFile()
		
		Dim fd As New OpenFileDialog()
		Dim changeTabNameForOpenFile As TabPage
		fd.Filter = "SQL File|*.sql|Text File|*.txt|All Files|*.*"
		fd.DefaultExt = "*.*"
		fd.FilterIndex = 1   '*.sql
		fd.InitialDirectory = "C:\Desktop"
		fd.Title = "Open File"
		fd.Multiselect = True 
		
		If fd.ShowDialog() = Windows.Forms.DialogResult.OK Then 
			
			Dim file As String 
			For Each file In fd.FileNames
				
				CreateQueryArea()
				MessageBox.Show(file.ToString())
				GlobalVariables.Txtbox.Text = My.Computer.FileSystem.ReadAllText(file)
				
				'change tabname after opening file to query pan
				changeTabNameForOpenFile = tabControlEx1.SelectedTab
				changeTabNameForOpenFile.Text = file & " - " & cmbdbname.Text
				changeTabNameForOpenFile.ToolTipText = file & " - " & cmbdbname.Text 
				
			Next
			
			
		End If		
		
	End Sub
	
	Sub SaveQuery()
		
		Dim saveFileDialog1 As New SaveFileDialog()
		Dim changeTabNameForSave As TabPage 
		saveFileDialog1.Filter = "SQL File|*.sql|All Files|*.*|Text File|*.txt"
		saveFileDialog1.FilterIndex = 1
		saveFileDialog1.InitialDirectory = "C:\Desktop"
		saveFileDialog1.Title = "Save File As"
		saveFileDialog1.OverwritePrompt = True
		saveFileDialog1.RestoreDirectory = True 
		
		If saveFileDialog1.ShowDialog() = DialogResult.OK Then 
			My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, GlobalVariables.Txtbox.Text, True)
			
			'change tabname after saving to the files
			changeTabNameForSave = tabControlEx1.SelectedTab 
			changeTabNameForSave.Text = saveFileDialog1.FileName
			changeTabNameForSave.ToolTipText = saveFileDialog1.FileName
			
		End If
		
	End Sub
	
	
	Sub SaveQueryAll()
		
		For Each tp As TabPage In tabControlEx1.TabPages
			
			tabControlEx1.SelectedTab = tp
			For Each ctl As Control In tp.Controls
				If TypeOf ctl Is RichTextBox Then 
					
					' ctl.Text = "Something"
					
					Dim saveFileDialog1 As New SaveFileDialog()
					saveFileDialog1.Filter = "SQL File|*.sql|All Files|*.*|Text File|*.txt"
					saveFileDialog1.FilterIndex = 1   '.sql
					saveFileDialog1.InitialDirectory = "C:\Desktop"
					saveFileDialog1.Title = "Save File As"
					saveFileDialog1.OverwritePrompt = True 
					saveFileDialog1.RestoreDirectory = True
					
					If ctl.Text.Trim() <> "" Then 
						
						If saveFileDialog1.ShowDialog() = DialogResult.OK Then 
							
							My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, ctl.Text, True)
							
							' Change tabname after saving to the files
							Dim changeTabNameForSaveAll As TabPage 
							changeTabNameForSaveAll = tp
							changeTabNameForSaveAll.Text = saveFileDialog1.FileName 
							changeTabNameForSaveAll.ToolTipText = saveFileDialog1.FileName 
							
						End If
						
						'If saveFileDialog1.ShowDialog() = DialogResult.Cancel Then 
							
							'Dim pagetext As String 
							''Dim trimmedpagetext As String 
							'pagetext = tabControlEx1.SelectedTab.Text.ToString()
							''trimmedpagetext = pagetext.Substring(0,pagetext.LastIndexOf("-")).Trim()
							
							'Dim changeTabNameForClose As TabPage 
							'changeTabNameForClose = tabControlEx1.SelectedTab 
							'changeTabNameForClose.Text = pagetext 
							'changeTabNameForClose.ToolTipText = pagetext 						
							
						'End If
						
					End If
					
					
					
				End If
			Next		
			
		Next
		
	End Sub
	
	
	Private WithEvents docToPrint As New Printing.PrintDocument
	
	Sub Print()
		
		printDialog1.AllowSomePages = True 
		printDialog1.ShowHelp = True
		printDialog1.Document = docToPrint 
		Dim result As DialogResult = printDialog1.ShowDialog()
		
		'If the result is ok then print the document
		If (result = DialogResult.OK ) Then 
			docToPrint.Print()
		End If
		
	End Sub
	
	Private Sub document_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) _ 		
		Handles docToPrint.PrintPage
		
		Dim text As String = GlobalVariables.Txtbox.Text 
		Dim printFont As New System.Drawing.Font("Arial",35,System.Drawing.FontStyle.Regular)
		
		'Draw the content
		e.Graphics.DrawString(text, printFont, System.Drawing.Brushes.Black, 10, 10)
				
	End Sub
	
	Public Sub ViewerLoad(sender As Object, e As EventArgs) Handles MyBase.Load 
		
		cmbservername.Enabled = False 
		Me.KeyPreview = True 
		
		''AddHandler Me.KeyDown, AddressOf keyDownHandler		
		AddHandler Me.KeyUp, AddressOf keyUpHandler
		
	Try 	
		
		Dim server1 As String = cmbservername.Text 
		
		If server1.Contains("localhost") OrElse server1.Contains("Chirag-PC")  Then
			
			Dim ConString As String = "Data Source = " & server1 & ";Initial Catalog= master; Integrated Security = True"
			Dim SelectStrDB As String = "SELECT name FROM master.dbo.sysdatabases"
			Using connectionforDB As SqlConnection = New SqlConnection(ConString)
				connectionforDB.Open()
				Using comm As SqlCommand = New SqlCommand(SelectStrDB,connectionforDB)
					Dim rs As SqlDataReader = comm.ExecuteReader 
					Dim dt As DataTable = New DataTable
					
					' Fill a combo box with the datareader
					Do While rs.Read = True 
						'MessageBox.Show(rs.GetString(0))
						cmbdbname.Items.Add(rs.GetString(0))
					Loop
					
				End Using 'comm
			End Using 'connectionforDB
			
		Else If server1.Contains("Dev") Then 
			MessageBox.Show("Development Server")
		Else If server1.Contains("UAT") Then 
			MessageBox.Show("UAT")
		Else If server1.Contains("Prod") Then 
			MessageBox.Show("Production Server")
		End If
		
' Create Empty Query pan on start up		
		CreateQueryArea()
		
	Catch ex As Exception 
		
		MessageBox.Show(ex.Message)
		
	End Try
	
		

	End Sub
	
	
	Private Sub KeyUpHandler (ByVal o As Object, ByVal e As KeyEventArgs)
		
		e.SuppressKeyPress = True 
		If e.KeyCode = Keys.F5 Then 
			btnexecute.PerformClick
		End If
		
	End Sub
	
	
	Sub MDXQueryAnalysisServicesToolStripMenuItemClick(sender As Object, e As EventArgs)
		
	End Sub
	
	
	
	Sub CmbdbnameClick(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub CmbdbnameSelectedIndexChanged (sender As Object, e As EventArgs) Handles cmbdbname.SelectedIndexChanged
		
		Try 
			
			cmbdbname.Enabled = True
			Dim pagetext As String 
			Dim trimmedpagetext As String
			pagetext = TabControlEx1.SelectedTab.Text.ToString()
			trimmedpagetext = pagetext.Substring(0,pagetext.LastIndexOf("-")).Trim()
			Dim getPage As TabPage 
			getPage = TabControlEx1.SelectedTab
			getPage.Text = trimmedpagetext & " - " & cmbdbname.Text
			getPage.ToolTipText = trimmedpagetext & " - " & cmbdbname.Text
			
		Catch ex As Exception 
			cmbdbname.Enabled = False
			MessageBox.Show("Please create query pan")
			
		End Try
		
	End Sub
	
	
	Sub ConnectToDBExplorerToolStripMenuItemClick(sender As Object, e As EventArgs)
		
		Dim MessageString As String = "In Process" & ControlChars.NewLine & "Today's Date/Time: " & Date.Now.ToString
		Dim TitleString As String = "Connect to DB Explorer"
		MessageBox.Show(MessageString, TitleString, MessageBoxButtons.OK, MessageBoxIcon.Information)
		
	End Sub
		
	
	Sub QueryWithCurrentConnectionToolStripMenuItemClick(sender As Object, e As EventArgs)
		
		CreateQueryArea()
		
	End Sub
	
	
	Sub FIleToolStripMenuItem1Click(sender As Object, e As EventArgs)
		
		OpenFile()
		
	End Sub
	
	
	Sub SaveToolStripMenuItemClick(sender As Object, e As EventArgs)
		
		SaveQuery()
		
	End Sub
	
	Sub ToolStripMenuItem1Click(sender As Object, e As EventArgs)
		
		SaveQuery()	
		
	End Sub
	
	
	Sub SaveAllToolStripMenuItemClick(sender As Object, e As EventArgs)
		
		Dim result As Integer = MessageBox.Show("save changes to following items" , "Save File As", MessageBoxButtons.YesNoCancel)
		If result = DialogResult.Cancel Then 
		ElseIf result = DialogResult.No Then 
			tabControlEx1.TabPages.Remove(tabControlEx1.SelectedTab)
		ElseIf result = DialogResult.Yes Then
			SaveQueryAll()
		End If		
		
	End Sub
	
	
	Sub DisconnectToDBExplorerToolStripMenuItemClick(sender As Object, e As EventArgs)
		
	'For Each tp as TabPage In tabControlEx1.TabPages	
		
		Dim pagetext As String 
		Dim trimmedpagetext As String
		pagetext = tabControlEx1.SelectedTab.Text.ToString()
		trimmedpagetext = pagetext.Substring(0,pagetext.LastIndexOf("-")).Trim()
		
		Dim changeTabNameForDisconnect As TabPage 
		changeTabNameForDisconnect = tabControlEx1.SelectedTab 
		changeTabNameForDisconnect.Text = trimmedpagetext & " - not connected"
		changeTabNameForDisconnect.ToolTipText = trimmedpagetext & " - not connected"
		
	'Next	
		
	End Sub
	
	Sub ToolStripbtnNQueryClick(sender As Object, e As EventArgs)
		
		CreateQueryArea()
		
	End Sub
			
	Sub ToolStripbtnOpenClick(sender As Object, e As EventArgs)
		
		OpenFile()
		
	End Sub
	
	Sub ToolStripbtnSaveClick(sender As Object, e As EventArgs)
		
		SaveQuery()
		
	End Sub
End Class
