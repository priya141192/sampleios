// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace SampleTask.IOS.Cells
{
	[Register ("CollectionViewCellType_1")]
	partial class CollectionViewCellType_1
	{
		[Outlet]
		UIKit.UIImageView ImgCust { get; set; }

		[Outlet]
		UIKit.UIImageView ImgProfile { get; set; }

		[Outlet]
		UIKit.UILabel lblCategory { get; set; }

		[Outlet]
		UIKit.UILabel lblCustAge { get; set; }

		[Outlet]
		UIKit.UILabel lblCustName { get; set; }

		[Outlet]
		UIKit.UILabel lblDays { get; set; }

		[Outlet]
		UIKit.UILabel lblName { get; set; }

		[Outlet]
		UIKit.UILabel lblReviews { get; set; }

		[Outlet]
		UIKit.UILabel lblTestMon { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ImgCust != null) {
				ImgCust.Dispose ();
				ImgCust = null;
			}

			if (ImgProfile != null) {
				ImgProfile.Dispose ();
				ImgProfile = null;
			}

			if (lblCategory != null) {
				lblCategory.Dispose ();
				lblCategory = null;
			}

			if (lblCustAge != null) {
				lblCustAge.Dispose ();
				lblCustAge = null;
			}

			if (lblCustName != null) {
				lblCustName.Dispose ();
				lblCustName = null;
			}

			if (lblDays != null) {
				lblDays.Dispose ();
				lblDays = null;
			}

			if (lblName != null) {
				lblName.Dispose ();
				lblName = null;
			}

			if (lblReviews != null) {
				lblReviews.Dispose ();
				lblReviews = null;
			}

			if (lblTestMon != null) {
				lblTestMon.Dispose ();
				lblTestMon = null;
			}
		}
	}
}
