using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseFish : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ChildFishInhand")
        { 
            GameObject.FindWithTag("ChildFishInhand").SetActive(false);
            Database.FishCount++;
            ResetAll();
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
