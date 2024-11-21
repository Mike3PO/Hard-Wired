using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialController : MonoBehaviour
{
    public GameObject metal;
    public GameObject wire;
    public GameObject battery, motorController, speedUp, healthUp, aiUp, frontPlate, leftPlate, rightPlate, backPlate, leftWheel, rightWheel, weapon;
    public bool unitInHand;
    public AudioSource buttonPush;

    public GameObject currentGhost;
    public int screen;
    // Start is called before the first frame update
    void Start()
    {
        screen = 0;
        unitInHand = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPress(string name){
        Instantiate(buttonPush);
        if(!unitInHand){
            if(name == "metal"){
                currentGhost = Instantiate(metal).gameObject;
                GameObject.Find("Part Controller").GetComponent<PartController>().metal--;
                unitInHand = true;
            }
            if(name == "wire"){
                currentGhost = Instantiate(wire).gameObject;
                GameObject.Find("Part Controller").GetComponent<PartController>().wire--;
                unitInHand = true;
            }
            if(name == "battery"){
                currentGhost = Instantiate(battery).gameObject;
                GameObject.Find("Part Controller").GetComponent<PartController>().battery--;
                unitInHand = true;
            }
            if(name == "motorpower"){
                currentGhost = Instantiate(motorController).gameObject;
                GameObject.Find("Part Controller").GetComponent<PartController>().motorPower--;
                unitInHand = true;
            }
            if(name == "speed"){
                currentGhost = Instantiate(speedUp).gameObject;
                GameObject.Find("Part Controller").GetComponent<PartController>().speed--;
                unitInHand = true;
            }
            if(name == "health"){
                currentGhost = Instantiate(healthUp).gameObject;
                GameObject.Find("Part Controller").GetComponent<PartController>().health--;
                unitInHand = true;
            }
            if(name == "ai"){
                currentGhost = Instantiate(aiUp).gameObject;
                GameObject.Find("Part Controller").GetComponent<PartController>().ai--;
                unitInHand = true;
            }
            if(name == "frontplate"){
                currentGhost = Instantiate(frontPlate).gameObject;
                GameObject.Find("Part Controller").GetComponent<PartController>().plates--;
                unitInHand = true;
            }
            if(name == "leftplate"){
                currentGhost = Instantiate(leftPlate).gameObject;
                GameObject.Find("Part Controller").GetComponent<PartController>().plates--;
                unitInHand = true;
            }
            if(name == "rightplate"){
                currentGhost = Instantiate(rightPlate).gameObject;
                GameObject.Find("Part Controller").GetComponent<PartController>().plates--;
                unitInHand = true;
            }
            if(name == "backplate"){
                currentGhost = Instantiate(backPlate).gameObject;
                GameObject.Find("Part Controller").GetComponent<PartController>().plates--;
                unitInHand = true;
            }
            if(name == "leftwheel"){
                currentGhost = Instantiate(leftWheel).gameObject;
                GameObject.Find("Part Controller").GetComponent<PartController>().wheels--;
                unitInHand = true;
            }
            if(name == "rightwheel"){
                currentGhost = Instantiate(rightWheel).gameObject;
                GameObject.Find("Part Controller").GetComponent<PartController>().wheels--;
                unitInHand = true;
            }
            if(name == "weapon"){
                currentGhost = Instantiate(weapon).gameObject;
                GameObject.Find("Part Controller").GetComponent<PartController>().weapons--;
                unitInHand = true;
            }
        }
        
    }
}
