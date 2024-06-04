//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientTransactions
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    
    public partial class Territory : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    	protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    
        public Territory()
        {
            this.Employees = new ObservableCollection<Employee>();
        }
    
        string _TerritoryID;
        public string TerritoryID 
        {
            get { return _TerritoryID; }
            set
            {
                _TerritoryID = value;
                OnPropertyChanged("TerritoryID");
            }
        }
        string _TerritoryDescription;
        public string TerritoryDescription 
        {
            get { return _TerritoryDescription; }
            set
            {
                _TerritoryDescription = value;
                OnPropertyChanged("TerritoryDescription");
            }
        }
        int _RegionID;
        public int RegionID 
        {
            get { return _RegionID; }
            set
            {
                _RegionID = value;
                OnPropertyChanged("RegionID");
            }
        }
    
        public virtual Region Region { get; set; }
        public virtual ObservableCollection<Employee> Employees { get; set; }
    }
}
