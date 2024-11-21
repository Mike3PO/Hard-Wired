using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    double timeGoal;
    double currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        timeGoal = 5;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= timeGoal){
            Destroy(gameObject);
        }
    }
}
