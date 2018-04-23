Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.WindowsUI
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace WinUIDialogWindowAndMessageBox
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits DXWindow

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim dialog As New WinUIDialogWindow("Test", MessageBoxButton.OKCancel)
            dialog.Content = New TestUserControl()
            dialog.ShowDialogWindow()
        End Sub

        Private Sub Button_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
            WinUIMessageBox.Show("WinUIMessageBox", "Test", MessageBoxButton.OKCancel, MessageBoxImage.Information)
        End Sub
    End Class
End Namespace
