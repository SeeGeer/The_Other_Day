using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoGoHome : MonoBehaviour {

    public GameObject PhotoAtHome;
    public GameObject PhotoBackAtHome;

    public GameObject PhotoInHand;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if (Database.InSunSet)
        {
            print(other.name);
            if(other.name == "Photo_1")
            {

                WWW wwww = new WWW(Application.persistentDataPath + "/C.png");
            
                PhotoAtHome.GetComponent<MeshRenderer>().enabled = true;
                PhotoBackAtHome.GetComponent<MeshRenderer>().enabled = true;
                GameObject.Find("Photo_2").GetComponent<Renderer>().material.mainTexture = wwww.texture;

                PhotoInHand.SetActive(false);
            }

        }
    }
}
