using UnityEngine;

namespace Faker.UI
{

public class ButtonManager : MonoBehaviour
{

    [SerializeField]
    private Transform scrollViewContent_class;
    [SerializeField]
    private Transform scrollViewContent_item;
    [SerializeField]
    private Transform buttonTemplate;

    public int classBtnCount = 4;
    public int itemBtnCount=5;
    
    void Start()
    {
      ActiveScrollViewContent_class();
    }

    void ActiveScrollViewContent_class()
    {
      for (int i = 0; i < classBtnCount; i++){
        Transform button = Instantiate(buttonTemplate,scrollViewContent_class.transform);
        int btnId = i;
        button.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(() => ActiveScrollViewContent_item(btnId));
      }
    }

    void ActiveScrollViewContent_item(int classId)
    { 
      scrollViewContent_class.gameObject.SetActive(false);
      for (int i = 0; i < itemBtnCount; i++){
        Instantiate(buttonTemplate,scrollViewContent_item);
      }
    }
}

}

