using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace Qframework.UIExample
{
	public class BasicPanelData : UIPanelData
	{
		public int Count;
	}
	public partial class BasicPanel : UIPanel
	{
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as BasicPanelData ?? new BasicPanelData();
            // please add init code here
            UIKit.OpenPanel<BasicPanel>(new BasicPanelData
			{
                Count = 10
			});
			Btn.onClick.AddListener(() =>
			{
				Debug.Log("Good");
			});
		}
		
		protected override void OnOpen(IUIData uiData = null)
		{
		}
		
		protected override void OnShow()
		{
		}
		
		protected override void OnHide()
		{
		}
		
		protected override void OnClose()
		{
		}
	}
}
