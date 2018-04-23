Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Mvvm
Imports System.Windows.Input
Imports System.Windows

Namespace WinUIDialogWindowAndMessageBox.MVVM.ViewModels
	Public Class MainViewModel
		Inherits ViewModelBase
		Private privateShowDialogWindowCommand As ICommand
		Public Property ShowDialogWindowCommand() As ICommand
			Get
				Return privateShowDialogWindowCommand
			End Get
			Private Set(ByVal value As ICommand)
				privateShowDialogWindowCommand = value
			End Set
		End Property
		Private privateShowMessageBoxCommand As ICommand
		Public Property ShowMessageBoxCommand() As ICommand
			Get
				Return privateShowMessageBoxCommand
			End Get
			Private Set(ByVal value As ICommand)
				privateShowMessageBoxCommand = value
			End Set
		End Property
		Public Sub New()
			ShowDialogWindowCommand = New DelegateCommand(AddressOf ShowDialogWindow)
			ShowMessageBoxCommand = New DelegateCommand(AddressOf ShowMessageBox)
		End Sub
		Private Sub ShowDialogWindow()
			DialogService.ShowDialog(MessageBoxButton.OKCancel, "Test", "TestView", Nothing, Me)
		End Sub
		Private Sub ShowMessageBox()
			MessageBoxService.Show("MessageBox", "Test", MessageBoxButton.OKCancel, MessageBoxImage.Information)
		End Sub

		Private ReadOnly Property DialogService() As IDialogService
			Get
				Return GetService(Of IDialogService)()
			End Get
		End Property
		Private ReadOnly Property MessageBoxService() As IMessageBoxService
			Get
				Return GetService(Of IMessageBoxService)()
			End Get
		End Property
	End Class
End Namespace