using UnityEngine;
using System.Collections;

namespace Faker.UI
{
	public class ShardManager : MonoBehaviour
	{
		[SerializeField]
		private Transform touchStart, touchIng;

		public void TouchStart(Vector3 pos)
		{
			touchStart.position = pos;
			touchStart.localPosition = new Vector3(
				touchStart.localPosition.x,
				touchStart.localPosition.y,
				0
				);
			touchStart.gameObject.SetActive(true);
		}

		public void TouchIng(Vector3 pos)
		{
			touchIng.position = pos;
			touchIng.localPosition = new Vector3(
				touchIng.localPosition.x,
				touchIng.localPosition.y,
				0
				);
			touchIng.gameObject.SetActive(true);
		}

		public Vector3 TouchGetDirection()
		{
			return touchIng.position - touchStart.position;
		}

		public void TouchEnd()
		{
			touchStart.gameObject.SetActive(false);
			touchIng.gameObject.SetActive(false);
		}
	}
}
