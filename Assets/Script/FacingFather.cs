using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingFather : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Looking")
        {
            Database.FacingFather = true;
            print("FacingFather true");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Looking")
        {
            Database.FacingFather = false;
            //print("FacingFather False");
        }

    }
}
