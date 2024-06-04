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
using C1.WPF.DataGrid;

namespace DataGridSamples
{
    /// <summary>
    /// Interaction logic for DemoGrid.xaml
    /// </summary>
    public partial class DemoGrid : UserControl
    {
        public DemoGrid()
        {
            InitializeComponent();
            DataContext = Data.GetProducts((product) => !string.IsNullOrEmpty(product.Element("ProductModelID").Value) && product.Element("Image").Value != "no_image_available_small.jpg");
        }

        private void grid_AutoGeneratingColumn(object sender, C1.WPF.DataGrid.DataGridAutoGeneratingColumnEventArgs e)
        {
            Common.HandleColumnAutoGeneration(e);
            if (e.Property.Name == "Name" && e.Column is C1.WPF.DataGrid.DataGridBoundColumn)
            {
                e.Column.Width = new C1.WPF.DataGrid.DataGridLength(200);
                ((C1.WPF.DataGrid.DataGridBoundColumn)e.Column).TextWrapping = TextWrapping.Wrap;
            }
        }

        private void grid_AutoGeneratedColumns(object sender, EventArgs e)
        {
            //grid.SortBy(grid.Columns["StandardCost"], DataGridSortDirection.Descending);
            //grid.GroupBy(grid.Columns["Name"]);
            grid.Columns["ImageUrl"].DisplayIndex = 0;
        }

        private void grid_BeginningNewRow(object sender, DataGridBeginningNewRowEventArgs e)
        {
            e.Item = new Product() { ID = grid.Rows.Count, ImageUrl = "no_image_available_small.jpg" };
        }

        #region ** Object Model

        public C1.WPF.DataGrid.DataGridHeadersVisibility HeadersVisibility
        {
            get
            {
                return grid.HeadersVisibility;
            }
            set
            {
                grid.HeadersVisibility = value;
            }
        }

        public bool ShowFluidMouseOver
        {
            get
            {
                return grid.ShowFluidMouseOver;
            }
            set
            {
                grid.ShowFluidMouseOver = value;
            }
        }

        public bool CanUserSort
        {
            get
            {
                return grid.CanUserSort;
            }
            set
            {
                grid.CanUserSort = value;
            }
        }

        public bool CanUserFilter
        {
            get
            {
                return grid.CanUserFilter;
            }
            set
            {
                grid.CanUserFilter = value;
            }
        }

        public bool CanUserGroup
        {
            get
            {
                return grid.CanUserGroup;
            }
            set
            {
                grid.CanUserGroup = value;
            }
        }

        public bool ShowGroupingPanel
        {
            get
            {
                return grid.ShowGroupingPanel;
            }
            set
            {
                grid.ShowGroupingPanel = value;
            }
        }

        public DataGridColumnFreezing CanUserFreezeColumns
        {
            get
            {
                return grid.CanUserFreezeColumns;
            }
            set
            {
                grid.CanUserFreezeColumns = value;
            }
        }

        public C1.WPF.DataGrid.DataGridGridLinesVisibility GridLinesVisibility
        {
            get
            {
                return grid.GridLinesVisibility;
            }
            set
            {
                grid.GridLinesVisibility = value;
            }
        }

        public DataGridColumnFreezing ShowVerticalFreezingSeparator
        {
            get
            {
                return grid.ShowVerticalFreezingSeparator;
            }
            set
            {
                grid.ShowVerticalFreezingSeparator = value;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return grid.IsReadOnly;
            }
            set
            {
                grid.IsReadOnly = value;
            }
        }

        public bool IsLoading
        {
            get
            {
                return grid.IsLoading;
            }
            set
            {
                grid.IsLoading = value;
            }
        }

        public bool CanUserResizeColumns
        {
            get
            {
                return grid.CanUserResizeColumns;
            }
            set
            {
                grid.CanUserResizeColumns = value;
            }
        }

        public bool CanUserResizeRows
        {
            get
            {
                return grid.CanUserResizeRows;
            }
            set
            {
                grid.CanUserResizeRows = value;
            }
        }

        public bool CanUserAddRows
        {
            get
            {
                return grid.CanUserAddRows;
            }
            set
            {
                grid.CanUserAddRows = value;
            }
        }

        public bool CanUserRemoveRows
        {
            get
            {
                return grid.CanUserRemoveRows;
            }
            set
            {
                grid.CanUserRemoveRows = value;
            }
        }

        public bool CanUserEditRows
        {
            get
            {
                return grid.CanUserEditRows;
            }
            set
            {
                grid.CanUserEditRows = value;
            }
        }

        public int FrozenColumnCount
        {
            get
            {
                return grid.FrozenColumnCount;
            }
            set
            {
                grid.FrozenColumnCount = value;
            }
        }

        public C1.WPF.DataGrid.DataGridSelectionMode SelectionMode
        {
            get
            {
                return grid.SelectionMode;
            }
            set
            {
                grid.SelectionMode = value;
            }
        }
        #endregion
    }
}
