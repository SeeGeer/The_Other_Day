﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BendRod : MonoBehaviour {
    float TriggerTime;
    MegaBend BendScript;

	// Use this for initialization
	void Start () {
        BendScript = GetComponent<MegaBend>();  
	}

    // Update is called once per frame
    void Update()
    {
        //OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
        //ovr_SetControllerVibration(Hmd, ovrControllerType_LTouch, freq, trigger);
        if (Database.ThrownBall && !Database.HaveFish)
        {
            if (BendScript.angle < 15) // No fish
            {
                BendScript.angle += 1;
            }
        } else if (Database.HaveFish && !Database.PickFish)
        {
            int nextAngle = 30; // small fish
            if (Database.FishCount == Database.BigFish)
            {
                nextAngle = 50; // big fish
            }
            if (BendScript.angle < nextAngle)
            {
                BendScript.angle += 1;
            }
        } else if (Database.PickFish)
        {
            if (BendScript.angle > 0)
            {
                BendScript.angle -= 1;
            }
        }
    }
}
