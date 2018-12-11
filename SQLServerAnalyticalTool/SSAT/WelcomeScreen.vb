Imports System.Data.OleDb
Imports System.Data.SqlClient


Public Partial Class MainForm
	
	Friend ObjViewer As New Viewer
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Label3Click(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub Label5Click(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub BtnconnectClick(sender As Object, e As EventArgs)
		
		Dim ServerType As String = cmbservertype.Text 
		Dim Server As String = cmbservername.Text
		
		Try 
			If cmbservername.Text = String.Empty And cmbservertype.Text = String.Empty Then 
				MsgBox("Please complete the form!")
				
			Else 
				
				Me.Hide()
												
				ObjViewer = New Viewer()
				ObjViewer.cmbservername.Text = Server
				ObjViewer.cmbdbname.Text = "master"  'DBName
				
				ObjViewer.ShowDialog()
				Me.Close()				
				
			End If
			
		Catch ex As Exception 
		
			MsgBox(ex.Message)		
				
		End Try		
	
	End Sub
	
		
	Sub BtncancelClick(sender As Object, e As EventArgs)
		
		Me.Close()
		
	End Sub
	
	Sub CmbauthenticationSelectedIndexChanged(sender As Object, e As EventArgs)
		
		
		If cmbauthentication.Text = "Windows Authentication" Then 
			
			username.Enabled = False
			password.Enabled = False
			
		Else 
			
			username.Enabled = True 
			password.Enabled = True 
			
		End If
		
		
	End Sub
End Class
