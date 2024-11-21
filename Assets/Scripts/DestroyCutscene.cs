using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyCutscene : MonoBehaviour
{
    public double timeGoal;
    double currentTime;
    public GameObject nextScene;
    public GameObject componentCanvas, componentBuilder, mainCanvas;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= timeGoal){
            if(nextScene != null){
                Instantiate(nextScene);
            }
            if(name == "CutsceneBackground"){
                componentCanvas.SetActive(true);
                componentBuilder.SetActive(true);
                mainCanvas.SetActive(true);
            }
            if(this.tag == "EndScene"){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            Destroy(gameObject);
        }
    }
}
