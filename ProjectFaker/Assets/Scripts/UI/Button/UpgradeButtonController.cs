using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Faker.UI.Button
{
	[RequireComponent(typeof(UnityEngine.UI.Button))]
	public class UpgradeButtonController : MonoBehaviour
	{
	    [SerializeField]
		private Sprite sprite;
		[SerializeField]
		private string text;
		private int level = 0;
		[SerializeField]
		private TextMeshProUGUI statName;
		[SerializeField]
		private TextMeshProUGUI statValue;
		[SerializeField]
		private Image img;

		private UnityEngine.UI.Button btn {
		get {
		return GetComponent<UnityEngine.UI.Button>();
		}
		}

		protected void Awake()
		{
		statName.text = text;
		statValue.text = "현재 : " + level;
		img.sprite = sprite;
		}

		public void AddClickEvent(UnityAction actionToAdd)
		{
		btn.onClick.AddListener(actionToAdd);
		}

		public void Onclick()
		{
		level += 1;
		statValue.text = "현재 : " + level;
		}
	}
}
