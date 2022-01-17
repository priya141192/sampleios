using System;
using Foundation;
using SampleTask.IOS.DataSources;
using UIKit;

namespace SampleTask.IOS.Views
{
    [Register("DashboardCollectionView")]
    public class DashboardCollectionView : UICollectionView
	{
		#region Computed Properties
		public CollectionViewType_1_Source Source
		{
			get
			{
				return (CollectionViewType_1_Source)DataSource;
			}
		}
		#endregion

		#region Constructors
		public DashboardCollectionView(IntPtr handle) : base(handle)
		{
		}

        #endregion

        #region Override Methods
        public override void AwakeFromNib()
		{
			base.AwakeFromNib();

			// Initialize
			//DataSource = new CollectionViewType_1_Source(this);
			//Delegate = new WaterfallCollectionDelegate(this);
		}
		#endregion
	}
}
