using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StudentsApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName != null)
            {
                var handler = PropertyChanged;
                handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string this[string columnName] => GetColumnError(columnName);

        public string Error { get; set; }

        protected IList<string> ErrorsList = new List<string>();

        protected virtual string GetColumnError(string columnName)
        {
            return null;
        }
    }
}
