using Faker.Globals;
using UnityEngine;

namespace Faker.Human
{
	public class HumanController : ObjectController
	{
		private HumanInfo info;

		protected override void OnInit(object _info)
		{
			if (!_info.GetType().Equals(typeof(HumanInfo))) {
				Debug.Log($"Invalid Init Info.");
				Release();
				return;
			}
			info = (HumanInfo)_info;
			transform.position = info.initPos;
		}

		protected override void OnRelease()
		{
		}
	}
}