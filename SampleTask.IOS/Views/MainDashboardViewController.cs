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
        List<DashboardEntityDto>  dashboardList = new List<DashboardEntityDto>();
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
                    CustomerName = "Test user1",
                    CustomerAge = "29 Years",
                    TestName = "Dr. Nada Nada",
                    TestMon = "Test",
                    Days = "26 Days ago",
                    TestCategory = "Internal Medicine",
                    TestReviews = "401 Reviews",
                    CellType = CellType.Customer

                },
                new CustomerDto
                {
                    CustomerName = "Test user2",
                    CustomerAge = "30 Years",
                    TestName = "Dr. Mohammed Arif",
                    TestMon = "asdfghjkl qwertyui qwertyui",
                    Days = "13 years ago",
                    TestCategory = "Ayurved Medicine",
                    TestReviews = "800 Reviews",
                    CellType = CellType.Customer
                },
                new CustomerDto
                {
                    CustomerName = "Test user3",
                    CustomerAge = "40 Years",
                    TestName = "Dr. Mohammed Arif",
                    TestMon = "asdfghjkl qwertyui qwertyui",
                    Days = "1 year ago",
                    TestCategory = "Ayurved Medicine",
                    TestReviews = "800 Reviews",
                    CellType = CellType.Customer
                },
            };

            DoctorList = new List<DoctorDto>
            {
                new DoctorDto
                {
                    DocName = "Dr. Zohoor Ahmad Zohoor",
                    Department = "Pyschology",
                    Category = "NON-MEDICAL-SPECIALIST",
                    Reviews = "5 reviews",
                    CellType = CellType.Doctor
                },
                new DoctorDto
                {
                    DocName = "Dr. Anas Mohammad Rasqweqwer qwert",
                    Department = "Oral Surgery",
                    Category = "SPECIALIST",
                    Reviews = "7 reviews",
                    CellType = CellType.Doctor
                },
                new DoctorDto
                {
                    DocName = "Dr. Barakat Mamdooh Ahooruer",
                    Department = "Pyschology",
                    Category = "SPECIALIST",
                    Reviews = "282 reviews",
                    CellType = CellType.Doctor
                },
                new DoctorDto
                {
                    DocName = "Dr. Yousef Tawfik YousefRaq",
                    Department = "Oral Surgery",
                    Category = "SPECIALIST",
                    Reviews = "5 reviews",
                    CellType = CellType.Doctor
                },
                new DoctorDto
                {
                    DocName = "Dr. Safi SAfi",
                    Department = "Family Medicine",
                    Category = "SPECIALIST",
                    Reviews = "5 reviews",
                    CellType = CellType.Doctor
                },
                new DoctorDto
                {
                    DocName = "Dr. Saud Abdullah",
                    Department = "Neurology",
                    Category = "SPECIALIST",
                    Reviews = "7 reviews",
                    CellType = CellType.Doctor
                },
            };

            dashboardList = new List<DashboardEntityDto>
            {
                new DashboardEntityDto
                {
                    HeaderText = "Our Happy Customers",Option = "",IsOptionVisible=false,ContentType = CellType.Customer,CustomerList = CustomerList
                },
                new DashboardEntityDto
                {
                    HeaderText = "Doctors Accepting MidGulf Insurance",Option = "See All",IsOptionVisible=true,ContentType = CellType.Doctor,DoctorList = DoctorList
                }
            };

            maindashboardtable.RegisterNibForCellReuse(UINib.FromName("MainDashboardViewCell", null), "dashboardCell");
            maindashboardtable.Source = new MainDashboardDataSource(dashboardList);
            maindashboardtable.ContentInset = new UIEdgeInsets(40, 0, 0, 0);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            // Initialize table
            maindashboardtable.Source = new MainDashboardDataSource(dashboardList);
            maindashboardtable.RowHeight = UITableView.AutomaticDimension;
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

