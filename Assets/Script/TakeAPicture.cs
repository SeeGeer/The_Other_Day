using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeAPicture : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print("In0");
        if (Database.PickUpCamera == true)
        {
            print("In1");
            if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
            {
                print("IN");
                Database.SwitchScene = true;
            }
        }

    }
}
