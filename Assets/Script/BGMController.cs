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
                    StartCoroutine(ChangeBGM(bgm_default, bgm_bigfish));
                    // bgm_default.volume = 0.0f;
                    // bgm_bigfish.volume = 0.3f;
                    isBigFishPlay = true;
                }
            }
            else if (Database.FishCount == 4 && Database.HaveFish)
            {
                if (!isBigFishPlay)
                {
                    startTime = Time.time;
                    StartCoroutine(ChangeBGM(bgm_default, bgm_bigfish));
                    // bgm_default.volume = 0.0f;
                    // bgm_bigfish.volume = 0.3f;
                    isBigFishPlay = true;
                }
            }
            else
            {
                if (isBigFishPlay)
                {
                    startTime = Time.time;
                    StartCoroutine(ChangeBGM(bgm_bigfish, bgm_default));
                    // bgm_default.volume = 0.3f;
                    // bgm_bigfish.volume = 0.0f;
                    isBigFishPlay = false;
                }
            }
        }
		
	}

    IEnumerator ChangeBGM(AudioSource from, AudioSource to)
    {
        float step = Time.deltaTime / 2;
        while (from.volume > 0)
        {
            currentTime = Time.time;
            from.volume = Mathf.Lerp(0.1f, 0.0f, (currentTime - startTime) / duration);
            to.volume = Mathf.Lerp(0.0f, 0.1f, (currentTime - startTime) / duration);
            yield return new WaitForSeconds(step);
        }
    }
}
