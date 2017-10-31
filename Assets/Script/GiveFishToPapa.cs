using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveFishToPapa : MonoBehaviour {


    public GameObject FatherCamera;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SmallFishInHand")
        {
            GetComponent<Renderer>().material.color = Color.yellow;
            GameObject.FindWithTag("SmallFishInHand").SetActive(false);
            Database.GiveFish = true;
            StartCoroutine(DelayReset());
            
        }
        if (other.tag == "BigFishInHand")
        {
            GetComponent<Renderer>().material.color = Color.cyan;
            GameObject.FindWithTag("BigFishInHand").SetActive(false);
            Database.GiveFish = true;
            Database.GiveBigFishToPapa = true;

            StartCoroutine(DelayCameraAppear());
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


    IEnumerator DelayCameraAppear()
    {
        yield return new WaitForSeconds(3.0f);
        Database.CameraReady = true;
        FatherCamera.SetActive(true);
    }
}
