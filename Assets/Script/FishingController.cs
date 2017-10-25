using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingController : MonoBehaviour {
    public float[] FishWatingTime = { 1.0f, 2.0f, 3.0f, 3.0f};

    public GameObject hookObject;
    public GameObject[] fishInWater;
	
	// Update is called once per frame
	void Update () {
        if (Database.ThrownBall && !Database.WaitForFish)
        {
            StartCoroutine(WaitingForFish(FishWatingTime[0]));
        }
        else if (Database.HaveFish && !Database.FishArrive)
        {
            OVRInput.SetControllerVibration(1, 20, OVRInput.Controller.LTouch);
        }
        else if (Database.FishArrive && !Database.PickFish)
        {
            OVRInput.SetControllerVibration(1, 20, OVRInput.Controller.LTouch);
            fishInWater[Database.FishCount].SetActive(false);
        }
        else if (Database.PickFish)
        {
            OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
            hookObject.SetActive(true);
        }
	}

    public IEnumerator WaitingForFish(float Duration)
    {
        hookObject.SetActive(false);
        Database.WaitForFish = true;
        yield return new WaitForSeconds(Duration);
        Database.HaveFish = true;
    }
}
