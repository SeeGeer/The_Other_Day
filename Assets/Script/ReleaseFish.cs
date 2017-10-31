using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseFish : MonoBehaviour {

    public AudioSource smallFishGo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ChildFishInHand")
        { 
            GameObject.FindWithTag("ChildFishInHand").SetActive(false);
            Database.FishCount++;
            OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
            smallFishGo.Play();
            Database.ReleaseFish = true;
            ResetAll();
        }
    }

    void ResetAll()
    {
        Database.ThrownBall = false;
        Database.WaitForFish = false;
        Database.HaveFish = false;  // fish bites the hook
        Database.FishArrive = false;
        Database.PickFish = false;
        Database.GiveFish = false;
    }
}
