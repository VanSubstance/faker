using UnityEngine;
using Faker.UI.Button;

namespace Faker.UI.PCT
{
	public class PCTHeadButtonController : ButtonController
	{
		[SerializeField]
		private PCTEnum contentKey;

		private new void Awake()
		{
			base.Awake();
			GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => {
				PCTManager.Instance.Open(contentKey);
			});
		}
	}
}
