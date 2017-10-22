using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingToolControl : MonoBehaviour {
    public GameObject fishingReel;
    private bool isRotate = false;

    void OnTriggerEnter(Collider other)
    {
        isRotate = true;
        Debug.Log("collide");
    }


    void OnTriggerStay(Collider other)
    {
        isRotate = true;
        Debug.Log("collide");
    }

    void OnTriggerExit(Collider other)
    {
        isRotate = false;
    }

    private void Update()
    {
        if (isRotate)
        {
            fishingReel.transform.Rotate(new Vector3(1f, 0f, 0f));
        }
        // fishingReel.transform.Rotate(new Vector3(1f, 0f, 0f));

    }
}
