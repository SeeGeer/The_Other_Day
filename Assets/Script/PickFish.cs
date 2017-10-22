using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickFish : MonoBehaviour {



    public GameObject FishInHand;
    public GameObject BigFishInHand;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //print("TriggerEnter");
        if (other.name == "Mark(Clone)")
        {
            FishInHand.SetActive(true);
            Destroy(GameObject.Find("Small Fish"), 0.1f);
            Database.PickFish = true;
            Database.FishCount++;

        }


        if(other.name == "BigFishMark(Clone")
        {
            print("Here!");
            BigFishInHand.SetActive(true);
            Destroy(GameObject.Find("Big Fish"), 0.1f);
            Database.PickFish = true;
            Database.FishCount++;
        }
    }
}
