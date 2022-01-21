﻿using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace SampleTask.IOS.Delegates
{
    public class MainDashboardCollectionViewLayout : UICollectionViewDelegateFlowLayout
    {
        //public IOnTutorialPageScroll OnTutorialPageScrollDelegate;
        public MainDashboardCollectionViewLayout()
        {
        }
        public override CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            var collectionSize = collectionView.Frame.Size;
            return new CGSize(collectionSize.Width - 4, collectionSize.Height);
        }
        public override nfloat GetMinimumLineSpacingForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section)
        {
            return 4;
        }

        public override UIEdgeInsets GetInsetForSection(UICollectionView collectionView, UICollectionViewLayout layout, nint section)
        {
            return new UIEdgeInsets(top: 0, left: 2, bottom: 0, right: 2);
        }

    }
}
