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
		UIKit.UILabel lblCustAge { get; set; }

		[Outlet]
		UIKit.UILabel lblCustName { get; set; }

		[Outlet]
		UIKit.UILabel lblTestmon { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblTestmon != null) {
				lblTestmon.Dispose ();
				lblTestmon = null;
			}

			if (lblCustName != null) {
				lblCustName.Dispose ();
				lblCustName = null;
			}

			if (lblCustAge != null) {
				lblCustAge.Dispose ();
				lblCustAge = null;
			}
		}
	}
}
