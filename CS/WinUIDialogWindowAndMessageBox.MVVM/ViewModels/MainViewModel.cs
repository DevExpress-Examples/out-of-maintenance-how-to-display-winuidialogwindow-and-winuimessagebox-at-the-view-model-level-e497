using System;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Xpf;
using System.Windows.Input;
using System.Windows;

namespace WinUIDialogWindowAndMessageBox.MVVM.ViewModels {
    public class MainViewModel : ViewModelBase {
        public ICommand ShowDialogWindowCommand { get; private set; }
        public ICommand ShowMessageBoxCommand { get; private set; }
        public MainViewModel() {
            ShowDialogWindowCommand = new DelegateCommand(ShowDialogWindow);
            ShowMessageBoxCommand = new DelegateCommand(ShowMessageBox);
        }
        void ShowDialogWindow() {
            DialogService.ShowDialog(MessageBoxButton.OKCancel, "Test", "TestView", null, this);
        }
        void ShowMessageBox() {
            MessageBoxService.Show("MessageBox", "Test", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        IDialogService DialogService { get { return GetService<IDialogService>(); } }
        IMessageBoxService MessageBoxService { get { return GetService<IMessageBoxService>(); } }
    }
}