using System;
using System.Collections.Generic;
using Foundation;
using SampleTask.IOS.Cells;
using SampleTask.IOS.Views;
using UIKit;

namespace SampleTask.IOS.DataSources
{
    public class CollectionViewType_1_Source : UICollectionViewSource
    {
        #region Computed Properties
        public MainDashboardCollectionView CollectionView { get; set; }
        public List<int> Numbers { get; set; } = new List<int>();
        #endregion

        #region Constructors
        //public CollectionViewType_1_Source(MainDashboardCollectionView collectionView)
        //{
        //    // Initialize
        //    CollectionView = collectionView;

        //    // Init numbers collection
        //    for (int n = 0; n < 20; ++n)
        //    {
        //        Numbers.Add(n);
        //    }
        //}

        public CollectionViewType_1_Source()
        {
            //CollectionView = collectionView;

            //// Init numbers collection
            //for (int n = 0; n < 20; ++n)
            //{
            //    Numbers.Add(n);
            //}

           
        }
        #endregion
        public override nint NumberOfSections(UICollectionView collectionView)
        {
            // We only have one section
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            // Return the number of items
            return 5;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = collectionView.DequeueReusableCell("CellType1", indexPath) as CollectionViewCellType_1;

            //cell.Title = Numbers[(int)indexPath.Item].ToString();
            var employees = new EmployeeModel
            {
                header = "A",
                option = "a",
                content = "aa",
            };
            cell.UpdateCell(employees);
            return cell;
        }
    }
}
