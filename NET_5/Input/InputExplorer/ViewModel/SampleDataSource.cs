﻿using System;
using System.Collections.ObjectModel;

namespace InputExplorer
{
    public class SampleDataSource
    {
        public SampleDataSource()
        {
            AllItems = new ObservableCollection<SampleItem>
            {
                new SampleItem(Properties.Resources.InputTitle,
                                Properties.Resources.InputTitle,
                                new InputView()),
                new SampleItem(Properties.Resources.RangeSliderTitle,
                                Properties.Resources.RangeSliderTitle,
                                new RangeSlider()),
            };
        }

        public ObservableCollection<SampleItem> AllItems
        {
            get;
        }
    }
}
