using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {


    public GameObject Rod;
    public GameObject OriginalRod;


    private void OnTriggerEnter(Collider other)
    {
        
        if(other.name == "hand_left_renderPart_0")
        {
            print("GetRod");
            Database.GetRod = true;
            Rod.SetActive(true);
            OriginalRod.SetActive(false);
            //Destroy(OriginalRod, 0.1f);

        }
    }
}
