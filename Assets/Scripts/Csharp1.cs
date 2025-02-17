using Qframework.UIExample;
using QFramework;
using Unity.VisualScripting;
using UnityEngine;



public class Csharp1 : MonoBehaviour
{
    HPUIPanel ui;
    private void Start()
    {
        ui = UIKit.OpenPanel<HPUIPanel>();
        UIKit.Root.SetResolution(1920, 1080, 0);
    }
    private void Update()
    {
        if (ui != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ui.Data.mHP -= 10;
                ui.HP.text = ui.Data.mHP.ToString();
            }
            if(Input.GetKeyDown(KeyCode.A))
            {
                UIKit.ClosePanel(ui);
            }
        }
    }
}
