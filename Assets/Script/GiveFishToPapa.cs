using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveFishToPapa : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "SmallFishInHand")
        {
            GetComponent<Renderer>().material.color = Color.yellow;
            GameObject.Find("SmallFishInHand").SetActive(false);
            ResetAll();

        }



    }


    void ResetAll()
    {
   
        Database.isPull = false;
        Database.ThrownBall = false;
        Database.WaitForFish = false;
        Database.HaveFish = false; // fish bites the hook
        Database.FishArrive = false;
        Database.PickFish = false;
        Database.GiveFish = false;
}
}
