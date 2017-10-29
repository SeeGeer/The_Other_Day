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
            OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
            Database.GiveFish = true;
            StartCoroutine(DelayReset());
            
        }
        if (other.tag == "BigFishInHand")
        {
            GetComponent<Renderer>().material.color = Color.cyan;
            GameObject.FindWithTag("BigFishInHand").SetActive(false);
            OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
            Database.GiveFish = true;
            Database.GiveBigFishToPapa = true;
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

    IEnumerator DelayReset()
    {
        yield return new WaitForSeconds(1.0f);
        Database.FishCount++;
        ResetAll();
    }
    
}
