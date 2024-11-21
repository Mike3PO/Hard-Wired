using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    public GameObject materialController;
    public GameObject unit;
    // Start is called before the first frame update
    void Start()
    {
        materialController = GameObject.Find("Materials Controller");
        unit = GameObject.Find("Blank");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseOver(){
        if(materialController.GetComponent<MaterialController>().unitInHand && unit == GameObject.Find("Blank") && (this.tag.Contains(materialController.GetComponent<MaterialController>().currentGhost.tag) || (this.tag == "Tile" && (materialController.GetComponent<MaterialController>().currentGhost.tag == "Metal" || materialController.GetComponent<MaterialController>().currentGhost.tag == "Wire")))){
            materialController.GetComponent<MaterialController>().currentGhost.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0);
            if(materialController.GetComponent<MaterialController>().currentGhost.tag == "BackPlate"){
                materialController.GetComponent<MaterialController>().currentGhost.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 0);            
            }        
        }
    }
}
