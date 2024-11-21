using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDeactivator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Materials Controller").GetComponent<MaterialController>().unitInHand){
            this.GetComponent<Button>().interactable = false;
        } else {
            this.GetComponent<Button>().interactable = true;
        }
    }
}
