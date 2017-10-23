using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveFishToPapa : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SmallFishInHand")
        {
            GetComponent<Renderer>().material.color = Color.yellow;
            GameObject.FindWithTag("SmallFishInHand").SetActive(false);
            Database.FishCount++;
            ResetAll();
        }
        if (other.tag == "BigFishInHand")
        {
            GetComponent<Renderer>().material.color = Color.cyan;
            GameObject.FindWithTag("BigFishInHand").SetActive(false);
            Database.CameraReady = true;
        }
    }

    void ResetAll()
    {
        Database.ThrownBall = false;
        Database.WaitForFish = false;
        Database.HaveFish = false; // fish bites the hook
        Database.FishArrive = false;
        Database.PickFish = false;
        Database.GiveFish = false;
    }
}
