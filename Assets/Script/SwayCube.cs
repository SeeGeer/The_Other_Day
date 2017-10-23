using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwayCube : MonoBehaviour
{
    // public GameObject Mark;
    // public GameObject BigFishMark;
    // public GameObject TargetPos;
    // bool Thrown = false;

    public GameObject[] Par;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LeftHand")
        {
            if (Database.GetRod) //already get the rod
            {
                if (!Database.ThrownBall)
                {
                    // isThrown();//Throw the ball away
                    Database.ThrownBall = true;
                    Par[Database.FishCount].SetActive(true);
                }
            }
        }
    }


}
