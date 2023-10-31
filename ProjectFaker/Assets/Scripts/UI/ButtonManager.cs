using UnityEngine;

namespace Faker.UI
{

public class ButtonManager : MonoBehaviour
{

    [SerializeField]
    private Transform scrollViewContent;
    [SerializeField]
    private Transform buttonTemplate;

    public int btnCount = 10;
    
    void Start()
    {
      for (int i = 0; i < btnCount; i++){
        Instantiate(buttonTemplate,scrollViewContent.transform);
      }
        
    }
}

}

