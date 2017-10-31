using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour {

    public AudioSource bgm_perc;
    public AudioSource bgm_default;
    public AudioSource bgm_bigfish;

    private bool isBigFishPlay = false;

    private float startTime;
    private float currentTime;
    private float duration = 3.0f;

    // Update is called once per frame
    void Update () {
        if (!Database.InSunSet)
        {
            if (Database.FishCount == 3 && Database.HaveFish && !Database.FishArrive)
            {
                if (!isBigFishPlay)
                {
                    startTime = Time.time;
                    StartCoroutine(ChangeBGMFromDefaultToBigFish());
                    isBigFishPlay = true;
                }
            }
            else if (Database.FishCount == 4 && Database.HaveFish)
            {
                if (!isBigFishPlay)
                {
                    startTime = Time.time;
                    StartCoroutine(ChangeBGMFromDefaultToBigFish());
                    isBigFishPlay = true;
                }
            }
            else
            {
                if (isBigFishPlay)
                {
                    startTime = Time.time;
                    StartCoroutine(ChangeBGMFromBigFishToDefault());
                    isBigFishPlay = false;
                }
            }
        }
		
	}

    IEnumerator ChangeBGMFromDefaultToBigFish()
    {
        float step = Time.deltaTime / 2;
        while (bgm_default.volume > 0)
        {
            currentTime = Time.time;
            bgm_default.volume = Mathf.Lerp(0.1f, 0.0f, (currentTime - startTime) / duration);
            bgm_bigfish.volume = Mathf.Lerp(0.0f, 0.1f, (currentTime - startTime) / duration);
            yield return new WaitForSeconds(step);
        }
    }

    IEnumerator ChangeBGMFromBigFishToDefault()
    {
        float step = Time.deltaTime / 2;
        while (bgm_bigfish.volume > 0)
        {
            currentTime = Time.time;
            bgm_bigfish.volume = Mathf.Lerp(0.1f, 0.0f, (currentTime - startTime) / duration);
            bgm_default.volume = Mathf.Lerp(0.0f, 0.1f, (currentTime - startTime) / duration);
            yield return new WaitForSeconds(step);
        }
    }
}
