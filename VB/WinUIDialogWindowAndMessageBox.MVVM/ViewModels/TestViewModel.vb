Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Mvvm

Namespace WinUIDialogWindowAndMessageBox.MVVM.ViewModels
	Public Class TestViewModel
		Inherits ViewModelBase
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
	End Class
End Namespace