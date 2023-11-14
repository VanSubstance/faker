using UnityEngine;

namespace Faker.UI
{

public class ButtonManager : MonoBehaviour
{

    [SerializeField]
    private Transform scrollViewContentClass;
    [SerializeField]
    private Transform scrollViewContentItem;
    [SerializeField]
    private UnityEngine.UI.Button buttonTemplate;

    public int ClassBtnCount = 4;
    public int ItemBtnCount=5;
    
    private void Start()
    {
      ActiveScrollViewContentClass();
    }

    private void ActiveScrollViewContentClass()
    {
      for (int i = 0; i < ClassBtnCount; i++)
      {
        UnityEngine.UI.Button button = Instantiate(buttonTemplate, scrollViewContentClass);
        int btnId = i;
        button.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => ActiveScrollViewContentItem(btnId));
      }
    }

    private void ActiveScrollViewContentItem(int classId)
    {
      scrollViewContentClass.gameObject.SetActive(false);
      for (int i = 0; i < ItemBtnCount; i++)
      {
        Instantiate(buttonTemplate, scrollViewContentItem);
      }
    }
}

}

