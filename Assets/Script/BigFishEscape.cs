using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFishEscape : MonoBehaviour {


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
            BendScript.angle += 4.0f;

            if(BendScript.angle > 50)
            {
                forward = false;
            }
        }
            

        else
        {
            BendScript.angle -= 4.0f;

            if (BendScript.angle < -50)
            {
                forward = true;
            }
        }


    }
}
