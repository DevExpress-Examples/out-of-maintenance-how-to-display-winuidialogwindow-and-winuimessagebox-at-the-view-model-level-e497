Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace WinUIDialogWindowAndMessageBox.MVVM

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            ThemeManager.ApplicationThemeName = Theme.MetropolisLightName
            MyBase.OnStartup(e)
        End Sub
    End Class
End Namespace
