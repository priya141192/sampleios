using System;
using System.Collections.Generic;
using Foundation;
using SampleTask.IOS.Cells;
using UIKit;

namespace SampleTask.IOS.DataSources
{
    public class MainDashboardDataSource : UITableViewSource
    {
        List<EmployeeModel> students;
        public MainDashboardDataSource(List<EmployeeModel> students)
        {
            this.students = students;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (MainDashboardViewCell)tableView.DequeueReusableCell("dashboardCell", indexPath);
            var student = students[indexPath.Row];
            cell.UpdateCell(student);
            return cell;
        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return students.Count;
        }


    }
}
