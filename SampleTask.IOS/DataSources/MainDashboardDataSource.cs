using System;
using System.Collections.Generic;
using Foundation;
using SampleTask.IOS.Cells;
using SampleTask.IOS.Dto;
using UIKit;

namespace SampleTask.IOS.DataSources
{
    public class MainDashboardDataSource : UITableViewSource
    {
        List<DashboardEntityDto> Entity { get; set; }
        MainDashboardViewCell mainDashboardViewCell;
        public MainDashboardDataSource(List<DashboardEntityDto> _entity)
        {
            Entity = _entity;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            mainDashboardViewCell = (MainDashboardViewCell)tableView.DequeueReusableCell("dashboardCell", indexPath);
            var entity = Entity[indexPath.Row];
            GetCellType(entity);
            return mainDashboardViewCell;
        }

        private void GetCellType(DashboardEntityDto entity)
        {
            try
            {
                switch (entity.ContentType)
                {
                    case CellType.Customer:
                        mainDashboardViewCell.UpdateCell(entity);
                        break;
                    case CellType.Doctor:
                         mainDashboardViewCell.UpdateDoctorCell(entity);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Entity.Count;
        }
    }
}
