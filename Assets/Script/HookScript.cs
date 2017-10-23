using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookScript : MonoBehaviour {

    public GameObject hookPositionObject;
    public Transform[] FishPosition;

    private float throwSpeed = 10.0f;
    private float getSpeed = 1.0f;

    // Update is called once per frame
    void Update () {

        float throwStep = throwSpeed * Time.deltaTime;
        float getStep = getSpeed * Time.deltaTime;

        if (Database.ThrownBall && !Database.HaveFish)
        {
            gameObject.transform.position = Vector3.MoveTowards
                    (gameObject.transform.position, FishPosition[Database.FishCount].position, throwStep);
        }
        else if (Database.HaveFish && !Database.FishArrive)
        {
            if (Database.isPull)
            {
                gameObject.transform.position = Vector3.MoveTowards
                    (gameObject.transform.position, hookPositionObject.transform.position, getStep);
                if (Vector3.Distance(gameObject.transform.position, hookPositionObject.transform.position) < 0.01f)
                {
                    Database.FishArrive = true;
                    // STAGE CHANGE HERE!!!
                }
            }
        } else
        {
            gameObject.transform.position = hookPositionObject.transform.position;
        }
    }
}
