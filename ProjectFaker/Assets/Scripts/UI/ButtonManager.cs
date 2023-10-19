//using System.Collections;
//using System.Collections.Generic;
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
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < btnCount; i++){
            //Transform btn = (Transform)Instantiate(buttonTemplate,scrollViewContent.transform);
            Instantiate(buttonTemplate,scrollViewContent.transform);
        }
        
    }
}

}

