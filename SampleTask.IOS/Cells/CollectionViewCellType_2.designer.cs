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
	[Register ("CollectionViewCellType_2")]
	partial class CollectionViewCellType_2
	{
		[Outlet]
		UIKit.UIButton btnNext { get; set; }

		[Outlet]
		UIKit.UIImageView ImgDoc { get; set; }

		[Outlet]
		UIKit.UIView labelContainer { get; set; }

		[Outlet]
		UIKit.UILabel lblCategory { get; set; }

		[Outlet]
		UIKit.UILabel lblDepartment { get; set; }

		[Outlet]
		UIKit.UILabel lblName { get; set; }

		[Outlet]
		UIKit.UILabel lblReviews { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnNext != null) {
				btnNext.Dispose ();
				btnNext = null;
			}

			if (ImgDoc != null) {
				ImgDoc.Dispose ();
				ImgDoc = null;
			}

			if (lblCategory != null) {
				lblCategory.Dispose ();
				lblCategory = null;
			}

			if (lblDepartment != null) {
				lblDepartment.Dispose ();
				lblDepartment = null;
			}

			if (lblName != null) {
				lblName.Dispose ();
				lblName = null;
			}

			if (lblReviews != null) {
				lblReviews.Dispose ();
				lblReviews = null;
			}

			if (labelContainer != null) {
				labelContainer.Dispose ();
				labelContainer = null;
			}
		}
	}
}
