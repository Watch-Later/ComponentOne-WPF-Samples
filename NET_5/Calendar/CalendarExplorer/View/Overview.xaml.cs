﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using C1.WPF.Calendar;
using C1.WPF.Core;
using C1.WPF.DateTimeEditors;
using C1.WPF.Input;
using CalendarExplorer.Resources;

namespace CalendarExplorer
{
    /// <summary>
    ///     Interaction logic for Overview.xaml
    /// </summary>
    public partial class Overview : UserControl
    {
        public Overview()
        {
            InitializeComponent();

            Tag = AppResources.OverviewDescription;

            cbDayOfWeek.ItemsSource = new List<DayOfWeek>
            {
                DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday,
                DayOfWeek.Saturday, DayOfWeek.Sunday
            };
            cbDayOfWeek.SelectedItemChanged += CbDayOfWeek_SelectedItemChanged;

            dpMinDate.SelectedDateChanged += DpMinDate_SelectedDateChanged;
            dpMaxDate.SelectedDateChanged += DpMaxDate_SelectedDateChanged;

            cbkShowHeader.IsChecked = true;
            cbkShowHeader.Checked += CbkShowHeader_Checked;
            cbkShowHeader.Unchecked += CbkShowHeader_Unchecked;

            cbkShowNavigationButton.IsChecked = true;
            cbkShowNavigationButton.Checked += CbkShowNavigationButton_Checked;
            cbkShowNavigationButton.Unchecked += CbkShowNavigationButton_Unchecked;

            cbkShowAdjacentDay.IsChecked = true;
            cbkShowAdjacentDay.Checked += CbkShowAdjacentDay_Checked;
            cbkShowAdjacentDay.Unchecked += CbkShowAdjacentDay_Unchecked;

            cbOrientation.ItemsSource = new List<Orientation> { Orientation.Vertical, Orientation.Horizontal };
            cbOrientation.SelectedItemChanged += CbOrientation_SelectedItemChanged;


            cbDayOfWeekFormat.ItemsSource = new List<string>() { "d", "dd", "ddd", "dddd" };
            cbDayOfWeekFormat.SelectedItemChanged += CbDayOfWeekFormat_SelectedItemChanged; ;


            cbHeaderFormat.ItemsSource = new List<string> { "M yyyy", "MMM yyyy", "MMMM yyyy" };
            cbHeaderFormat.SelectedItemChanged += CbHeaderFormat_SelectedItemChanged;

            cbCalendarType.ItemsSource = new List<CalendarType> { CalendarType.Default, CalendarType.Gregorian, CalendarType.Japanese };
            cbCalendarType.SelectedItemChanged += CbCalendarType_SelectedItemChanged;


        }

        private void CbCalendarType_SelectedItemChanged(object sender, PropertyChangedEventArgs<object> e)
        {

            var calendarType = (sender as C1ComboBox).SelectedItem;

            if (calendarType != null)
            {
                Calendar.CalendarType = (CalendarType)calendarType;
            }

        }

        private void CbDayOfWeekFormat_SelectedItemChanged(object sender, PropertyChangedEventArgs<object> e)
        {
            Calendar.DayOfWeekFormat = (string)((C1ComboBox)sender).SelectedItem;
        }

        private void CbHeaderFormat_SelectedItemChanged(object sender, PropertyChangedEventArgs<object> e)
        {
            Calendar.HeaderMonthFormat = (string)e.NewValue;
        }

        private void CbkShowAdjacentDay_Unchecked(object sender, RoutedEventArgs e)
        {
            Calendar.ShowAdjacentDay = false;
        }

        private void CbkShowAdjacentDay_Checked(object sender, RoutedEventArgs e)
        {
            Calendar.ShowAdjacentDay = true;
        }

        private void CbOrientation_SelectedItemChanged(object sender, PropertyChangedEventArgs<object> e)
        {

            var orientation = ((C1ComboBox) sender).SelectedItem;

            if (orientation != null)
            {
                Calendar.Orientation = (Orientation)orientation;
            }
        }


        private void CbkShowNavigationButton_Unchecked(object sender, RoutedEventArgs e)
        {
            Calendar.ShowNavigationButtons = false;
        }

        private void CbkShowNavigationButton_Checked(object sender, RoutedEventArgs e)
        {
            Calendar.ShowNavigationButtons = true;
        }

        private void CbkShowHeader_Unchecked(object sender, RoutedEventArgs e)
        {
            Calendar.ShowHeader = false;
        }

        private void CbkShowHeader_Checked(object sender, RoutedEventArgs e)
        {
            Calendar.ShowHeader = true;
        }

        private void CbDayOfWeek_SelectedItemChanged(object sender, PropertyChangedEventArgs<object> e)
        {
            Calendar.FirstDayOfWeek = (DayOfWeek)cbDayOfWeek.SelectedItem;
        }

        private void DpMaxDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Calendar.MaxDate = (sender as C1DatePicker).SelectedDate;
        }

        private void DpMinDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Calendar.MinDate = (sender as C1DatePicker).SelectedDate;
        }
    }
}