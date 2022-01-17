using System;
using Foundation;
using SampleTask.IOS.Cells;
using UIKit;

namespace SampleTask.IOS.Views
{
    public partial class DashboardViewController : UIViewController
    {
        public DashboardViewController() : base("DashboardViewController", null)
        {
        }

        public DashboardViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

