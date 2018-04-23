Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Core
Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows

Namespace WinUIDialogWindowAndMessageBox.MVVM
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application
		Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
			ThemeManager.ApplicationThemeName = Theme.MetropolisLightName
			MyBase.OnStartup(e)
		End Sub
	End Class
End Namespace
