using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickFish : MonoBehaviour {
    public GameObject FishInHand;
    public GameObject BigFishInHand;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SmallFish")
        {
            FishInHand.SetActive(true);
            Database.PickFish = true;
        }
        if (other.tag == "BigFish")
        {
            BigFishInHand.SetActive(true);
            Database.PickFish = true;
        }
    }
}
