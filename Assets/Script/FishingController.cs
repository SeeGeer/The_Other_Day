using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingController : MonoBehaviour {

    float TriggerTime;
    bool isViberate = true;
    public float[] FishWatingTime = { 1.0f, 2.0f, 3.0f};
    public float ViberateDuration = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Database.HaveFish && isViberate)
        {
            OVRInput.SetControllerVibration(1, 20, OVRInput.Controller.LTouch);
            TriggerTime = Time.time;//record the time when you shoot
        }

        if(Database.PickFish)
            OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);







        if (Database.ThrownBall)
        {
            StartCoroutine(WaitingForFish(FishWatingTime[0]));
        }
	}


    public IEnumerator WaitingForFish(float Duration)
    {
        yield return new WaitForSeconds(Duration);
        Database.HaveFish = true;
        




    }


}
