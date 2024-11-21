using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RobotController : MonoBehaviour
{
    public GameObject partController, component, board, endCredits;
    public Animator camAnim;
    public double enemyAttack, enemyDefense, enemyPower;
    public double finalAttack, finalDefense, finalPower;
    public int screenX;
    public GameObject screenController;
    public AudioSource sendRobot;
    public GameObject componentBuilder, boardBuilder, botBuilder, componentCanvas, boardCanvas, botCanvas, mainCanvas;
    // Start is called before the first frame update
    void Start()
    {
        camAnim = Camera.main.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendRobot(){
        Instantiate(sendRobot);
        double attack = partController.GetComponent<PartController>().attack;
        double defense = partController.GetComponent<PartController>().defense;
        double power = partController.GetComponent<PartController>().power;
        int times = Math.Max((int)(power/enemyPower), 1);
        int metalReturn = Math.Max((int)(attack/enemyAttack), 1) * times;
        int wireReturn = Math.Max((int)(defense/enemyDefense), 1) * times;
        partController.GetComponent<PartController>().metal += metalReturn;
        partController.GetComponent<PartController>().wire += wireReturn;
        if(metalReturn > 10){
            partController.GetComponent<PartController>().battery += metalReturn / 10;
            partController.GetComponent<PartController>().motorPower += metalReturn / 10;
            partController.GetComponent<PartController>().health += metalReturn / 10;
            board.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = new Color(255, 0, 0, 255);
        }
        if(wireReturn > 10){
            partController.GetComponent<PartController>().ai += wireReturn / 10;
            partController.GetComponent<PartController>().speed += wireReturn / 10;
            board.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = new Color(255, 0, 0, 255);
        }
        if(attack >= finalAttack && defense >= finalDefense && power >= finalPower){
            componentBuilder.SetActive(false);
            boardBuilder.SetActive(false);
            botBuilder.SetActive(false);
            mainCanvas.SetActive(false);
            componentCanvas.SetActive(false);
            boardCanvas.SetActive(false);
            botCanvas.SetActive(false);
            Instantiate(endCredits, new Vector3(screenX, 0, 0), Quaternion.identity);
            Debug.Log("Instantiated");
        }

        component.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = new Color(255, 0, 0, 255);
        
        camAnim.SetTrigger("shake");

        //Clear Board
        for(int i = 0; i < componentBuilder.transform.childCount; i++){
            if(componentBuilder.transform.GetChild(i).GetComponent<TileController>().unit != null){
            if(componentBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Metal"){
                partController.GetComponent<PartController>().metal++;
            } else if(componentBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Wire"){
                partController.GetComponent<PartController>().wire++;
            }
            
                Destroy(componentBuilder.transform.GetChild(i).GetComponent<TileController>().unit);
            }
            componentBuilder.transform.GetChild(i).GetComponent<TileController>().unit = GameObject.Find("Blank");
        }
        
        for(int i = 0; i < boardBuilder.transform.childCount; i++){
            if(boardBuilder.transform.GetChild(i).GetComponent<TileController>().unit != null){
            if(boardBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Battery"){
                partController.GetComponent<PartController>().battery++;
            } else if(boardBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Motor"){
                partController.GetComponent<PartController>().motorPower++;
            } else if(boardBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Speed"){
                partController.GetComponent<PartController>().speed++;
            } else if(boardBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Health"){
                partController.GetComponent<PartController>().health++;
            } else if(boardBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag == "AI"){
                partController.GetComponent<PartController>().ai++;
            }

            if(boardBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Battery"){
                partController.GetComponent<PartController>().power -= 8;
            } else if(boardBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Motor"){
                partController.GetComponent<PartController>().attack -= 2;
                partController.GetComponent<PartController>().defense -= 2;
            } else if(boardBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Speed"){
                partController.GetComponent<PartController>().power -= 4;
            } else if(boardBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Health"){
                partController.GetComponent<PartController>().defense -= 4;
            } else if(boardBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag == "AI"){
                partController.GetComponent<PartController>().attack -= 4;
            }
            
                Destroy(boardBuilder.transform.GetChild(i).GetComponent<TileController>().unit);
            }
            boardBuilder.transform.GetChild(i).GetComponent<TileController>().unit = GameObject.Find("Blank");
            
        }

        for(int i = 0; i < botBuilder.transform.childCount; i++){
            if(botBuilder.transform.GetChild(i).GetComponent<TileController>().unit != null){
                if(botBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag.Contains("Plate")){
                    partController.GetComponent<PartController>().plates++;
                } else if(botBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag.Contains("Wheel")){
                    partController.GetComponent<PartController>().wheels++;
                } else if(botBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag.Contains("Weapon")){
                    partController.GetComponent<PartController>().weapons++;
                }
                if(botBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag.Contains("Plate")){
                    partController.GetComponent<PartController>().attack -= 25;
                    partController.GetComponent<PartController>().defense -= 50;
                    partController.GetComponent<PartController>().power -= 25;
                } else if(botBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag.Contains("Wheel")){
                    partController.GetComponent<PartController>().attack -= 20;
                    partController.GetComponent<PartController>().defense -= 10;
                    partController.GetComponent<PartController>().power -= 50;
                } else if(botBuilder.transform.GetChild(i).GetComponent<TileController>().unit.tag.Contains("Weapon")){
                    partController.GetComponent<PartController>().attack -= 100;
                }
                Destroy(botBuilder.transform.GetChild(i).GetComponent<TileController>().unit);
            }
            botBuilder.transform.GetChild(i).GetComponent<TileController>().unit = GameObject.Find("Blank");
            
        }
        boardBuilder.GetComponent<BoardBuilderController>().free = 13;
        componentBuilder.GetComponent<ComponentBuilderController>().free = 4;
    }
}
