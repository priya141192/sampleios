using System;
using System.Collections.Generic;
using CoreGraphics;
using Foundation;
using SampleTask.IOS.Cells;
using SampleTask.IOS.Dto;
using SampleTask.IOS.Views;
using UIKit;

namespace SampleTask.IOS.DataSources
{
    public class CollectionViewType_1_Source : UICollectionViewSource
    {
        private MainDashboardCollectionView mainDashboardCollectionView;
        #region Computed Properties
        public MainDashboardCollectionView CollectionView { get; set; }
        public List<CustomerDto> CustomerList { get; set; } = new List<CustomerDto>();
        #endregion

        #region Constructors
        public CollectionViewType_1_Source()
        {
            CustomerList = new List<CustomerDto>
            {
                new CustomerDto
                {
                    CustomerName = "Rohit",
                    CustomerAge = "29 Years",
                    TestName = "Dr. Nada Nada",
                    TestMon = "Test",
                    Days = "26 Days ago",
                    TestCategory = "Internal Medicine",
                    TestReviews = "401 Reviews",


                },
                new CustomerDto
                {
                    CustomerName = "Priya",
                    CustomerAge = "29 Years",
                    TestName = "Dr. Mohammed Arif",
                    TestMon = "asdfghjkl qwertyui qwertyui",
                    Days = "1 year ago",
                    TestCategory = "Ayurved Medicine",
                    TestReviews = "800 Reviews",

                },
            };

        }

        public CollectionViewType_1_Source(MainDashboardCollectionView mainDashboardCollectionView)
        {
            this.mainDashboardCollectionView = mainDashboardCollectionView;
        }
        #endregion
        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return CustomerList.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = collectionView.DequeueReusableCell("CellType1", indexPath) as CollectionViewCellType_1;
            cell.Layer.BorderWidth = 1.0f;
            cell.Layer.BorderColor = UIColor.LightGray.CGColor;
            cell.Layer.MasksToBounds = true;
            cell.Layer.CornerRadius = 10;
            var entity = CustomerList[indexPath.Row];
            cell.UpdateCell(entity);
            return cell;
        }
    }
}
