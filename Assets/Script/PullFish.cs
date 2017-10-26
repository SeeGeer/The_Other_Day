using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullFish : MonoBehaviour {

    public int fishNumber;
    private float[] speed = new float[4] { 2.0f, 1.8f, 0.0f, 1.5f };
    private float[] escapeSpeed = new float[4] { 2.0f, 2.2f, 0.0f, 3.0f };
    public Transform hookPosition;
    public AudioSource fishAudio;
    private bool isPlay = false;

	void Update ()
    {
        float step = speed[Database.FishCount] * Time.deltaTime;
        float escapeStep = escapeSpeed[Database.FishCount] * Time.deltaTime;
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
            } else
            {
                Vector3 newPos = gameObject.transform.position;
                if (newPos.y > -1.2)
                {
                    newPos.y -= escapeStep;
                    newPos.z += (escapeStep / 2);
                }
                gameObject.transform.position = newPos;
            }
        }

        if ((gameObject.transform.position.y > -1.0) && !isPlay)
        {
            fishAudio.Play();
            isPlay = true;
        } else if ((gameObject.transform.position.y <= -1.0) && isPlay)
        {
            fishAudio.Stop();
            isPlay = false;
        }
    }
}
