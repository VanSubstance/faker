using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public GameObject scrollViewContent;

    public GameObject buttonTemplate;

    public int btnCount = 10;
    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i < btnCount; i++){
            GameObject btn = (GameObject)Instantiate(buttonTemplate,scrollViewContent.transform);
            //btn.transform.SetParent(scrollViewContent.transform);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
