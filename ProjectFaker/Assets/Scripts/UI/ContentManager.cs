using System.Linq;
using Faker.Globals;

namespace Faker.UI
{
	public class ContentManager : SingletonObject<ContentManager>
	{
		private ContentController[] contents;

		private void Awake()
		{
			contents = transform.GetComponentsInChildren<ContentController>();
			contents.All((cont) => {
				cont.isActive = false;
				return true;
			});
		}

		public void Open(ContentEnum targetKey)
		{
			contents.All((cont) => {
				cont.isActive = cont.contentKey.Equals(targetKey);
				return true;
			});
		}
	}
}