using System.Windows;
using System.Windows.Input;
using StudentsApp.ViewModels;

namespace StudentsApp
{
    public partial class ErrorView : Window
    {
        public ErrorView(ErrorViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        public ErrorView(RoutedUICommand command, string errorText)
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(command, CommandExecuted, CommandCanExecute));
            DataContext = new ErrorViewModel(command) { ErrorText = errorText };
        }

        private void CommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
