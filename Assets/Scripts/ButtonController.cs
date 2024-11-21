using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private PartController partController;
    public string resource;
    Button button;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        partController = GameObject.Find("Part Controller").GetComponent<PartController>();
        button = this.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(resource == "metal" && partController.metal > 0){
            text.GetComponent<TextMeshProUGUI>().text = "Metal " + partController.metal;
            button.interactable = true;
        } else if(resource == "wire" && partController.wire > 0){
            button.interactable = true;
            text.GetComponent<TextMeshProUGUI>().text = "Wire " + partController.wire;
        } else if(resource == "battery" && partController.battery > 0){
            button.interactable = true;
            text.GetComponent<TextMeshProUGUI>().text = "Battery " + partController.battery;
        } else if(resource == "motorpower" && partController.motorPower > 0){
            button.interactable = true;
            text.GetComponent<TextMeshProUGUI>().text = "Motor Controller " + partController.motorPower;
        } else if(resource == "speed" && partController.speed > 0){
            button.interactable = true;
            text.GetComponent<TextMeshProUGUI>().text = "Speed Up " + partController.speed;
        } else if(resource == "health" && partController.health > 0){
            button.interactable = true;
            text.GetComponent<TextMeshProUGUI>().text = "Health Up " + partController.health;
        } else if(resource == "ai" && partController.ai > 0){
            button.interactable = true;
            text.GetComponent<TextMeshProUGUI>().text = "AI Up " + partController.ai;
        } else if(resource == "plates" && partController.plates > 0){
            button.interactable = true;
            text.GetComponent<TextMeshProUGUI>().text = "Plates " + partController.plates;
        } else if(resource == "wheels" && partController.wheels > 0){
            button.interactable = true;
            text.GetComponent<TextMeshProUGUI>().text = "Wheels " + partController.wheels;
        } else if(resource == "weapons" && partController.weapons > 0){
            button.interactable = true;
            text.GetComponent<TextMeshProUGUI>().text = "Weapons " + partController.weapons;
        } 
        else {
            button.interactable = false;
            text.GetComponent<TextMeshProUGUI>().text = resource;
        }

    }
}
