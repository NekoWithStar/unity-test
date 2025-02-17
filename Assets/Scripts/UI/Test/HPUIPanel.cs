using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace Qframework.UIExample
{
	public class HPUIPanelData : UIPanelData
	{
        public float mHP = 100;
    }
	public partial class HPUIPanel : UIPanel
	{
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as HPUIPanelData ?? new HPUIPanelData();
			
			
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
