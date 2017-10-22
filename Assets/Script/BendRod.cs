using System.Collections;
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
	void Update () {

        OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
        //ovr_SetControllerVibration(Hmd, ovrControllerType_LTouch, freq, trigger);
        if (Database.ThrownBall)
        {
            if(BendScript.angle < 40)
            {
                BendScript.angle += 1;

            }
        }




        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)) //right hand first finger
        {
            //Shoot();
            OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
            TriggerTime = Time.time;//record the time when you shoot
        }
        else
        {
            if (Time.time - TriggerTime > 0.05f)
            { //vibrate for 0.05s, and then stop
                OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
            }
        }

    }

    
}
