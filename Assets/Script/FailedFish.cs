using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailedFish : MonoBehaviour {
    private float speed = 1.5f;
    private float escapeSpeed = 2.0f;
    public GameObject hookObject;
    public AudioSource fishGoneSound;
    public AudioSource restartSound;
    public AudioSource stringBreaksSound;

    void Update () {
        float step = speed * Time.deltaTime;
        float escapeStep = escapeSpeed * Time.deltaTime;
        if ((Database.FishCount == Database.FailedFish) && Database.HaveFish && !Database.FishArrive)
        {
            if (Database.isPull)
            {
                Vector3 newPos = gameObject.transform.position;
                if (newPos.z > 4.5f)
                {
                    newPos.z -= step;
                } else
                {
                    Database.FishArrive = true;
                    fishGoneSound.Play();
                    stringBreaksSound.Play();
                    // STAGE CHANGE HERE!!!
                    StartCoroutine(WaitForFather());
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
        yield return new WaitForSeconds(9.0f);
        Database.PickFish = true;
        hookObject.SetActive(true);
        restartSound.Play();
        Database.FishCount++;
        ResetAll();
    }

    void ResetAll()
    {
        Database.ThrownBall = false;
        Database.WaitForFish = false;
        Database.HaveFish = false; // fish bites the hook
        Database.FishArrive = false;
        Database.PickFish = false;
        Database.GiveFish = false;
    }
}
