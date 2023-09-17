using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Faker.UI
{
	[RequireComponent(typeof(Button))]
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

		private void Awake()
		{
			tmp.text = text;
			img.sprite = sprite;
		}
	}
}
