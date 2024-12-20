﻿using C1.WPF.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace InputExplorer
{
    public partial class ValidationForm : UserControl
    {
        public ValidationForm()
        {
            InitializeComponent();
            Tag = Properties.Resources.ValidationFormDescription;
        }

        private void OnFormValidated(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.FormWasValidated);
        }
    }

    public class ValidationFormViewModel : INotifyPropertyChanged, INotifyDataErrorInfo, IValidatableObject
    {
        public enum GenderValues
        {
            Female,
            Male,
            Other
        }
        string _firstName;
        string _lastName;
        DateTime _dateOfBirth = DateTime.Today;
        GenderValues? _gender;
        string _email;
        int _stars;
        string _picture;
        Color? _favoriteColor;
        int _workingFrom = 0, _workingTo = 24;

        List<System.ComponentModel.DataAnnotations.ValidationResult> _errors = new List<System.ComponentModel.DataAnnotations.ValidationResult>();

        public ValidationFormViewModel()
        {
            SubmitCommand = new DelegateCommand(OnSubmit);
        }

        [Required(ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldRequired")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "CharactersNotAllowed")]
        [Display(Name = "FirstName", ResourceType = typeof(Properties.Resources))]
        public string FirstName { get { return _firstName; } set { _firstName = value; OnPropertyChanged(); } }

        [Required(ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldRequired")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "CharactersNotAllowed")]
        [Display(Name = "LastName", ResourceType = typeof(Properties.Resources))]
        public string LastName { get { return _lastName; } set { _lastName = value; OnPropertyChanged(); } }

        [MinimumAge(18)]
        [Display(Name = "DateOfBirth", ResourceType = typeof(Properties.Resources))]
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; OnPropertyChanged(); } }

        [Required(ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldRequired")]
        [Display(Name = "Gender", ResourceType = typeof(Properties.Resources))]
        public GenderValues? Gender { get { return _gender; } set { _gender = value; OnPropertyChanged(); } }

        public Tuple<GenderValues, string>[] Genders { get; } = new Tuple<GenderValues, string>[] {
            new Tuple<GenderValues, string>(GenderValues.Female, Properties.Resources.Female),
            new Tuple<GenderValues, string>(GenderValues.Male, Properties.Resources.Male),
            new Tuple<GenderValues, string>(GenderValues.Other, Properties.Resources.OtherGender)
        };

        [Required(ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldRequired")]
        [EmailAddress]
        [Display(Name = "Email", ResourceType = typeof(Properties.Resources))]
        public string Email { get { return _email; } set { _email = value; OnPropertyChanged(); } }

        [Range(1, 5, ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldMustBeBetween")]
        [Display(Name = "Stars", ResourceType = typeof(Properties.Resources))]
        public int Stars { get { return _stars; } set { _stars = value; OnPropertyChanged(); } }

        [Required(ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldRequired")]
        [Display(Name = "Picture", ResourceType = typeof(Properties.Resources))]
        public string Picture { get { return _picture; } set { _picture = value; OnPropertyChanged(); } }

        [Required(ErrorMessageResourceType = typeof(Properties.Resources),ErrorMessageResourceName = "FieldRequired") ]
        [Display(Name = "FavoriteColor", ResourceType = typeof(Properties.Resources))]
        public Color? FavoriteColor { get { return _favoriteColor; } set { _favoriteColor = value; OnPropertyChanged(); } }

        [Range(0, 24, ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldMustBeBetween")]
        public int WorkingFrom { get { return _workingFrom; } set { _workingFrom = value; OnPropertyChanged(); } }
        [Range(0, 24, ErrorMessageResourceType = typeof(Properties.Resources), ErrorMessageResourceName = "FieldMustBeBetween")]
        public int WorkingTo { get { return _workingTo; } set { _workingTo = value; OnPropertyChanged(); } }

        public ICommand SubmitCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            _errors.Clear();
            Validator.TryValidateObject(this, new ValidationContext(this), _errors, true);

            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool HasErrors => _errors.Count > 0;

        public void OnSubmit(object param)
        {
            _errors.Clear();
            Validator.TryValidateObject(this, new ValidationContext(this), _errors, true);
            OnPropertyChanged(nameof(FirstName));
            OnPropertyChanged(nameof(LastName));
            OnPropertyChanged(nameof(DateOfBirth));
            OnPropertyChanged(nameof(Gender));
            OnPropertyChanged(nameof(Email));
            OnPropertyChanged(nameof(Stars));
            OnPropertyChanged(nameof(Picture));
            OnPropertyChanged(nameof(FavoriteColor));
            OnPropertyChanged(nameof(WorkingFrom));
            OnPropertyChanged(nameof(WorkingTo));
            if (_errors.Count == 0)
                FormValidated?.Invoke(this, new EventArgs());
        }

        public event EventHandler FormValidated;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            return _errors.Where(e => e.MemberNames.Contains(propertyName));
        }

        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            int result = WorkingTo - WorkingFrom;
            if (result > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult( Properties.Resources.CanNotWorkMoreThan, new[] { nameof(WorkingFrom), nameof(WorkingTo) });
            }
        }
    }

    public class MinimumAgeAttribute : ValidationAttribute
    {
        public MinimumAgeAttribute(int minimumAge)
        {
            MinimumAge = minimumAge;
            ErrorMessage = Properties.Resources.AgeRequirement;
        }

        public override bool IsValid(object value)
        {
            DateTime date;
            if ((value != null && DateTime.TryParse(value.ToString(), out date)))
            {
                return date.AddYears(MinimumAge) < DateTime.Now;
            }

            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString, name, MinimumAge);
        }

        public int MinimumAge { get; }
    }

    public class FileConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string filePath && targetType == typeof(FileInfo))
                return new FileInfo(filePath);
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is FileInfo fileInfo && targetType == typeof(string))
                return fileInfo.FullName;
            return value;
        }
    }
}
