﻿using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace FlexChartExplorer
{
    public class SampleItem
    {
        public SampleItem(string name, string title, Control sample)
        {
            Name = name;
            Title = title;
            Sample = sample;
        }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description => Sample.Tag?.ToString();
        public Control Sample { get; set; }
    }
}