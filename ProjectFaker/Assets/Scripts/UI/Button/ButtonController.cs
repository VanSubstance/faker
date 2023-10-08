using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Faker.UI.Button
{
	[RequireComponent(typeof(UnityEngine.UI.Button))]
	public class ButtonController : MonoBehaviour
	{
		[SerializeField]
		private string text;
		[SerializeField]
		private Sprite sprite;
		[SerializeField]
		private TextMeshProUGUI tmp;
		[SerializeField]
		private Image img;

		private UnityEngine.UI.Button btn {
			get {
				return GetComponent<UnityEngine.UI.Button>();
			}
		}

		protected void Awake()
		{
			tmp.text = text;
			img.sprite = sprite;
		}

		public void AddClickEvent(UnityAction actionToAdd)
		{
			btn.onClick.AddListener(actionToAdd);
		}
	}
}
