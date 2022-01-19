using System;

using Foundation;
using SampleTask.IOS.DataSources;
using SampleTask.IOS.Dto;
using UIKit;

namespace SampleTask.IOS.Cells
{
    public partial class MainDashboardViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("MainDashboardViewCell");
        public static readonly UINib Nib;

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
            lblHeader.Font = UIFont.FromName("Roboto-Bold", 15f);
            lblHeader.Text = entity.HeaderText;
            lblOptions.Text = entity.Option;
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            dashboardcollectioncell.RegisterNibForCell(UINib.FromName("CollectionViewCellType_1",null), "CellType1");
            dashboardcollectioncell.Source = new CollectionViewType_1_Source();
        }
    }
}
