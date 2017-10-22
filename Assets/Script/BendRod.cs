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
    void Update()
    {

        //OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
        //ovr_SetControllerVibration(Hmd, ovrControllerType_LTouch, freq, trigger);
        if (Database.ThrownBall)
        {
            if (BendScript.angle < 20)//default
            {
                BendScript.angle += 1;
            }
        }
    }
}
