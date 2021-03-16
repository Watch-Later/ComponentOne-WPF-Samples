﻿using System;
using System.Collections.ObjectModel;

namespace MenuExplorer
{
    public class SampleDataSource
    {
        public SampleDataSource()
        {
            AllItems = new ObservableCollection<SampleItem>
            {
                new SampleItem(Properties.Resources.DemoMenuTitle,
                                Properties.Resources.DemoMenuTitle,
                                new DemoMenu()),
                new SampleItem(Properties.Resources.CustomMenuAppearanceTitle,
                                Properties.Resources.CustomMenuAppearanceTitle,
                                new CustomMenuAppearance()),                
                new SampleItem(Properties.Resources.DropDownMenuTitle,
                                Properties.Resources.DropDownMenuTitle,
                                new DropDownMenu()),
                new SampleItem(Properties.Resources.DemoRadialMenuTitle,
                                Properties.Resources.DemoRadialMenuDesc,
                                new DemoRadialMenu()),
                new SampleItem(Properties.Resources.CustomRadialContextMenuTitle,
                                Properties.Resources.CustomRadialContextMenuTitle,
                                new CustomRadialContextMenu())
            };
        }

        public ObservableCollection<SampleItem> AllItems
        {
            get;
        }
    }
}
