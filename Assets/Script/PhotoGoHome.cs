﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoGoHome : MonoBehaviour {

    public GameObject PhotoAtHome;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "photo")
        {
            PhotoAtHome.SetActive(true);
        }
    }
}
