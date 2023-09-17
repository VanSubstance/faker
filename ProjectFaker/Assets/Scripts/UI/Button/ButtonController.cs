using TMPro;
using UnityEngine;
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

		protected void Awake()
		{
			tmp.text = text;
			img.sprite = sprite;
		}
	}
}
