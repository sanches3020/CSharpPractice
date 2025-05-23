﻿using System.ComponentModel;

namespace MedicalRecordsApp.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
