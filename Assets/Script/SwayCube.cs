using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwayCube : MonoBehaviour
{
    // public GameObject Mark;
    // public GameObject BigFishMark;
    // public GameObject TargetPos;
    // bool Thrown = false;

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
                }
            }
        }
    }

    /*
    void isThrown()
    {
        Thrown = true;
        if(Database.FishCount < 2)
            Instantiate(Mark, new Vector3(TargetPos.transform.localPosition.x, TargetPos.transform.localPosition.y,
            TargetPos.transform.localPosition.z), Quaternion.identity);

        if(Database.FishCount == 2)
            Instantiate(BigFishMark, new Vector3(TargetPos.transform.localPosition.x, TargetPos.transform.localPosition.y,
            TargetPos.transform.localPosition.z), Quaternion.identity);
    }
    */
}
