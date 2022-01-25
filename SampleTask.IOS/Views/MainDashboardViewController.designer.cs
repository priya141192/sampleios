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
	[Register ("MainDashboardViewController")]
	partial class MainDashboardViewController
	{
		[Outlet]
		UIKit.UITableView maindashboardtable { get; set; }

		[Outlet]
		UIKit.UINavigationBar navigationbar { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (maindashboardtable != null) {
				maindashboardtable.Dispose ();
				maindashboardtable = null;
			}

			if (navigationbar != null) {
				navigationbar.Dispose ();
				navigationbar = null;
			}
		}
	}
}
