using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailedFish : MonoBehaviour {
    private float speed = 1.5f;
    private float escapeSpeed = 2.0f;

	void Update () {
        float step = speed * Time.deltaTime;
        float escapeStep = escapeSpeed * Time.deltaTime;
        if ((Database.FishCount == Database.FailedFish) && Database.HaveFish && !Database.FishArrive)
        {
            if (Database.isPull)
            {
                Vector3 newPos = gameObject.transform.position;
                if (newPos.z > 3.0f)
                {
                    newPos.z -= step;
                } else
                {
                    Database.FishArrive = true;
                    // STAGE CHANGE HERE!!!
                    StarCouroutine
                }
                gameObject.transform.position = newPos;
            }
            else
            {
                Vector3 newPos = gameObject.transform.position;
                if (newPos.z <15.0f)
                {
                    newPos.z += escapeStep;
                }
                gameObject.transform.position = newPos;
            }
        }

        
    }

    IEnumerator WaitForFather()
    {
        yield return new WaitForSeconds(5.0f);
        Database.PickFish = true;
    }
}
