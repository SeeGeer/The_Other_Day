using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour {

    public AudioSource dialoguesSource;
    public Animator bodyAnimator;
    public Animator headAnimator;
    public AudioClip[] dialogues;

    private bool flag2 = false;
    private bool flag3 = false;
    private bool flag4 = false;
    private bool flag5 = false;
    private bool flag6 = false;
    private bool flag7 = false;
    private bool flag8 = false;
    private bool flag9 = false;
    private bool flag10 = false;
    private bool flag11 = false;
    private bool flag12 = false;
    private bool flag13 = false;
    private bool flag14 = false;
    private bool flag15 = false;
    private bool flag16 = false;
    private bool flag17 = false;
    private bool flag18 = false;
    private bool flag19 = false;

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.S))
        {
            Database.startGame = true;
            PlayDialogue(0);
            StartCoroutine(DelayPlayed1());
        }

        if (Database.startGame)
        {
            if (Database.GetRod && !flag2)
            {
                flag2 = true;
                StartCoroutine(DelayPlayed2());
            }
            if (Database.FishCount == 0 && Database.ThrownBall && !flag3)
            {
                flag3 = true;
                StartCoroutine(DelayPlayed3());
            }
            if (Database.FishCount == 0 && Database.HaveFish && !flag4)
            {
                flag4 = true;
                StartCoroutine(DelayPlayed4());
            }
            if (Database.FishCount == 0 && Database.FishArrive && !flag5)
            {
                flag5 = true;
                StartCoroutine(DelayPlayed5());
            }
            if (Database.FishCount == 0 && Database.GiveFish && !flag6)
            {
                flag6 = true;
                StartCoroutine(DelayPlayed6());
            }
            if (Database.FishCount == 1 && Database.ThrownBall && !flag7)
            {
                flag7 = true;
                StartCoroutine(DelayPlayed7());
            }
            if (Database.FishCount == 1 && Database.FishArrive && !flag8)
            {
                flag8 = true;
                StartCoroutine(DelayPlayed8());
            }
            if (Database.FishCount == 1 && Database.GiveFish && !flag9)
            {
                flag9 = true;
                StartCoroutine(DelayPlayed9());
            }
            if (Database.FishCount == 2 && Database.ThrownBall && !flag10)
            {
                flag10 = true;
                StartCoroutine(DelayPlayed10());
            }
            if (Database.FishCount == 2 && Database.HaveFish && !flag11)
            {
                flag11 = true;
                StartCoroutine(DelayPlayed11());
            }
            if (Database.FishCount == 2 && Database.FishArrive && !flag12)
            {
                flag12 = true;
                StartCoroutine(DelayPlayed12());
            }
            if (Database.FishCount == 3 && Database.ThrownBall && !flag13)
            {
                flag13 = true;
                StartCoroutine(DelayPlayed13());
            }
            if (Database.FishCount == 3 && Database.HaveFish && !flag14)
            {
                flag14 = true;
                StartCoroutine(DelayPlayed14());
            }
            if (Database.FishCount == 3 && Database.FishArrive && !flag15)
            {
                flag15 = true;
                StartCoroutine(DelayPlayed15());
            }
            if (Database.FishCount == 4 && Database.ThrownBall && !flag16)
            {
                flag16 = true;
                StartCoroutine(DelayPlayed16());
            }
            if (Database.FishCount == 4 && Database.HaveFish && !flag17)
            {
                flag17 = true;
                StartCoroutine(DelayPlayed17());
            }
            if (Database.FishCount == 4 && Database.FishArrive && !flag18)
            {
                flag18 = true;
                StartCoroutine(DelayPlayed18());
            }
            if (Database.FishCount == 4 && Database.GiveFish && !flag19)
            {
                flag19 = true;
                StartCoroutine(DelayPlayed19());
            }

        }
        
    }

    IEnumerator DelayPlayed1()
    {
        yield return new WaitForSeconds(2.0f);
        PlayDialogue(1);
        bodyAnimator.SetBool("01_StartTheGame", true);
        headAnimator.SetBool("01_StartTheGame", true);
        yield return new WaitForSeconds(0.5f);
        bodyAnimator.SetBool("01_StartTheGame", false);
        headAnimator.SetBool("01_StartTheGame", false);
    }

    IEnumerator DelayPlayed2()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(2);
        bodyAnimator.SetBool("03_CastRod", true);
        headAnimator.SetBool("03_CastRod", true);
        yield return new WaitForSeconds(0.5f);
        bodyAnimator.SetBool("03_CastRod", false);
        headAnimator.SetBool("03_CastRod", false);
    }

    IEnumerator DelayPlayed3()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(3);
        bodyAnimator.SetBool("08_TalkingWithoutLooking", true);
        headAnimator.SetBool("08_TalkingWithoutLooking", true);
        yield return new WaitForSeconds(dialogues[3].length);
        bodyAnimator.SetBool("08_TalkingWithoutLooking", false);
        headAnimator.SetBool("08_TalkingWithoutLooking", false);
    }

    IEnumerator DelayPlayed4()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(4);
        bodyAnimator.SetBool("04_Reeling", true);
        headAnimator.SetBool("04_Reeling", true);
        yield return new WaitForSeconds(0.5f);
        bodyAnimator.SetBool("04_Reeling", false);
        headAnimator.SetBool("04_Reeling", false);
    }

    IEnumerator DelayPlayed5()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(5);
        bodyAnimator.SetBool("05_GoodJob", true);
        headAnimator.SetBool("05_GoodJob", true);
        yield return new WaitForSeconds(0.5f);
        bodyAnimator.SetBool("05_GoodJob", false);
        headAnimator.SetBool("05_GoodJob", false);
    }

    IEnumerator DelayPlayed6()
    {
        bodyAnimator.SetBool("07_PutFishToBucket", true);
        headAnimator.SetBool("07_PutFishToBucket", true);
        yield return new WaitForSeconds(0.5f);
        bodyAnimator.SetBool("07_PutFishToBucket", false);
        headAnimator.SetBool("07_PutFishToBucket", false);
        yield return new WaitForSeconds(2.0f);
        PlayDialogue(6);
    }

    IEnumerator DelayPlayed7()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(7);
        bodyAnimator.SetBool("08_TalkingWithoutLooking", true);
        headAnimator.SetBool("08_TalkingWithoutLooking", true);
        yield return new WaitForSeconds(dialogues[7].length);
        bodyAnimator.SetBool("08_TalkingWithoutLooking", false);
        headAnimator.SetBool("08_TalkingWithoutLooking", false);
    }

    IEnumerator DelayPlayed8()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(8);
        bodyAnimator.SetBool("06_GiveMeFish", true);
        headAnimator.SetBool("06_GiveMeFish", true);
        yield return new WaitForSeconds(0.5f);
        bodyAnimator.SetBool("06_GiveMeFish", false);
        headAnimator.SetBool("06_GiveMeFish", false);
    }

    IEnumerator DelayPlayed9()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(9);
        bodyAnimator.SetBool("07_PutFishToBucket", true);
        headAnimator.SetBool("07_PutFishToBucket", true);
        yield return new WaitForSeconds(0.5f);
        bodyAnimator.SetBool("07_PutFishToBucket", false);
        headAnimator.SetBool("07_PutFishToBucket", false);
    }

    IEnumerator DelayPlayed10()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(10);
        bodyAnimator.SetBool("08_TalkingWithoutLooking", true);
        headAnimator.SetBool("08_TalkingWithoutLooking", true);
        yield return new WaitForSeconds(dialogues[10].length);
        bodyAnimator.SetBool("08_TalkingWithoutLooking", false);
        headAnimator.SetBool("08_TalkingWithoutLooking", false);
    }

    IEnumerator DelayPlayed11()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(11);
        bodyAnimator.SetBool("08_TalkingWithoutLooking", true);
        headAnimator.SetBool("08_TalkingWithoutLooking", true);
        yield return new WaitForSeconds(dialogues[11].length);
        bodyAnimator.SetBool("08_TalkingWithoutLooking", false);
        headAnimator.SetBool("08_TalkingWithoutLooking", false);
    }

    IEnumerator DelayPlayed12()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(12);
        bodyAnimator.SetBool("09_LittleFish", true);
        headAnimator.SetBool("09_LittleFish", true);
        yield return new WaitForSeconds(0.5f);
        bodyAnimator.SetBool("09_LittleFish", false);
        headAnimator.SetBool("09_LittleFish", false);
    }

    IEnumerator DelayPlayed13()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(13);
        bodyAnimator.SetBool("00_Talking", true);
        headAnimator.SetBool("00_Talking", true);
        yield return new WaitForSeconds(dialogues[13].length);
        bodyAnimator.SetBool("00_Talking", false);
        headAnimator.SetBool("00_Talking", false);
    }

    IEnumerator DelayPlayed14()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(14);
        bodyAnimator.SetBool("10_BigFish", true);
        headAnimator.SetBool("10_BigFish", true);
        yield return new WaitForSeconds(0.5f);
        bodyAnimator.SetBool("10_BigFish", false);
        headAnimator.SetBool("10_BigFish", false);
    }

    IEnumerator DelayPlayed15()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(15);
        bodyAnimator.SetBool("00_Talking", true);
        headAnimator.SetBool("00_Talking", true);
        yield return new WaitForSeconds(dialogues[15].length);
        bodyAnimator.SetBool("00_Talking", false);
        headAnimator.SetBool("00_Talking", false);
    }

    IEnumerator DelayPlayed16()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(16);
        bodyAnimator.SetBool("08_TalkingWithoutLooking", true);
        headAnimator.SetBool("08_TalkingWithoutLooking", true);
        yield return new WaitForSeconds(dialogues[16].length);
        bodyAnimator.SetBool("08_TalkingWithoutLooking", false);
        headAnimator.SetBool("08_TalkingWithoutLooking", false);
    }

    IEnumerator DelayPlayed17()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(17);
        bodyAnimator.SetBool("10_BigFish", true);
        headAnimator.SetBool("10_BigFish", true);
        yield return new WaitForSeconds(0.5f);
        bodyAnimator.SetBool("10_BigFish", false);
        headAnimator.SetBool("10_BigFish", false);
    }

    IEnumerator DelayPlayed18()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(18);
        bodyAnimator.SetBool("11_LookAtTheFish", true);
        headAnimator.SetBool("11_LookAtTheFish", true);
        yield return new WaitForSeconds(0.5f);
        bodyAnimator.SetBool("11_LookAtTheFish", false);
        headAnimator.SetBool("11_LookAtTheFish", false);
    }

    IEnumerator DelayPlayed19()
    {
        yield return new WaitForSeconds(1.0f);
        PlayDialogue(19);
        bodyAnimator.SetBool("12_GrabTheFishForPhoto", true);
        headAnimator.SetBool("12_GrabTheFishForPhoto", true);
    }


    private void PlayDialogue(int numOfDialogue)
    {
        dialoguesSource.Stop();
        dialoguesSource.clip = dialogues[numOfDialogue];
        dialoguesSource.Play();
    }

}
