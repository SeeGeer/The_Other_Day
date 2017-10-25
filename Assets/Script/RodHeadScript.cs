using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodHeadScript : MonoBehaviour {

    public Transform originalPosition;
    public Transform waitingPosition;
    public Transform smallFishPosition;
    public Transform bigFishPosition;

    public float speed = 10.0f;
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;

        if (Database.ThrownBall && !Database.HaveFish)
        {
            gameObject.transform.localPosition = Vector3.MoveTowards
                    (gameObject.transform.localPosition, waitingPosition.localPosition, step);
        }
        else if (Database.HaveFish && !Database.PickFish)
        {
            // small fish
            Vector3 nextPosition = smallFishPosition.localPosition;

            if (Database.FishCount == Database.BigFish)
            {
                // big fish
                nextPosition = bigFishPosition.localPosition;
            }

            gameObject.transform.localPosition = Vector3.MoveTowards
                   (gameObject.transform.localPosition, nextPosition, step);
        }
        else {
            gameObject.transform.localPosition = Vector3.MoveTowards
                   (gameObject.transform.localPosition, originalPosition.localPosition, step);
        }
    }
}
