using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public GameObject happyEngineerText;
    public GameObject happyEngineer;
    public int start;
    // Start is called before the first frame update
    void Start()
    {
        start = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(start == 0){
            Debug.Log("Started");
            start = 1;
            Instantiate(happyEngineer, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(happyEngineerText, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
