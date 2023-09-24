using UnityEngine;

namespace Faker.UI.PCT
{
	public class PCTController : MonoBehaviour
	{
		public PCTEnum contentKey = PCTEnum.Unset;
		public bool isActive {
			get {
				return gameObject.activeSelf;
			}
			set {
				gameObject.SetActive(value);
			}
		}

		protected void Awake()
		{
			if (contentKey == PCTEnum.Unset) {
				Destroy(gameObject);
			}
		}
	}
}
