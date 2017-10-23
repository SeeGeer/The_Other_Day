using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickCamera : MonoBehaviour {


    public GameObject CameraInHand;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "RightHand")
        {


            CameraInHand.SetActive(true);
            Database.PickUpCamera = true;
            //GameObject.FindWithTag("Camera").SetActive(false);

            GameObject.FindWithTag("Camera").GetComponent<MeshRenderer>().enabled = false;
            if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
            {
                print("IN");
                Database.SwitchScene = true;
            }


        }
    }
}
