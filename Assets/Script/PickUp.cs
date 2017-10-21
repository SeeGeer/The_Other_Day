using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {


    public GameObject Rod;
    public GameObject OriginalRod;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.name == "hand_left_renderPart_0")
        {
            Database.GetRod = true;
            Rod.SetActive(true);
            Destroy(OriginalRod, 0.1f);

        }
    }
}
