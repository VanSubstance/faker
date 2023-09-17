using Faker.UI;
using UnityEngine;

namespace Faker.Globals
{
	public class MainCameraMover : MonoBehaviour
	{
		private Vector3? posDragStart, posDragIng;
		private Vector3 dirMove;

		private void Update()
		{
			switch (ContentManager.Instance.CurrentContentActive) {
				case ContentEnum.Deck:
				case ContentEnum.Shop:
					return;
			}
			if (Input.GetMouseButtonDown(0)) {
				posDragStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				UIManager.Instance.Shard.TouchStart((Vector3)posDragStart);
			}

			if (posDragStart != null) {
				if (Input.GetMouseButton(0)) {
					posDragIng = Camera.main.ScreenToWorldPoint(Input.mousePosition);
					UIManager.Instance.Shard.TouchIng((Vector3)posDragIng);
					Move();
				} else {
					UIManager.Instance.Shard.TouchEnd();
					posDragStart = null;
					posDragIng = null;
				}
			}
		}

		private void Move()
		{
			dirMove = UIManager.Instance.Shard.TouchGetDirection();
			dirMove.y = 0;
			float curLeng;
			if ((curLeng = dirMove.magnitude) > 5f) {
				dirMove *= 5f / curLeng;
			}
			transform.Translate(dirMove * 3 * Time.deltaTime);
		}
	}
}
