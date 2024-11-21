using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ComponentBuilderController : MonoBehaviour
{
    public int free;
    public GameObject partController;
    public GameObject flourish;
    public GameObject popUp;
    public AudioSource buildShimmer;
    // Start is called before the first frame update
    void Start()
    {
        free = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if(free == 0){
            if(this.transform.GetChild(0).GetComponent<TileController>().unit.tag == "Wire" && this.transform.GetChild(1).GetComponent<TileController>().unit.tag == "Metal" && this.transform.GetChild(2).GetComponent<TileController>().unit.tag == "Metal" && this.transform.GetChild(3).GetComponent<TileController>().unit.tag == "Metal"){
                for(int i = 0; i < this.transform.childCount; i++){
                    Destroy(this.transform.GetChild(i).GetComponent<TileController>().unit);
                    this.transform.GetChild(i).GetComponent<TileController>().unit = GameObject.Find("Blank");
                }
                partController.GetComponent<PartController>().battery++;
            }
            else if(this.transform.GetChild(0).GetComponent<TileController>().unit.tag == "Wire" && this.transform.GetChild(1).GetComponent<TileController>().unit.tag == "Wire" && this.transform.GetChild(2).GetComponent<TileController>().unit.tag == "Metal" && this.transform.GetChild(3).GetComponent<TileController>().unit.tag == "Metal"){
                for(int i = 0; i < this.transform.childCount; i++){
                    Destroy(this.transform.GetChild(i).GetComponent<TileController>().unit);
                    this.transform.GetChild(i).GetComponent<TileController>().unit = GameObject.Find("Blank");
                }
                partController.GetComponent<PartController>().motorPower++;
            }
            else if(this.transform.GetChild(0).GetComponent<TileController>().unit.tag == "Wire" && this.transform.GetChild(1).GetComponent<TileController>().unit.tag == "Wire" && this.transform.GetChild(2).GetComponent<TileController>().unit.tag == "Wire" && this.transform.GetChild(3).GetComponent<TileController>().unit.tag == "Wire"){
                for(int i = 0; i < this.transform.childCount; i++){
                    Destroy(this.transform.GetChild(i).GetComponent<TileController>().unit);
                    this.transform.GetChild(i).GetComponent<TileController>().unit = GameObject.Find("Blank");
                }
                partController.GetComponent<PartController>().speed++;
            }
            else if(this.transform.GetChild(0).GetComponent<TileController>().unit.tag == "Metal" && this.transform.GetChild(1).GetComponent<TileController>().unit.tag == "Metal" && this.transform.GetChild(2).GetComponent<TileController>().unit.tag == "Metal" && this.transform.GetChild(3).GetComponent<TileController>().unit.tag == "Metal"){
                for(int i = 0; i < this.transform.childCount; i++){
                    Destroy(this.transform.GetChild(i).GetComponent<TileController>().unit);
                    this.transform.GetChild(i).GetComponent<TileController>().unit = GameObject.Find("Blank");
                }
                partController.GetComponent<PartController>().health++;
            }
            else if(this.transform.GetChild(0).GetComponent<TileController>().unit.tag == "Wire" && this.transform.GetChild(1).GetComponent<TileController>().unit.tag == "Metal" && this.transform.GetChild(2).GetComponent<TileController>().unit.tag == "Metal" && this.transform.GetChild(3).GetComponent<TileController>().unit.tag == "Wire"){
                for(int i = 0; i < this.transform.childCount; i++){
                    Destroy(this.transform.GetChild(i).GetComponent<TileController>().unit);
                    this.transform.GetChild(i).GetComponent<TileController>().unit = GameObject.Find("Blank");
                }
                partController.GetComponent<PartController>().ai++;
            } else {
                for(int i = 0; i < this.transform.childCount; i++){
                    if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Metal"){
                        partController.GetComponent<PartController>().metal++;
                    } else if(this.transform.GetChild(i).GetComponent<TileController>().unit.tag == "Wire"){
                        partController.GetComponent<PartController>().wire++;
                    }
                    Destroy(this.transform.GetChild(i).GetComponent<TileController>().unit);
                    this.transform.GetChild(i).GetComponent<TileController>().unit = GameObject.Find("Blank");
                }
            }
            Instantiate(flourish, transform.position, Quaternion.identity);
            Instantiate(popUp, transform.position, Quaternion.identity);
            Instantiate(buildShimmer);
            free = 4;
        }
    }
}
