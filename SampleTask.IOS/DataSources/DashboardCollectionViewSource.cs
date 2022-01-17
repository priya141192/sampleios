using System;
using System.Collections.Generic;
using Foundation;
using SampleTask.IOS.Cells;
using SampleTask.IOS.Views;
using UIKit;

namespace SampleTask.IOS.DataSources
{
    public class DashboardCollectionViewSource : UICollectionViewDataSource
    {
        #region Computed Properties
        public DashboardCollectionView CollectionView { get; set; }
        public List<int> Numbers { get; set; } = new List<int>();
        #endregion

        #region Constructors
        public DashboardCollectionViewSource(DashboardCollectionView collectionView)
        {
            // Initialize
            CollectionView = collectionView;

            // Init numbers collection
            for (int n = 0; n < 20; ++n)
            {
                Numbers.Add(n);
            }
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
            return Numbers.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = collectionView.DequeueReusableCell("Cell", indexPath) as DashboardCollectionViewCell;
            //cell.Title = Numbers[(int)indexPath.Item].ToString();

            return cell;
        }
    }

}