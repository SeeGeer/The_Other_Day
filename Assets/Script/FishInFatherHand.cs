using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishInFatherHand : MonoBehaviour {

    public AudioSource fatherFishSound;
    public GameObject smallFishInFatherHand;
    private bool putFishFlag = false;

	void Update () {
		if (Database.GiveFish)
        {
            if ((Database.FishCount == 0 || Database.FishCount == 1) && !putFishFlag)
            {
                smallFishInFatherHand.SetActive(true);
                StartCoroutine(DelayDisableFish());
                putFishFlag = true;
            }
        }
	}

    IEnumerator DelayDisableFish()
    {
        yield return new WaitForSeconds(3.5f);
        smallFishInFatherHand.SetActive(false);
        fatherFishSound.Play();
        yield return new WaitForSeconds(10.0f);
        putFishFlag = false;
    }
}
