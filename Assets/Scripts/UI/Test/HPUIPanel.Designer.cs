using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace Qframework.UIExample
{
	// Generate Id:41c60eda-ed52-4f8e-8c8b-7d3690414e76
	public partial class HPUIPanel
	{
		public const string Name = "HPUIPanel";
		
		[SerializeField]
		public UnityEngine.UI.Image Image;
		[SerializeField]
		public UnityEngine.UI.Text HP;
		
		private HPUIPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			Image = null;
			HP = null;
			
			mData = null;
		}
		
		public HPUIPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		HPUIPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new HPUIPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
