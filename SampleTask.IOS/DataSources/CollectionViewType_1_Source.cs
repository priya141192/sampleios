using System;
using System.Collections.Generic;
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
                    CustomerAge = "29",
                    TestName = "Dr. qwerty",
                    TestMon = "qwertyuio",
                    TestImage = "https://cdn.pixabay.com/photo/2018/08/28/13/29/avatar-3637561__480.png",
                    Days = "26 Days ago",


                },
                new CustomerDto
                {
                    CustomerName = "Priya",
                    CustomerAge = "29",
                    TestName = "Dr. AbcdEf",
                    TestMon = "asdfghjkl",
                    TestImage = "https://cdn.pixabay.com/photo/2018/08/28/13/29/avatar-3637561__480.png",
                    Days = "1 year ago"
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
            var entity = CustomerList[indexPath.Row];
            cell.UpdateCell(entity);
            return cell;
        }
    }
}
