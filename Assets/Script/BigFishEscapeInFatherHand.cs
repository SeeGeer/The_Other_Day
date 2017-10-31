using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFishEscapeInFatherHand : MonoBehaviour {


    MegaBend BendScript;
    bool forward = true;
    // Use this for initialization
    void Start()
    {
        BendScript = GetComponent<MegaBend>();
    }


    // Update is called once per frame
    void Update () {

        if(forward)
        {
            BendScript.angle += 2.0f;

            if(BendScript.angle > 10)
            {
                forward = false;
            }
        }
            

        else
        {
            BendScript.angle -= 2.0f;

            if (BendScript.angle < -10)
            {
                forward = true;
            }
        }


    }
}
