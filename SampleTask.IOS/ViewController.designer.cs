// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SampleTask.IOS
{
    [Register("ViewController")]
    partial class ViewController
    {
        UIKit.UICollectionView dashboardCollectionView { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (dashboardCollectionView != null)
            {
                dashboardCollectionView.Dispose();
                dashboardCollectionView = null;
            }
        }
    }
}
