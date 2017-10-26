using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickFish : MonoBehaviour {
    public GameObject FishInHand;
    public GameObject BigFishInHand;
    public GameObject FishInSunset;
    public GameObject Credit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SmallFish")
        {
            /*
            if (Database.InSunSet)
            {
                FishInSunset.SetActive(true);
                Database.PickFish = true;
                Credit.SetActive(true);
            }
            else{
                FishInHand.SetActive(true);
                Database.PickFish = true; 
            }
            */
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
