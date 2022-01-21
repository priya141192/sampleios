using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using SampleTask.IOS.Cells;
using SampleTask.IOS.DataSources;
using SampleTask.IOS.Delegates;
using SampleTask.IOS.Dto;
using UIKit;

namespace SampleTask.IOS.Views
{
    public partial class DashboardViewController : UIViewController, IUICollectionViewDelegate
    {
        UICollectionViewDiffableDataSource<MainDashboardSections, NSNumber> dataSource;
        UICollectionView collectionView;
		List<DashboardEntityDto> employees = new List<DashboardEntityDto>();
		public List<CustomerDto> CustomerList { get; set; } = new List<CustomerDto>();
		public List<DoctorDto> DoctorList { get; set; } = new List<DoctorDto>();
		public DashboardViewController() : base("DashboardViewController", null)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ConfigureHierarchy();
            ConfigureDataSource();
        }

		UICollectionViewLayout CreateLayout()
		{
			return new UICollectionViewCompositionalLayout(SectionProviderHandler);

			NSCollectionLayoutSection SectionProviderHandler(nint sectionIndex, INSCollectionLayoutEnvironment layoutEnvironment)
			{
				var maindashboardsection = MainDashboardSections.GetSection(sectionIndex);

				if (maindashboardsection == MainDashboardSections.Unknown)
					return null;

				var columns = maindashboardsection.GetDashboardColumnCount();

				// The `group` auto-calculates the actual item width to make
				// the requested number of `columns` fit, so this `widthDimension` will be ignored.
				var itemSize = NSCollectionLayoutSize.Create(NSCollectionLayoutDimension.CreateFractionalWidth(1),
					NSCollectionLayoutDimension.CreateFractionalHeight(1));
				var item = NSCollectionLayoutItem.Create(itemSize);
				item.ContentInsets = new NSDirectionalEdgeInsets(2, 2, 2, 2);

				var groupHeight = columns == 1 ? NSCollectionLayoutDimension.CreateAbsolute(44) : NSCollectionLayoutDimension.CreateFractionalWidth(.2f);
				var groupSize = NSCollectionLayoutSize.Create(NSCollectionLayoutDimension.CreateFractionalWidth(1), groupHeight);
				var group = NSCollectionLayoutGroup.CreateHorizontal(groupSize, item, columns);

				var section = NSCollectionLayoutSection.Create(group);
				section.ContentInsets = new NSDirectionalEdgeInsets(20, 20, 20, 20);
				return section;
			}
		}

		void ConfigureHierarchy()
		{
			collectionView = new UICollectionView(View.Bounds, CreateLayout())
			{
				AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight,
				BackgroundColor = UIColor.SystemBackgroundColor,
				Delegate = this
			};
			collectionView.RegisterClassForCell(typeof(CollectionViewCellType_1), "CellType1");
			collectionView.RegisterClassForCell(typeof(CollectionViewCellType_2), "CellType2");
			View.AddSubview(collectionView);
		}

		void ConfigureDataSource()
		{
			dataSource = new UICollectionViewDiffableDataSource<MainDashboardSections, NSNumber>(collectionView, CellProviderHandler);
            // initial data
            CustomerList = new List<CustomerDto>
            {
                new CustomerDto
                {
                    CustomerName = "Rohit",
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
                    CustomerName = "Priya",
                    CustomerAge = "29 Years",
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
                    DocName = "Dr. Rohit",
                    Department = "Pyschology",
                    Category = "NON-MEDICAL-SPECIALIST",
                    Reviews = "5 reviews",
                    CellType = CellType.Doctor
                },
                new DoctorDto
                {
                    DocName = "Dr. Priya",
                    Department = "Oral Surgery",
                    Category = "SPECIALIST",
                    Reviews = "7 reviews",
                    CellType = CellType.Doctor
                },
            };

            employees = new List<DashboardEntityDto>
            {
                new DashboardEntityDto
                {
                    HeaderText = "Our Happy Customers",Option = "",IsOptionVisible=false,ContentType = CellType.Customer,CustomerList = CustomerList
                },
                new DashboardEntityDto
                {
                    HeaderText = "Doctors Accepting MidGulf Insurance",Option = "",IsOptionVisible=true,ContentType = CellType.Doctor,DoctorList = DoctorList
                }
            };
            //var itemsPerSection = 10;
			var snapshot = new NSDiffableDataSourceSnapshot<MainDashboardSections, NSNumber>();

			foreach (var section in MainDashboardSections.AllMainDashboardSections)
			{
				snapshot.AppendSections(new[] { section });

				var itemOffset = section.EnumVal * employees.Count;
				var items = Enumerable.Range(itemOffset, employees.Count).Select(i => NSNumber.FromInt32(i)).ToArray();
				snapshot.AppendItems(items);
			}
			dataSource.ApplySnapshot(snapshot, false);

			UICollectionViewCell CellProviderHandler(UICollectionView collectionView, NSIndexPath indexPath, NSObject obj)
			{
				var id = (obj as NSNumber).Int32Value;
				var section = MainDashboardSections.GetSection(indexPath.Section);

				if (section == MainDashboardSections.CustomerList)
				{
					// Get a cell of the desired kind.
					var cell = collectionView.DequeueReusableCell("CellType1", indexPath) as CollectionViewCellType_1;

					// Populate the cell with our item description.
					//cell.Label.Text = id.ToString();

					// Return the cell.
					return cell;
				}
				else
				{
					// Get a cell of the desired kind.
					var cell = collectionView.DequeueReusableCell("CellType2", indexPath) as CollectionViewCellType_2;

					// Populate the cell with our item description.
					//cell.Label.Text = id.ToString();
					//cell.ContentView.BackgroundColor = UIColorExtensions.CornflowerBlue;
					//cell.ContentView.Layer.CornerRadius = section == SectionLayoutKind.Grid5 ? 8 : 0;
					//cell.ContentView.Layer.BorderColor = UIColor.Black.CGColor;
					//cell.ContentView.Layer.BorderWidth = 1;
					//cell.Label.TextAlignment = UITextAlignment.Center;
					//cell.Label.Font = UIFont.GetPreferredFontForTextStyle(UIFontTextStyle.Title1);

					// Return the cell.
					return cell;
				}
			}
		}

		#region UICollectionView Delegate

		[Export("collectionView:didSelectItemAtIndexPath:")]
		public void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
			=> collectionView.DeselectItem(indexPath, true);

		#endregion


		public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

