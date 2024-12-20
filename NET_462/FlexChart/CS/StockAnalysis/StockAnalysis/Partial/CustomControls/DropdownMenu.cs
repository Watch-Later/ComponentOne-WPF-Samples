﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockAnalysis.Partial.CustomControls
{
    public class DropdownMenu : ComboBox
    {
        static DropdownMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DropdownMenu), new FrameworkPropertyMetadata(typeof(DropdownMenu)));
        }

        public object Display
        {
            get { return this.GetValue(DisplayProperty); }
            set { this.SetValue(DisplayProperty, value); }
        }
        public static DependencyProperty DisplayProperty = DependencyProperty.Register(
            "Display",
            typeof(object),
            typeof(DropdownMenu),
            new PropertyMetadata(null)
        );
        
        public DataTemplate DisplayTemplate
        {
            get { return (DataTemplate)this.GetValue(DisplayTemplateProperty); }
            set { this.SetValue(DisplayTemplateProperty, value); }
        }
        public static DependencyProperty DisplayTemplateProperty = DependencyProperty.Register(
            "DisplayTemplate",
            typeof(DataTemplate),
            typeof(DropdownMenu),
            new PropertyMetadata(null)
        );

        public Visual DropdownHeader
        {
            get { return (Visual)this.GetValue(DropdownHeaderProperty); }
            set { this.SetValue(DropdownHeaderProperty, value); }
        }
        public static DependencyProperty DropdownHeaderProperty = DependencyProperty.Register(
            "DropdownHeader",
            typeof(Visual),
            typeof(DropdownMenu),
            new PropertyMetadata(null)
        );
        
    }
}
