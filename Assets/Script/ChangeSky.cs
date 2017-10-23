using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSky : MonoBehaviour {

    public Material skyboxSunset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Database.InSunSet)
        {
            RenderSettings.skybox = skyboxSunset;
        }
    }

}
