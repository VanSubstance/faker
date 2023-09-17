using UnityEngine;
using System.Collections;

namespace Faker.Globals
{
	public class MainCameraMover : MonoBehaviour
	{
		private Vector3? posDragStart, posDragIng;
		private Vector3 dirMove;

		private void Update()
		{
			if (Input.GetMouseButtonDown(0)) {
				posDragStart = Camera.main.WorldToViewportPoint(Input.mousePosition);
			}

			if (posDragStart != null) {
				if (Input.GetMouseButton(0)) {
					posDragIng = Camera.main.WorldToViewportPoint(Input.mousePosition);
					Move();
				} else {
					posDragStart = null;
					posDragIng = null;
				}
			}
		}

		private void Move()
		{
			dirMove = (Vector3)(posDragIng - posDragStart);
			dirMove.y = 0;
			dirMove.z = -dirMove.z;
			dirMove /= 10;
			float curLeng;
			if ((curLeng = dirMove.magnitude) > 5f) {
				dirMove *= 5f / curLeng;
			}
			transform.Translate(dirMove * 2 * Time.deltaTime);
		}
	}
}
