using UnityEngine;
using Faker.UI.PCT;

namespace Faker.UI.Button
{
	public class FooterButtonController : ButtonController
	{
		[SerializeField]
		private PCTEnum contentKey;

		private new void Awake()
		{
			base.Awake();
			AddClickEvent(() => {
				PCTManager.Instance.Open(contentKey);
			});
		}
	}
}
