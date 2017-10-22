using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCome : MonoBehaviour {


    GameObject RodHead;
    GameObject Guest;
    public GameObject Fish;
    public float speed = 1.0f;
    Vector3 RodHeadPosition;
    Vector3 GuestPosition;



    bool NearEnough_1 = false;
    bool NearEnough_2 = false;
    // Use this for initialization
    void Start () {
        //Distance = RodPoint.transform.localPosition - Fish.transform.localPosition;

        
    }
	
	// Update is called once per frame
	void Update () {
        if (Database.ThrownBall)
        {
           

            RodHead = GameObject.Find("RodHead");
            RodHeadPosition = RodHead.transform.position;

            Guest = GameObject.Find("OVRCameraRig");
            GuestPosition = Guest.transform.position;


            float step = speed * Time.deltaTime;
            //print("Pos "+RodHeadPosition);
            if(gameObject.transform.localPosition.x - GuestPosition.x < 0.2f)
            {
                NearEnough_2 = true;
            }


            if (gameObject.transform.localPosition.x - RodHeadPosition.x < 0.5f && !NearEnough_2)
            {
                NearEnough_1 = true;
                gameObject.transform.localPosition = Vector3.MoveTowards
                (gameObject.transform.localPosition, GuestPosition, step);
            }

            if (!NearEnough_1 && !NearEnough_2)
            {
                
                gameObject.transform.localPosition = Vector3.MoveTowards
                (gameObject.transform.localPosition, RodHeadPosition, step);
            }


        }
	}
}
