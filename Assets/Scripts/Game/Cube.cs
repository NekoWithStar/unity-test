using UnityEngine;
using QFramework;

namespace QFramework.RollABall
{
	public partial class Cube : ViewController
	{
		void Start()
		{
			
		}

        private void Update()
        {
            // Rotate the transform of the game object randomly£¬ into account the time elapsed since the last frame.
			transform.Rotate(new Vector3(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90)) * Time.deltaTime);
		}
    }
}
