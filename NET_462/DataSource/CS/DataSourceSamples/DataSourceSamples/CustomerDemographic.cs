//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataSourceSamples
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    
    public partial class CustomerDemographic : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    	protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    
        public CustomerDemographic()
        {
            this.Customers = new ObservableCollection<Customer>();
        }
    
        string _CustomerTypeID;
        public string CustomerTypeID 
        {
            get { return _CustomerTypeID; }
            set
            {
                _CustomerTypeID = value;
                OnPropertyChanged("CustomerTypeID");
            }
        }
        string _CustomerDesc;
        public string CustomerDesc 
        {
            get { return _CustomerDesc; }
            set
            {
                _CustomerDesc = value;
                OnPropertyChanged("CustomerDesc");
            }
        }
    
        public virtual ObservableCollection<Customer> Customers { get; set; }
    }
}
