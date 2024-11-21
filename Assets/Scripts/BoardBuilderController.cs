using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardBuilderController : MonoBehaviour
{
    public GameObject partController;
    public int free;
    public GameObject flourish;
    public GameObject popUp;
    public AudioSource buildShimmer;
    // Start is called before the first frame update
    void Start()
    {
        free = 13;
    }

    // Update is called once per frame
    void Update()
    {
        if(free == 0){

        
        if(this.transform.GetChild(0).GetComponent<TileController>().unit.tag == "Battery" && this.transform.GetChild(1).GetComponent<TileController>().unit.tag == "Motor" && this.transform.GetChild(2).GetComponent<TileController>().unit.tag == "Motor" && this.transform.GetChild(3).GetComponent<TileController>().unit.tag == "Motor" && this.transform.GetChild(4).GetComponent<TileController>().unit.tag == "Motor" 
        && this.transform.GetChild(5).GetComponent<TileController>().unit.tag == "Speed" && this.transform.GetChild(6).GetComponent<TileController>().unit.tag == "Speed" && this.transform.GetChild(7).GetComponent<TileController>().unit.tag == "Speed" && this.transform.GetChild(8).GetComponent<TileController>().unit.tag == "Speed" 
        && this.transform.GetChild(9).GetComponent<TileController>().unit.tag == "Speed" && this.transform.GetChild(10).GetComponent<TileController>().unit.tag == "Speed" && this.transform.GetChild(11).GetComponent<TileController>().unit.tag == "Speed"  && this.transform.GetChild(12).GetComponent<TileController>().unit.tag == "Speed"){
            for(int i = 0; i < this.transform.childCount; i++){
            if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Battery"){
                partController.GetComponent<PartController>().power -= 8;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Motor"){
                partController.GetComponent<PartController>().attack -= 2;
                partController.GetComponent<PartController>().defense -= 2;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Speed"){
                partController.GetComponent<PartController>().power -= 4;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Health"){
                partController.GetComponent<PartController>().defense -= 4;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "AI"){
                partController.GetComponent<PartController>().attack -= 4;
            }
            Destroy(this.transform.GetChild(i).GetComponent<TileController>().unit);
            this.transform.GetChild(i).GetComponent<TileController>().unit = GameObject.Find("Blank");
            }
            partController.GetComponent<PartController>().wheels++;
            free = 13;
        }

        else if(this.transform.GetChild(0).GetComponent<TileController>().unit.tag == "Battery" && this.transform.GetChild(1).GetComponent<TileController>().unit.tag == "Motor" && this.transform.GetChild(2).GetComponent<TileController>().unit.tag == "Motor" && this.transform.GetChild(3).GetComponent<TileController>().unit.tag == "Motor" && this.transform.GetChild(4).GetComponent<TileController>().unit.tag == "Motor" 
        && this.transform.GetChild(5).GetComponent<TileController>().unit.tag == "Health" && this.transform.GetChild(6).GetComponent<TileController>().unit.tag == "AI" && this.transform.GetChild(7).GetComponent<TileController>().unit.tag == "AI" && this.transform.GetChild(8).GetComponent<TileController>().unit.tag == "Speed" 
        && this.transform.GetChild(9).GetComponent<TileController>().unit.tag == "Health" && this.transform.GetChild(10).GetComponent<TileController>().unit.tag == "AI" && this.transform.GetChild(11).GetComponent<TileController>().unit.tag == "AI"  && this.transform.GetChild(12).GetComponent<TileController>().unit.tag == "Speed"){    
            for(int i = 0; i < this.transform.childCount; i++){
            if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Battery"){
                partController.GetComponent<PartController>().power -= 8;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Motor"){
                partController.GetComponent<PartController>().attack -= 2;
                partController.GetComponent<PartController>().defense -= 2;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Speed"){
                partController.GetComponent<PartController>().power -= 4;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Health"){
                partController.GetComponent<PartController>().defense -= 4;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "AI"){
                partController.GetComponent<PartController>().attack -= 4;
            }
            Destroy(this.transform.GetChild(i).GetComponent<TileController>().unit);
            this.transform.GetChild(i).GetComponent<TileController>().unit = GameObject.Find("Blank");
            }
            partController.GetComponent<PartController>().weapons++;
            free = 13;
        }

        else if(this.transform.GetChild(0).GetComponent<TileController>().unit.tag == "Battery" && this.transform.GetChild(1).GetComponent<TileController>().unit.tag == "Motor" && this.transform.GetChild(2).GetComponent<TileController>().unit.tag == "Motor" && this.transform.GetChild(3).GetComponent<TileController>().unit.tag == "Motor" && this.transform.GetChild(4).GetComponent<TileController>().unit.tag == "Motor" 
        && this.transform.GetChild(5).GetComponent<TileController>().unit.tag == "Health" && this.transform.GetChild(6).GetComponent<TileController>().unit.tag == "Health" && this.transform.GetChild(7).GetComponent<TileController>().unit.tag == "Health" && this.transform.GetChild(8).GetComponent<TileController>().unit.tag == "Health" 
        && this.transform.GetChild(9).GetComponent<TileController>().unit.tag == "Health" && this.transform.GetChild(10).GetComponent<TileController>().unit.tag == "Health" && this.transform.GetChild(11).GetComponent<TileController>().unit.tag == "Health"  && this.transform.GetChild(12).GetComponent<TileController>().unit.tag == "Health"){
            for(int i = 0; i < this.transform.childCount; i++){
            if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Battery"){
                partController.GetComponent<PartController>().power -= 8;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Motor"){
                partController.GetComponent<PartController>().attack -= 2;
                partController.GetComponent<PartController>().defense -= 2;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Speed"){
                partController.GetComponent<PartController>().power -= 4;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Health"){
                partController.GetComponent<PartController>().defense -= 4;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "AI"){
                partController.GetComponent<PartController>().attack -= 4;
            }
            Destroy(this.transform.GetChild(i).GetComponent<TileController>().unit);
            this.transform.GetChild(i).GetComponent<TileController>().unit = GameObject.Find("Blank");
            }
            partController.GetComponent<PartController>().plates++;
            free = 13;
        } else {
            for(int i = 0; i < this.transform.childCount; i++){
            if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Battery"){
                partController.GetComponent<PartController>().battery++;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Motor"){
                partController.GetComponent<PartController>().motorPower++;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Speed"){
                partController.GetComponent<PartController>().speed++;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Health"){
                partController.GetComponent<PartController>().health++;
            } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "AI"){
                partController.GetComponent<PartController>().ai++;
            }
            Destroy(this.transform.GetChild(i).GetComponent<TileController>().unit);
            this.transform.GetChild(i).GetComponent<TileController>().unit = GameObject.Find("Blank");
            free = 13;
            }
        }
        Instantiate(flourish, transform.position, Quaternion.identity);
        Instantiate(buildShimmer);
        Instantiate(popUp, transform.position, Quaternion.identity);
        }
    }

    public static void DestroyChildren(BoardBuilderController builder, GameObject partController){
        
    }
}
