Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.WindowsUI
Imports System.Windows
Imports System.Windows.Controls

Namespace WinUIDialogWindowAndMessageBox

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DXWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim dialog As WinUIDialogWindow = New WinUIDialogWindow("Test", MessageBoxButton.OKCancel)
            dialog.Content = New TestUserControl()
            dialog.ShowDialogWindow()
        End Sub

        Private Sub Button_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
            WinUIMessageBox.Show("WinUIMessageBox", "Test", MessageBoxButton.OKCancel, MessageBoxImage.Information)
        End Sub
    End Class
End Namespace
