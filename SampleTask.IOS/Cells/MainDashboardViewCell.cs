using System;
using System.Collections.Generic;
using Foundation;
using SampleTask.IOS.DataSources;
using SampleTask.IOS.Delegates;
using SampleTask.IOS.Dto;
using UIKit;

namespace SampleTask.IOS.Cells
{
    public partial class MainDashboardViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("MainDashboardViewCell");
        public static readonly UINib Nib;
        DashboardEntityDto dashboardEntity { get; set; }

        static MainDashboardViewCell()
        {
            Nib = UINib.FromName("MainDashboardViewCell", NSBundle.MainBundle);
        }

        protected MainDashboardViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.

        }

        internal void UpdateCell(DashboardEntityDto entity)
        {
            dashboardEntity = entity;
            lblHeader.Font = UIFont.FromName("Roboto-Bold", 15f);
            lblHeader.Text = entity.HeaderText;
            lblOptions.Font = UIFont.FromName("Roboto-Bold", 12f);
            lblOptions.Text = entity.Option;
            lblHeader.LineBreakMode = UILineBreakMode.WordWrap;
            lblHeader.Lines = 0;
            dashboardcollectioncell.Source = new CollectionViewType_1_Source(dashboardEntity);
            dashboardcollectioncell.Delegate = new MainDashboardCollectionViewLayout();
        }

        internal void UpdateDoctorCell(DashboardEntityDto entity)
        {
            dashboardEntity = entity;
            lblHeader.Font = UIFont.FromName("Roboto-Bold", 15f);
            lblHeader.Text = entity.HeaderText;
            lblOptions.Font = UIFont.FromName("Roboto-Bold", 12f);
            lblOptions.Text = entity.Option;
            lblHeader.LineBreakMode = UILineBreakMode.WordWrap;
            lblHeader.Lines = 0;
            dashboardcollectioncell.Source = new CollectionViewType_1_Source(dashboardEntity);
            dashboardcollectioncell.Delegate = new DoctorViewLayout();
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            dashboardcollectioncell.RegisterNibForCell(UINib.FromName("CollectionViewCellType_1",null), "CellType1");
            dashboardcollectioncell.RegisterNibForCell(UINib.FromName("CollectionViewCellType_2", null), "CellType2");
            
        }
    }
}
