﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickCamera : MonoBehaviour {
    public GameObject CameraInHand;

    private void OnTriggerEnter(Collider other)
    {
        if (Database.CameraReady)
        {
            if (other.tag == "RightHand")
            {
                CameraInHand.SetActive(true);
                Database.PickUpCamera = true;
                GameObject.FindWithTag("Camera").GetComponent<Collider>().enabled = false;
                GameObject.FindWithTag("Camera").GetComponent<MeshRenderer>().enabled = false;
            }
        }  
    }

    void Update()
    {
        if (Database.PickUpCamera)
        {
            if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
            {
                print("IN");
                Database.SwitchScene = true;
            }
        }
        
    }
}
