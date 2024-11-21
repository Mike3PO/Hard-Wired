using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;

public class GhostController : MonoBehaviour
{
    public GameObject material;
    private GameObject materialController;
    RaycastHit2D hit;
    private GameObject tile;
    private GameObject partController;
    public GameObject electricSparks;
    public AudioSource electricSound;
    // Start is called before the first frame update
    void Start()
    {
        materialController = GameObject.Find("Materials Controller");
        partController = GameObject.Find("Part Controller");
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = new Vector3(pos.x, pos.y, 0);

        hit = Physics2D.Raycast(new UnityEngine.Vector2(pos.x, pos.y), UnityEngine.Vector2.zero);

        if(hit.collider != null && hit.collider.tag == "Tile" && (this.tag == "Metal" || this.tag == "Wire")){
            tile = hit.collider.gameObject;
            Debug.Log("Hit!");
        }

        else if(hit.collider != null && hit.collider.tag == "BatteryTile" && this.tag == "Battery"){
            tile = hit.collider.gameObject;
            Debug.Log("Hit!");
        }

        else if(hit.collider != null && hit.collider.tag == "MotorTile" && this.tag == "Motor"){
            tile = hit.collider.gameObject;
            Debug.Log("Hit!");
        }

        else if(hit.collider != null && hit.collider.tag == "SpeedAIHealthTile" && (this.tag == "Speed" || this.tag == "Health" || this.tag == "AI")){
            tile = hit.collider.gameObject;
            Debug.Log("Hit!");
        }

        else if(hit.collider != null && hit.collider.tag == "FrontPlateTile" && this.tag == "FrontPlate"){
            tile = hit.collider.gameObject;
            Debug.Log("Hit!");
        }

        else if(hit.collider != null && hit.collider.tag == "LeftPlateTile" && this.tag == "LeftPlate"){
            tile = hit.collider.gameObject;
            Debug.Log("Hit!");
        }

        else if(hit.collider != null && hit.collider.tag == "RightPlateTile" && this.tag == "RightPlate"){
            tile = hit.collider.gameObject;
            Debug.Log("Hit!");
        }

        else if(hit.collider != null && hit.collider.tag == "BackPlateTile" && this.tag == "BackPlate"){
            tile = hit.collider.gameObject;
            Debug.Log("Hit!");
        }

        else if(hit.collider != null && hit.collider.tag == "LeftWheelTile" && this.tag == "LeftWheel"){
            tile = hit.collider.gameObject;
            Debug.Log("Hit!");
        }

        else if(hit.collider != null && hit.collider.tag == "RightWheelTile" && this.tag == "RightWheel"){
            tile = hit.collider.gameObject;
            Debug.Log("Hit!");
        }

        else if(hit.collider != null && hit.collider.tag == "WeaponTile" && this.tag == "Weapon"){
            tile = hit.collider.gameObject;
            Debug.Log("Hit!");
        } else {
            transform.position = new UnityEngine.Vector3(pos.x - transform.localScale.x/2, pos.y + transform.localScale.y/2, 0);
        }

        if(Input.GetMouseButton(0) && tile != null && materialController.GetComponent<MaterialController>().unitInHand && tile.GetComponent<TileController>().unit == GameObject.Find("Blank")){
            if(this.tag == "Battery"){
                partController.GetComponent<PartController>().power += 8;
            } else if(this.tag == "Motor"){
                partController.GetComponent<PartController>().attack += 2;
                partController.GetComponent<PartController>().defense += 2;
            } else if(this.tag == "Speed"){
                partController.GetComponent<PartController>().power += 4;
            } else if(this.tag == "Health"){
                partController.GetComponent<PartController>().defense += 4;
            } else if(this.tag == "AI"){
                partController.GetComponent<PartController>().attack += 4;
            } else if(this.tag.Contains("Plate")){
                partController.GetComponent<PartController>().attack += 25;
                partController.GetComponent<PartController>().defense += 50;
                partController.GetComponent<PartController>().power += 25;
            } else if(this.tag.Contains("Wheel")){
                partController.GetComponent<PartController>().attack += 20;
                partController.GetComponent<PartController>().defense += 10;
                partController.GetComponent<PartController>().power += 50;
            } else if(this.tag.Contains("Weapon")){
                partController.GetComponent<PartController>().attack += 100;
            }
            Instantiate(electricSparks, transform.position, UnityEngine.Quaternion.identity);
            Instantiate(electricSound);
            tile.GetComponent<TileController>().unit = Instantiate(materialController.GetComponent<MaterialController>().currentGhost.GetComponent<GhostController>().material, tile.transform.position, materialController.GetComponent<MaterialController>().currentGhost.GetComponent<GhostController>().material.transform.rotation).gameObject;
            materialController.GetComponent<MaterialController>().unitInHand = false;
            Destroy(materialController.GetComponent<MaterialController>().currentGhost);
            if(materialController.GetComponent<MaterialController>().screen == 0){
                GameObject.Find("Component Builder").GetComponent<ComponentBuilderController>().free--;
            }
            if(materialController.GetComponent<MaterialController>().screen == 1){
                GameObject.Find("Board Builder").GetComponent<BoardBuilderController>().free--;
            }
        } else if(Input.GetMouseButton(0)){
            materialController.GetComponent<MaterialController>().unitInHand = false;
            Destroy(materialController.GetComponent<MaterialController>().currentGhost);
        
        }
        
    }
}
