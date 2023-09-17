using UnityEngine;

namespace Faker.UI
{
	public class ContentController : MonoBehaviour
	{
		public ContentEnum contentKey = ContentEnum.Unset;
		public bool isActive {
			get {
				return gameObject.activeSelf;
			}
			set {
				gameObject.SetActive(value);
			}
		}

		private void Awake()
		{
			if (contentKey == ContentEnum.Unset) {
				Destroy(gameObject);
			}
		}
	}
}
