using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenController : MonoBehaviour
{
    public GameObject componentCanvas, componentBoard, boardCanvas, board, botCanvas, bot, componentButton, boardButton, robotController;
    // Start is called before the first frame update
    public Animator camAnim;
    public AudioSource buttonPush;
    void Start()
    {
        camAnim = Camera.main.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScreen(string screen){
        Instantiate(buttonPush);
        if(screen == "Component"){
            robotController.GetComponent<RobotController>().screenX = 0;
            componentButton.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = new Color(255, 0, 0, 0);
            if(GameObject.Find("Materials Controller").GetComponent<MaterialController>().unitInHand){
                GameObject.Find("Materials Controller").GetComponent<MaterialController>().unitInHand = false;
                Destroy(GameObject.Find("Materials Controller").GetComponent<MaterialController>().currentGhost);
            }
            componentCanvas.SetActive(true);
            boardCanvas.SetActive(false);
            botCanvas.SetActive(false);
            componentBoard.SetActive(true);
            board.SetActive(false);
            bot.SetActive(false);
            GameObject.Find("Materials Controller").GetComponent<MaterialController>().screen = 0;
            Camera.main.transform.position = new Vector3(0, 0, -10);
        }
        if(screen == "Board"){
            robotController.GetComponent<RobotController>().screenX = 1000;
            boardButton.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = new Color(255, 0, 0, 0);
            componentCanvas.SetActive(false);
            boardCanvas.SetActive(true);
            botCanvas.SetActive(false);
            componentBoard.SetActive(false);
            board.SetActive(true);
            bot.SetActive(false);
            if(GameObject.Find("Materials Controller").GetComponent<MaterialController>().unitInHand){
                Destroy(GameObject.Find("Materials Controller").GetComponent<MaterialController>().currentGhost);                
                GameObject.Find("Materials Controller").GetComponent<MaterialController>().unitInHand = false;
            }
            GameObject.Find("Materials Controller").GetComponent<MaterialController>().screen = 1;
            Camera.main.transform.position = new Vector3(1000, 0, -10);
        }
        if(screen == "Bot"){
            robotController.GetComponent<RobotController>().screenX = 2000;
            componentCanvas.SetActive(false);
            boardCanvas.SetActive(false);
            botCanvas.SetActive(true);
            componentBoard.SetActive(false);
            board.SetActive(false);
            bot.SetActive(true);
            if(GameObject.Find("Materials Controller").GetComponent<MaterialController>().unitInHand){
                GameObject.Find("Materials Controller").GetComponent<MaterialController>().unitInHand = false;
                Destroy(GameObject.Find("Materials Controller").GetComponent<MaterialController>().currentGhost);
            }
            GameObject.Find("Materials Controller").GetComponent<MaterialController>().screen = 2;
            Camera.main.transform.position = new Vector3(2000, 0, -10);
        }
        camAnim.SetTrigger("shake");
    }
}
