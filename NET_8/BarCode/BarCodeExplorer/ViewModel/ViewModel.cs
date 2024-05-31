﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace BarCodeExplorer
{
    class Entity : INotifyPropertyChanged
    {
        private string _encodingText;

        public event PropertyChangedEventHandler PropertyChanged;

        public string EncodingText
        {
            get
            {
                return _encodingText;
            }
            set
            {
                _encodingText = value;
                OnPropertyChanged("EncodingText");
            }
        }

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    #region Email
    class EmailEntity : Entity
    {
        private string _address = string.Empty;
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                EncodingText = ToString();
                OnPropertyChanged("Address");
            }
        }

        public string Caption
        {
            get
            {
                return "E-mail Address";
            }
        }

        public override string ToString()
        {
            return _address;
        }
    }
    #endregion

    #region Url
    class UrlEntity : Entity
    {
        private string _url = string.Empty;
        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
                _url = value;
                EncodingText = ToString();
                OnPropertyChanged("Url");
            }
        }

        public string Caption
        {
            get
            {
                return "Web Url";
            }
        }

        public override string ToString()
        {
            return _url;
        }
    }
    #endregion

    #region Text
    class TextEntity : Entity
    {
        private string _text = string.Empty;
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                EncodingText = value;
                OnPropertyChanged("Text");
            }
        }

        public string Caption
        {
            get
            {
                return "Input Text";
            }
        }
    }
    #endregion

    #region VCard
    class VCardEntity : Entity
    {
        private string _prefix;
        private string _firstName;
        private string _lastName;
        private string _suffix;
        private string _fullName;
        private string _nickname;
        private string _photo;
        private string _title;
        private string _role;
        private string _organization;
        private string _logo;
        private string _homeAddress;
        private string _homeCity;
        private string _homeState;
        private string _homeZip;
        private string _homeCountry;
        private string _officeAddress;
        private string _officeCity;
        private string _officeState;
        private string _officeZip;
        private string _officeCountry;
        private string _homePhone;
        private string _officePhone;
        private string _fax;
        private string _cell;
        private string _email;
        private string _website;

        public string Prefix
        {
            get
            {
                return _prefix;
            }
            set
            {
                _prefix = value;
                EncodingText = ToString();
                OnPropertyChanged("Prefix");
            }
        }

        public string PrefixCaption
        {
            get
            {
                return "Prefix";
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                EncodingText = ToString();
                OnPropertyChanged("FirstName");
            }
        }

        public string FirstNameCaption
        {
            get
            {
                return "First Name";
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                EncodingText = ToString();
                OnPropertyChanged("LastName");
            }
        }

        public string LastNameCaption
        {
            get
            {
                return "Last Name";
            }
        }

        public string Suffix
        {
            get
            {
                return _suffix;
            }
            set
            {
                _suffix = value;
                EncodingText = ToString();
                OnPropertyChanged("Suffix");
            }
        }

        public string SuffixCaption
        {
            get
            {
                return "Suffix";
            }
        }

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                _fullName = value;
                EncodingText = ToString();
                OnPropertyChanged("FullName");
            }
        }

        public string FullNameCaption
        {
            get
            {
                return "Full Name";
            }
        }

        public string Nickname
        {
            get
            {
                return _nickname;
            }
            set
            {
                _nickname = value;
                EncodingText = ToString();
                OnPropertyChanged("Nickname");
            }
        }

        public string NicknameCaption
        {
            get
            {
                return "Nickname";
            }
        }
        public string Photo
        {
            get
            {
                return _photo;
            }
            set
            {
                _photo = value;
                EncodingText = ToString();
                OnPropertyChanged("Photo");
            }
        }

        public string PhotoCaption
        {
            get
            {
                return "Photo";
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                EncodingText = ToString();
                OnPropertyChanged("Title");
            }
        }

        public string TitleCaption
        {
            get
            {
                return "Title";
            }
        }

        public string Role
        {
            get
            {
                return _role;
            }
            set
            {
                _role = value;
                EncodingText = ToString();
                OnPropertyChanged("Role");
            }
        }

        public string RoleCaption
        {
            get
            {
                return "Role";
            }
        }

        public string Organization
        {
            get
            {
                return _organization;
            }
            set
            {
                _organization = value;
                EncodingText = ToString();
                OnPropertyChanged("Organization");
            }
        }

        public string OrganizationCaption
        {
            get
            {
                return "Organization";
            }
        }

        public string Logo
        {
            get
            {
                return _logo;
            }
            set
            {
                _logo = value;
                EncodingText = ToString();
                OnPropertyChanged("Logo");
            }
        }

        public string LogoCaption
        {
            get
            {
                return "Logo";
            }
        }

        public string HomeAddress
        {
            get
            {
                return _homeAddress;
            }
            set
            {
                _homeAddress = value;
                EncodingText = ToString();
                OnPropertyChanged("HomeAddress");
            }
        }

        public string HomeAddressCaption
        {
            get
            {
                return "Address(Home)";
            }
        }

        public string HomeCity
        {
            get
            {
                return _homeCity;
            }
            set
            {
                _homeCity = value;
                EncodingText = ToString();
                OnPropertyChanged("HomeCity");
            }
        }

        public string HomeCityCaption
        {
            get
            {
                return "City(Home)";
            }
        }

        public string HomeState
        {
            get
            {
                return _homeState;
            }
            set
            {
                _homeState = value;
                EncodingText = ToString();
                OnPropertyChanged("HomeState");
            }
        }

        public string HomeStateCaption
        {
            get
            {
                return "State/Region(Home)";
            }
        }

        public string HomeZip
        {
            get
            {
                return _homeZip;
            }
            set
            {
                _homeZip = value;
                EncodingText = ToString();
                OnPropertyChanged("HomeZip");
            }
        }

        public string HomeZipCaption
        {
            get
            {
                return "Zip/Postal Code(Home)";
            }
        }

        public string HomeCountry
        {
            get
            {
                return _homeCountry;
            }
            set
            {
                _homeCountry = value;
                EncodingText = ToString();
                OnPropertyChanged("HomeCountry");
            }
        }

        public string HomeCountryCaption
        {
            get
            {
                return "Country(Home)";
            }
        }

        public string OfficeAddress
        {
            get
            {
                return _officeAddress;
            }
            set
            {
                _officeAddress = value;
                EncodingText = ToString();
                OnPropertyChanged("OfficeAddress");
            }
        }

        public string OfficeAddressCaption
        {
            get
            {
                return "Address(Office)";
            }
        }

        public string OfficeCity
        {
            get
            {
                return _officeCity;
            }
            set
            {
                _officeCity = value;
                EncodingText = ToString();
                OnPropertyChanged("OfficeCity");
            }
        }

        public string OfficeCityCaption
        {
            get
            {
                return "City(Office)";
            }
        }

        public string OfficeState
        {
            get
            {
                return _officeState;
            }
            set
            {
                _officeState = value;
                EncodingText = ToString();
                OnPropertyChanged("OfficeState");
            }
        }

        public string OfficeStateCaption
        {
            get
            {
                return "State/Region(Office)";
            }
        }

        public string OfficeZip
        {
            get
            {
                return _officeZip;
            }
            set
            {
                _officeZip = value;
                EncodingText = ToString();
                OnPropertyChanged("OfficeZip");
            }
        }

        public string OfficeZipCaption
        {
            get
            {
                return "Zip/Postal Code(Office)";
            }
        }

        public string OfficeCountry
        {
            get
            {
                return _officeCountry;
            }
            set
            {
                _officeCountry = value;
                EncodingText = ToString();
                OnPropertyChanged("OfficeCountry");
            }
        }

        public string OfficeCountryCaption
        {
            get
            {
                return "Country(Office)";
            }
        }

        public string HomePhone
        {
            get
            {
                return _homePhone;
            }
            set
            {
                _homePhone = value;
                EncodingText = ToString();
                OnPropertyChanged("HomePhone");
            }
        }

        public string HomePhoneCaption
        {
            get
            {
                return "Phone(Home)";
            }
        }

        public string OfficePhone
        {
            get
            {
                return _officePhone;
            }
            set
            {              
                _officePhone = value;
                EncodingText = ToString();
                OnPropertyChanged("OfficePhone");
            }
        }

        public string OfficePhoneCaption
        {
            get
            {
                return "Phone(Office)";
            }
        }

        public string Fax
        {
            get
            {
                return _fax;
            }
            set
            {
                _fax = value;
                EncodingText = ToString();
                OnPropertyChanged("Fax");
            }
        }

        public string FaxCaption
        {
            get
            {
                return "Fax";
            }
        }

        public string Cell
        {
            get
            {
                return _cell;
            }
            set
            {
                _cell = value;
                EncodingText = ToString();
                OnPropertyChanged("Cell");
            }
        }

        public string CellCaption
        {
            get
            {
                return "Cell";
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                EncodingText = ToString();
                OnPropertyChanged("Email");
            }
        }

        public string EmailCaption
        {
            get
            {
                return "E-mail";
            }
        }

        public string Website
        {
            get
            {
                return _website;
            }
            set
            {
                _website = value;
                EncodingText = ToString();
                OnPropertyChanged("Website");
            }
        }

        public string WebsiteCaption
        {
            get
            {
                return "Website(developer.mescius.com/componentone)";
            }
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();

            StringCreator("Prefix", Prefix);
            StringCreator("FirstName", FirstName);
            StringCreator("LastName", LastName);
            StringCreator("Suffix", Suffix);
            StringCreator("FullName", FullName);
            StringCreator("Nickname", Nickname);
            StringCreator("Photo", Photo);
            StringCreator("Title", Title);
            StringCreator("Role", Role);
            StringCreator("Organization", Organization);
            StringCreator("Logo", Logo);
            StringCreator("Home Address", HomeAddress);
            StringCreator("Home City", HomeCity);
            StringCreator("Home State", HomeState);
            StringCreator("Home Zip", HomeZip);
            StringCreator("Home Country", HomeCountry);
            StringCreator("Office Address", OfficeAddress);
            StringCreator("Office City", OfficeCity);
            StringCreator("Office State", OfficeState);
            StringCreator("Office Zip", OfficeZip);
            StringCreator("Office Country", OfficeCountry);
            StringCreator("Home Phone", HomePhone);
            StringCreator("Office Phone", OfficePhone);
            StringCreator("Fax", Fax);
            StringCreator("Cell", Cell);
            StringCreator("Email", Email);
            StringCreator("Website", Website);
            void StringCreator(string propertyName, string value)
            {
                if (!string.IsNullOrEmpty(value))//check if property value is not empty or null. When true don't append anything.
                {   
                    strBuilder.Append(propertyName + ":" + value + " ");//when not true append property name, property value and a white space to separate
                    // different properties from each other.
                }
            }
            string str = strBuilder.ToString().Trim();//remove any trailing space.
            return str;

        }
    }
    #endregion

    public enum Format
    {
        Email,
        Url,
        VCard,
        Text
    }
}