using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace SampleTask.IOS.Cells
{
    public partial class DashboardCollectionViewCell : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("DashboardCollectionViewCell");
        public static readonly UINib Nib;
        UIImageView imageView;

        static DashboardCollectionViewCell()
        {
            Nib = UINib.FromName("DashboardCollectionViewCell", NSBundle.MainBundle);
        }
        public DashboardCollectionViewCell(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithFrame:")]
        public DashboardCollectionViewCell(CGRect frame) : base(frame)
        {
            //BackgroundView = new UIView { BackgroundColor = UIColor.Orange };

            //SelectedBackgroundView = new UIView { BackgroundColor = UIColor.Green };

            //ContentView.Layer.BorderColor = UIColor.LightGray.CGColor;
            //ContentView.Layer.BorderWidth = 2.0f;
            //ContentView.BackgroundColor = UIColor.White;
            //ContentView.Transform = CGAffineTransform.MakeScale(0.8f, 0.8f);

            //imageView = new UIImageView(UIImage.FromBundle("placeholder.png"));
            //imageView.Center = ContentView.Center;
            //imageView.Transform = CGAffineTransform.MakeScale(0.7f, 0.7f);

            //ContentView.AddSubview(imageView);
        }

        public UIImage Image
        {
            set
            {
                imageView.Image = value;
            }
        }
    }
}
