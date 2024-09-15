using UnityEngine;
using QFramework;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace QFramework.RollABall
{
	public partial class Player : ViewController
	{
		private Rigidbody mRigidbody;
		void Start()
		{
			mRigidbody = GetComponent<Rigidbody>();
		}

        private void Update()
        {
            // Get Input
            float moveHorizontal = Input.GetAxis("Horizontal");
			float moveVertical = Input.GetAxis("Vertical");

			mRigidbody.AddForce(new Vector3(moveHorizontal, 0, moveVertical));
		}

		private void OnTriggerEnter(Collider other)
        {
            //hide other if name start with Cube
			if (other.gameObject.name.StartsWith("Cube"))
            {
                other.Hide();
            }
        }
    }
}
