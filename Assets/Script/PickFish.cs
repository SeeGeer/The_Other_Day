using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickFish : MonoBehaviour {
    public GameObject FishInHand;
    public GameObject BigFishInHand;
    public GameObject ChildFishInHand;
    public GameObject FishInSunset;
    public AudioSource successSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SmallFish")
        {
            FishInHand.SetActive(true);
            successSound.Play();
            Database.PickFish = true;
        }
        if (other.tag == "BigFish")
        {
            BigFishInHand.SetActive(true);
            successSound.Play();
            Database.PickFish = true;
        }
        if (other.tag == "ChildFish")
        {
            ChildFishInHand.SetActive(true);
            successSound.Play();
            Database.PickFish = true;
        }
    }
}
