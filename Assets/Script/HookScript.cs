using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookScript : MonoBehaviour {

    public GameObject hookPositionObject;
    public GameObject[] fishWaitForPick;

    // Update is called once per frame
    void Update () {
        gameObject.transform.position = hookPositionObject.transform.position;

        if (Database.FishArrive && !Database.PickFish)
        {
            fishWaitForPick[Database.FishCount].SetActive(true);
        } else if (Database.PickFish)
        {
            fishWaitForPick[Database.FishCount].SetActive(false);
        }

    }
}
