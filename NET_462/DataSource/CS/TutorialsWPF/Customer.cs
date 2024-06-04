//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TutorialsWPF
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    
    public partial class Customer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    	protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    
        public Customer()
        {
            this.Orders = new ObservableCollection<Order>();
            this.CustomerDemographics = new ObservableCollection<CustomerDemographic>();
        }
    
        string _CustomerID;
        public string CustomerID 
        {
            get { return _CustomerID; }
            set
            {
                _CustomerID = value;
                OnPropertyChanged("CustomerID");
            }
        }
        string _CompanyName;
        public string CompanyName 
        {
            get { return _CompanyName; }
            set
            {
                _CompanyName = value;
                OnPropertyChanged("CompanyName");
            }
        }
        string _ContactName;
        public string ContactName 
        {
            get { return _ContactName; }
            set
            {
                _ContactName = value;
                OnPropertyChanged("ContactName");
            }
        }
        string _ContactTitle;
        public string ContactTitle 
        {
            get { return _ContactTitle; }
            set
            {
                _ContactTitle = value;
                OnPropertyChanged("ContactTitle");
            }
        }
        string _Address;
        public string Address 
        {
            get { return _Address; }
            set
            {
                _Address = value;
                OnPropertyChanged("Address");
            }
        }
        string _City;
        public string City 
        {
            get { return _City; }
            set
            {
                _City = value;
                OnPropertyChanged("City");
            }
        }
        string _Region;
        public string Region 
        {
            get { return _Region; }
            set
            {
                _Region = value;
                OnPropertyChanged("Region");
            }
        }
        string _PostalCode;
        public string PostalCode 
        {
            get { return _PostalCode; }
            set
            {
                _PostalCode = value;
                OnPropertyChanged("PostalCode");
            }
        }
        string _Country;
        public string Country 
        {
            get { return _Country; }
            set
            {
                _Country = value;
                OnPropertyChanged("Country");
            }
        }
        string _Phone;
        public string Phone 
        {
            get { return _Phone; }
            set
            {
                _Phone = value;
                OnPropertyChanged("Phone");
            }
        }
        string _Fax;
        public string Fax 
        {
            get { return _Fax; }
            set
            {
                _Fax = value;
                OnPropertyChanged("Fax");
            }
        }
    
        public virtual ObservableCollection<Order> Orders { get; set; }
        public virtual ObservableCollection<CustomerDemographic> CustomerDemographics { get; set; }
    }
}
