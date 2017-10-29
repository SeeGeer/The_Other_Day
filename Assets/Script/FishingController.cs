using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingController : MonoBehaviour {
    public float[] FishWatingTime = {3.0f, 3.0f, 3.0f, 3.0f, 3.0f, 0.0f};

    public GameObject hookObject;
    public GameObject[] fishInWater;

    // Update is called once per frame
    void Update () {
        if (Database.ThrownBall && !Database.WaitForFish)
        {
            hookObject.SetActive(false);
            if (Database.FishCount == Database.EndFish)
            {
                Database.StartToFade = true;

            } else
            {
                StartCoroutine(WaitingForFish(FishWatingTime[Database.FishCount]));
            }
        }
        else if (Database.FishCount != Database.EndFish)
        {
            if (Database.HaveFish && !Database.FishArrive)
            {
                OVRInput.SetControllerVibration(1, 20, OVRInput.Controller.LTouch);
            }
            else if (Database.FishArrive && !Database.PickFish)
            {
                if (Database.FishCount != Database.FailedFish)
                {
                    OVRInput.SetControllerVibration(1, 20, OVRInput.Controller.LTouch);
                    fishInWater[Database.FishCount].SetActive(false);
                } else
                {
                    OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
                }
                
            }
            else if (Database.PickFish && !Database.GiveBigFishToPapa)
            {
                OVRInput.SetControllerVibration(1, 20, OVRInput.Controller.RTouch);
                OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
                hookObject.SetActive(true);
            }
        }
	}

    private IEnumerator WaitingForFish(float Duration)
    {
        
        Database.WaitForFish = true;
        yield return new WaitForSeconds(Duration);
        Database.HaveFish = true;
    }
}
