using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoGoHome : MonoBehaviour {

    public GameObject PhotoAtHome;
    public GameObject PhotoInHand;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Photo")
        {
            PhotoAtHome.SetActive(true);
            PhotoInHand.SetActive(false);
        }
    }
}
