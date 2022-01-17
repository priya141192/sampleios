// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace SampleTask.IOS.Views
{
	[Register ("DashboardViewController")]
	partial class DashboardViewController
	{
		[Outlet]
		UIKit.UICollectionView dashboardcollectionview { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (dashboardcollectionview != null) {
				dashboardcollectionview.Dispose ();
				dashboardcollectionview = null;
			}
		}
	}
}
