<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WinUIDialogWindowAndMessageBox.MVVM/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WinUIDialogWindowAndMessageBox.MVVM/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WinUIDialogWindowAndMessageBox.MVVM/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WinUIDialogWindowAndMessageBox.MVVM/MainWindow.xaml.vb))
* [MainViewModel.cs](./CS/WinUIDialogWindowAndMessageBox.MVVM/ViewModels/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/WinUIDialogWindowAndMessageBox.MVVM/ViewModels/MainViewModel.vb))
* [TestViewModel.cs](./CS/WinUIDialogWindowAndMessageBox.MVVM/ViewModels/TestViewModel.cs) (VB: [TestViewModel.vb](./VB/WinUIDialogWindowAndMessageBox.MVVM/ViewModels/TestViewModel.vb))
* [MainView.xaml](./CS/WinUIDialogWindowAndMessageBox.MVVM/Views/MainView.xaml) (VB: [MainView.xaml](./VB/WinUIDialogWindowAndMessageBox.MVVM/Views/MainView.xaml))
* [MainView.xaml.cs](./CS/WinUIDialogWindowAndMessageBox.MVVM/Views/MainView.xaml.cs) (VB: [MainView.xaml.vb](./VB/WinUIDialogWindowAndMessageBox.MVVM/Views/MainView.xaml.vb))
* [TestView.xaml](./CS/WinUIDialogWindowAndMessageBox.MVVM/Views/TestView.xaml) (VB: [TestView.xaml](./VB/WinUIDialogWindowAndMessageBox.MVVM/Views/TestView.xaml))
* [TestView.xaml.cs](./CS/WinUIDialogWindowAndMessageBox.MVVM/Views/TestView.xaml.cs) (VB: [TestView.xaml.vb](./VB/WinUIDialogWindowAndMessageBox.MVVM/Views/TestView.xaml.vb))
* [MainWindow.xaml](./CS/WinUIDialogWindowAndMessageBox/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WinUIDialogWindowAndMessageBox/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WinUIDialogWindowAndMessageBox/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WinUIDialogWindowAndMessageBox/MainWindow.xaml.vb))
* [TestUserControl.xaml](./CS/WinUIDialogWindowAndMessageBox/TestUserControl.xaml) (VB: [TestUserControl.xaml](./VB/WinUIDialogWindowAndMessageBox/TestUserControl.xaml))
* [TestUserControl.xaml.cs](./CS/WinUIDialogWindowAndMessageBox/TestUserControl.xaml.cs) (VB: [TestUserControl.xaml.vb](./VB/WinUIDialogWindowAndMessageBox/TestUserControl.xaml.vb))
<!-- default file list end -->
# How to: Display WinUIDialogWindow and WinUIMessageBox at the View Model level


<p>This Code Example demonstrates how to use the WinUIDialogWindow and WinUIMessageBox controls. The example contains two projects: one demonstrates how to use the controls in the MVVM pattern, and the other - in code behind. The first project uses special <a href="https://documentation.devexpress.com/#WPF/CustomDocument17414">services</a>: <a href="https://documentation.devexpress.com/#WPF/CustomDocument17468">WinUIDialogService</a> and <a href="https://documentation.devexpress.com/#WPF/CustomDocument17466">WinUIMessageBoxService</a>. In the second project, the dialog and MessageBox are shown using the WinUIDialogWindow.ShowDialogWindow and WinUIMessageBox.Show methods.</p>

<br/>


