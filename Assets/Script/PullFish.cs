using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullFish : MonoBehaviour {

    public int fishNumber;
    private float speed = 1.5f;
    public Transform hookPosition;

	void Update ()
    {
        float step = speed * Time.deltaTime;
		if ((fishNumber == Database.FishCount) && Database.HaveFish && !Database.FishArrive)
        {
            if (Database.isPull)
            {
                gameObject.transform.position = Vector3.MoveTowards
                    (gameObject.transform.position, hookPosition.position, step);
                if (Vector3.Distance(gameObject.transform.position, hookPosition.position) < 0.01f)
                {
                    Database.FishArrive = true;
                    // STAGE CHANGE HERE!!!
                }
            }
        }
    }
}
