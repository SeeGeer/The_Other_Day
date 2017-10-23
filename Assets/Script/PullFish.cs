using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullFish : MonoBehaviour {

    public int fishNumber;
    private float[] speed = new float[3] { 2.2f, 2.0f, 1.8f };
    public Transform hookPosition;

	void Update ()
    {
        float step = speed[Database.FishCount] * Time.deltaTime;
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
