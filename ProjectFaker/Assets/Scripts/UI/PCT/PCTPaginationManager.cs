using UnityEngine;
using System.Collections.Generic;
using Faker.UI.Button;

namespace Faker.UI.PCT
{
	public class PCTPaginationManager : MonoBehaviour
	{
		[SerializeField]
		private Pair[] pairs;
		private Dictionary<string, Transform> pages;
		private string pageDefault;

		private void Awake()
		{
			pageDefault = string.Empty;
			pages = new Dictionary<string, Transform>();
			foreach (Pair pair in pairs) {
				if (pageDefault.Equals(string.Empty)) pageDefault = pair.targetPage.name;
				pages[pair.targetPage.name] = pair.targetPage;
				pair.button.AddClickEvent(() => {
					Open(pair.targetPage.name);
				});
			}
		}

		private void Open(string targetName)
		{
			foreach(KeyValuePair<string, Transform> page in pages) {
				if (page.Key.Equals(targetName)) {
					page.Value.gameObject.SetActive(true);
				} else {
					page.Value.gameObject.SetActive(false);
				}
			}
		}

		private void OnDisable()
		{
			Open(pageDefault);
		}

		[System.Serializable]
		public class Pair
		{
			public Transform targetPage;
			public ButtonController button;
		}
	}

}