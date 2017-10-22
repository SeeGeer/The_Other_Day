using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingController : MonoBehaviour {
    public float[] FishWatingTime = { 1.0f, 2.0f, 3.0f};
    public float ViberateDuration = 1.0f;
	
	// Update is called once per frame
	void Update () {
        if (Database.ThrownBall && !Database.WaitForFish)
        {
            StartCoroutine(WaitingForFish(FishWatingTime[0]));
        }

        if (Database.HaveFish && !Database.PickFish)
        {
            OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
        }

        if(Database.PickFish)
            OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);

        

        if(Database.FishCount == 3)
        {

        }
	}


    public IEnumerator WaitingForFish(float Duration)
    {
        Database.WaitForFish = true;
        yield return new WaitForSeconds(Duration);
        Database.HaveFish = true;
    }


}
