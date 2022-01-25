using System;
using Foundation;
using SampleTask.IOS.DataSources;
using SampleTask.IOS.Delegates;
using SampleTask.IOS.Dto;
using SampleTask.IOS.Helper;
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

        public void UpdateData(DashboardEntityDto entity)
        {
            dashboardEntity = entity;
            lblHeader.Font = CommonMethods.GetFontByType(FontManager.FontType.ROBO_FONT_BOLD, FontManager.FontSize.HEADER_LARGE);
            lblOptions.Font = CommonMethods.GetFontByType(FontManager.FontType.ROBO_FONT_REGULAR, FontManager.FontSize.OPTION_LABEL);
            lblHeader.Text = entity.HeaderText;
            lblOptions.Text = entity.Option;
        }

        internal void UpdateCell(DashboardEntityDto entity)
        {
            dashboardEntity = entity;
            UpdateData(entity);
            dashboardcollectioncell.Source = new CollectionViewType_1_Source(dashboardEntity);
            dashboardcollectioncell.Delegate = new CustomerViewLayout();
        }

        internal void UpdateDoctorCell(DashboardEntityDto entity)
        {
            dashboardEntity = entity;
            UpdateData(entity);
            dashboardcollectioncell.Source = new CollectionViewType_1_Source(dashboardEntity);
            dashboardcollectioncell.Delegate = new DoctorViewLayout();
        }


        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            dashboardcollectioncell.RegisterNibForCell(UINib.FromName("CollectionViewCellType_1",null), "CellType1");
            dashboardcollectioncell.RegisterNibForCell(UINib.FromName("CollectionViewCellType_2", null), "CellType2");
            var backgroundView = new UIView();
            backgroundView.BackgroundColor = UIColor.Clear;
            maincontainer = backgroundView;
        }
    }
}
