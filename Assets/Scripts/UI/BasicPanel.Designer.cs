using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace Qframework.UIExample
{
	// Generate Id:90de74f3-deac-4c60-8c77-6e5b8060f709
	public partial class BasicPanel
	{
		public const string Name = "BasicPanel";
		
		[SerializeField]
		public UnityEngine.UI.Button Btn;
		
		private BasicPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			Btn = null;
			
			mData = null;
		}
		
		public BasicPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		BasicPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new BasicPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
