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
        public DashboardEntityDto entityDto { get; set; }
        CustomerDto customer_cell_type = new CustomerDto();
        DoctorDto doctor_cell_type = new DoctorDto();
        #endregion

        #region Constructors
        public CollectionViewType_1_Source()
        {
        }

        public CollectionViewType_1_Source(DashboardEntityDto dashboardEntity)
        {
            entityDto = dashboardEntity;
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
            if (entityDto.CustomerList != null && entityDto.CustomerList.Count > 0)
            {
                return entityDto.CustomerList.Count;
            }
            if (entityDto.DoctorList != null && entityDto.DoctorList.Count > 0)
            {
                return entityDto.DoctorList.Count;
            }
            return 4;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var customer_cell = collectionView.DequeueReusableCell("CellType1", indexPath) as CollectionViewCellType_1;
            var doctor_cell = collectionView.DequeueReusableCell("CellType2", indexPath) as CollectionViewCellType_2;
            customer_cell.Layer.BorderWidth = 1.0f;
            customer_cell.Layer.BorderColor = UIColor.LightGray.CGColor;
            customer_cell.Layer.MasksToBounds = true;
            customer_cell.Layer.CornerRadius = 10;

            
            if (entityDto.CustomerList != null && entityDto.CustomerList.Count > 0)
            {
                customer_cell_type = entityDto.CustomerList[indexPath.Row];
            }
            if(entityDto.DoctorList != null && entityDto.DoctorList.Count > 0)
            {
                doctor_cell_type = entityDto.DoctorList[indexPath.Row];
            }
            
            if(entityDto.ContentType == CellType.Customer)
            {
                customer_cell.UpdateCell(customer_cell_type);
                return customer_cell;
            }
            else if (entityDto.ContentType == CellType.Doctor)
            {
                doctor_cell.UpdateCell(doctor_cell_type);
                return doctor_cell;
            }

            return customer_cell;
        }
    }
}
