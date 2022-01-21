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
        public MainDashboardDataSource(List<DashboardEntityDto> _entity)
        {
            Entity = _entity;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (MainDashboardViewCell)tableView.DequeueReusableCell("dashboardCell", indexPath);
            var entity = Entity[indexPath.Row];
            if (entity.ContentType == CellType.Customer)
            {
                cell.UpdateCell(entity);
            }
            else if (entity.ContentType == CellType.Doctor)
            {
                cell.UpdateDoctorCell(entity);
            }

            return cell;
        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Entity.Count;
        }
    }
}
