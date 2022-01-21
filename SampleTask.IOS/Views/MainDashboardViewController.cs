using System;
using System.Collections.Generic;
using Foundation;
using SampleTask.IOS.DataSources;
using SampleTask.IOS.Dto;
using UIKit;

namespace SampleTask.IOS.Views
{
    public partial class MainDashboardViewController : UIViewController
    {
        List<DashboardEntityDto>  employees = new List<DashboardEntityDto>();
        public List<CustomerDto> CustomerList { get; set; } = new List<CustomerDto>();
        public List<DoctorDto> DoctorList { get; set; } = new List<DoctorDto>();
        public MainDashboardViewController() : base("MainDashboardViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            CustomerList = new List<CustomerDto>
            {
                new CustomerDto
                {
                    CustomerName = "Rohit",
                    CustomerAge = "29 Years",
                    TestName = "qwertyuio",
                    TestMon = "qwertyui",
                    Days = "wertyui",
                    TestCategory = "sdfgyhuji",
                    TestReviews = "dsfdgfhgjh",
                    CellType = CellType.Customer

                },
                new CustomerDto
                {
                    CustomerName = "Priya",
                    CustomerAge = "29 Years",
                    TestName = "sdfghjk",
                    TestMon = "sdfghjkl",
                    Days = "asrtyuertyui",
                    TestCategory = "sdfghghjk",
                    TestReviews = "dfguiertyuis",
                    CellType = CellType.Customer
                },
            };

            DoctorList = new List<DoctorDto>
            {
                new DoctorDto
                {
                    DocName = "Rohit",
                    Department = "wdfghjksdfghj",
                    Category = "wertyuioduirtyuio",
                    Reviews = "3wdrftgyhuijosedrftgyuhij",
                    CellType = CellType.Doctor
                },
                new DoctorDto
                {
                    DocName = "Priya",
                    Department = "wertyuiertyuio",
                    Category = "asdfghj",
                    Reviews = "ertyuiertyuio",
                    CellType = CellType.Doctor
                },
                new DoctorDto
                {
                    DocName = "Priya",
                    Department = "wertyuiertyuio",
                    Category = "asdfghj",
                    Reviews = "ertyuiertyuio",
                    CellType = CellType.Doctor
                },
                new DoctorDto
                {
                    DocName = "Priya",
                    Department = "wertyuiertyuio",
                    Category = "asdfghj",
                    Reviews = "ertyuiertyuio",
                    CellType = CellType.Doctor
                },
                new DoctorDto
                {
                    DocName = "Priya",
                    Department = "wertyuiertyuio",
                    Category = "asdfghj",
                    Reviews = "ertyuiertyuio",
                    CellType = CellType.Doctor
                },
                new DoctorDto
                {
                    DocName = "Priya",
                    Department = "wertyuiertyuio",
                    Category = "asdfghj",
                    Reviews = "ertyuiertyuio",
                    CellType = CellType.Doctor
                },
            };

            employees = new List<DashboardEntityDto>
            {
                new DashboardEntityDto
                {
                    HeaderText = "qwertyui",Option = "",IsOptionVisible=false,ContentType = CellType.Customer,CustomerList = CustomerList
                },
                new DashboardEntityDto
                {
                    HeaderText = "dfghjkl;",Option = "",IsOptionVisible=true,ContentType = CellType.Doctor,DoctorList = DoctorList
                }
            };
            maindashboardtable.RegisterNibForCellReuse(UINib.FromName("MainDashboardViewCell", null), "dashboardCell");
            maindashboardtable.Source = new MainDashboardDataSource(employees);
            maindashboardtable.ContentInset = new UIEdgeInsets(40, 0, 0, 0);
            //maindashboardtable.EstimatedRowHeight = 500f;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            // Initialize table
            maindashboardtable.Source = new MainDashboardDataSource(employees);
            //maindashboardtable.Delegate = new GrowRowTableDelegate();
            maindashboardtable.RowHeight = UITableView.AutomaticDimension;
            maindashboardtable.EstimatedRowHeight = 50f;
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

