using System;
using System.Collections.Generic;
using Foundation;
using SampleTask.IOS.DataSources;
using UIKit;

namespace SampleTask.IOS.Views
{
    public partial class MainDashboardViewController : UIViewController
    {
        List<EmployeeModel>  employees = new List<EmployeeModel>();
        public MainDashboardViewController() : base("MainDashboardViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            employees = new List<EmployeeModel>
            {
                new EmployeeModel
                {
                    header = "A",option = "a",content="aa",
                },
                new EmployeeModel
                {
                    header = "B",option = "b",content="bb",
                }
            };
            maindashboardtable.RegisterNibForCellReuse(UINib.FromName("MainDashboardViewCell", null), "dashboardCell");
            maindashboardtable.Source = new MainDashboardDataSource(employees);
            maindashboardtable.EstimatedRowHeight = 500f;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            // Initialize table
            maindashboardtable.Source = new MainDashboardDataSource(employees);
            //maindashboardtable.Delegate = new GrowRowTableDelegate();
            maindashboardtable.RowHeight = UITableView.AutomaticDimension;
            maindashboardtable.EstimatedRowHeight = 400f;
            maindashboardtable.ReloadData();
        }

        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();
            if (maindashboardtable != null)
                maindashboardtable.Frame = View.Bounds;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

