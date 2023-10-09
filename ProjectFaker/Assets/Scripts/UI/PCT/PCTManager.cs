using System.Linq;

using UnityEngine;

namespace Faker.UI.PCT
{
	public class PCTManager : SingletonObject<PCTManager>
	{
		public PCTEnum CurrentContentActive = PCTEnum.Unset;
		private PCTController[] contents;

		private void Awake()
		{
			contents = transform.GetComponentsInChildren<PCTController>();
			contents.All((cont) => {
				cont.isActive = false;
				return true;
			});
			Open(PCTEnum.Lobby);
		}

		public void Open(PCTEnum targetKey)
		{
			contents.All((cont) => {
				cont.isActive = cont.contentKey.Equals(targetKey);
				return true;
			});
			CurrentContentActive = targetKey;
		}
	}
}