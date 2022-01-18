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
	[Register ("MainDashboardViewCell")]
	partial class MainDashboardViewCell
	{
		[Outlet]
		UIKit.UICollectionView dashboardcollectioncell { get; set; }

		[Outlet]
		UIKit.UILabel lblHeader { get; set; }

		[Outlet]
		UIKit.UILabel lblOptions { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (dashboardcollectioncell != null) {
				dashboardcollectioncell.Dispose ();
				dashboardcollectioncell = null;
			}

			if (lblOptions != null) {
				lblOptions.Dispose ();
				lblOptions = null;
			}

			if (lblHeader != null) {
				lblHeader.Dispose ();
				lblHeader = null;
			}
		}
	}
}
