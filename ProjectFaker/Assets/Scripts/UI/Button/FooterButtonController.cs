using UnityEngine;

namespace Faker.UI.Button
{
	public class FooterButtonController : ButtonController
	{
		[SerializeField]
		private ContentEnum contentKey;

		private new void Awake()
		{
			base.Awake();
			GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => {
				ContentManager.Instance.Open(contentKey);
			});
		}
	}
}
