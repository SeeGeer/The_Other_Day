using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScene : MonoBehaviour {

    //public string scene;
    //public Color loadToColor = Color.black;
    public GameObject Flash;
    public float FlashTime = 0.5f;
    public GameObject SunSet;
    public GameObject Morning;
    public GameObject CameraInHand;
    public GameObject Father;
    public GameObject FishingRod;
    public GameObject OriginalRod;
    public GameObject PapaPhoto;
    public GameObject PapaPhotoFilter;
    //public GameObject FuturePapaPhotoFilter;

    public GameObject BackOfPhoto;
    public GameObject BoatBroken;
    
    public GameObject Boat;
    public GameObject WhiteBoard;
    public GameObject PhotoHome;
    public AudioSource transitionSound;
    public AudioSource first_perc;
    public AudioSource first_bigfish;
    public AudioSource first_default;
    public AudioSource SecondBGM;
    public float secondBGMWaitTime = 15.0f;

    public GameObject peddleBroken_1;
    public GameObject peddleBroken_2;
    public GameObject peddle_1;
    public GameObject peddle_2;

    public GameObject StoolBroken_1;
    public GameObject StoolBroken_2;
    public GameObject Stool_1;
    public GameObject Stool_2;

    public GameObject LifeSaverBroken_1;
    public GameObject LifeSaverBroken_2;
    public GameObject LifeSaver_1;
    public GameObject LifeSaver_2;

    public GameObject Bucket;
    public GameObject BucketBroken;

    private void OnGUI()
    {
        //if (Database.SwitchScene && !Database.InSunSet && Database.FacingFather)
        if (Database.SwitchScene && !Database.InSunSet)
        {
            transitionSound.Play();
            first_bigfish.Stop();
            first_default.Stop();
            first_perc.Stop();
            Flash.SetActive(true);
            StartCoroutine(StartCountDown());
            
            WhiteBoard.SetActive(true);

            Database.SwitchScene = false;
            Database.InSunSet = true;
            Destroy(Father, 0.1f);
            StartCoroutine(DelayDisable());
            StartCoroutine(DelayWhiteFadeOut());
            StartCoroutine(DelayPlaySecondBGM());
           
            Database.FishCount++;
            ResetAll();
        }

        if (Database.TakePhotoNotSwitchScene && !Database.InSunSet)//Just take pic for fun
        {

            if (Database.TakenPic)
            {
                Flash.SetActive(true);
                StartCoroutine(StartCountDownNotSwitch());
                Database.TakenPic = false; // finish taking pic
                // StartCoroutine(RestartCamera());
            }
        }
    }

    public IEnumerator StartCountDown()
    {
        yield return new WaitForSeconds(FlashTime);
        Flash.SetActive(false);

        PapaPhoto.GetComponent<MeshRenderer>().enabled = true;
        PapaPhotoFilter.GetComponent<MeshRenderer>().enabled = true;
        BackOfPhoto.GetComponent<MeshRenderer>().enabled = true;
        SunSet.SetActive(true);
        Morning.SetActive(false);
        CameraInHand.SetActive(false);
    }

    private IEnumerator DelayDisable()
    {
        yield return new WaitForSeconds(0.1f);
        FishingRod.SetActive(false);
        OriginalRod.SetActive(true);
        BoatBroken.SetActive(true);

        peddle_1.SetActive(false);
        peddle_2.SetActive(false);
        peddleBroken_1.SetActive(true);
        peddleBroken_2.SetActive(true);

        Stool_1.SetActive(false);
        Stool_2.SetActive(false);
        StoolBroken_1.SetActive(true);
        StoolBroken_2.SetActive(true);

        LifeSaver_1.SetActive(false);
        LifeSaver_2.SetActive(false);
        LifeSaverBroken_1.SetActive(true);
        LifeSaverBroken_2.SetActive(true);


        Bucket.SetActive(false);
        BucketBroken.SetActive(true);

        Boat.SetActive(false);
        PhotoHome.SetActive(true);
    }


    public IEnumerator StartCountDownNotSwitch()
    {
        yield return new WaitForSeconds(FlashTime);
        Flash.SetActive(false);
    }

    void ResetAll()
    {
        Database.GetRod = false;
        Database.ThrownBall = false;
        Database.WaitForFish = false;
        Database.HaveFish = false; // fish bites the hook
        Database.FishArrive = false;
        Database.PickFish = false;
        Database.GiveFish = false;
    }

    private IEnumerator DelayPlaySecondBGM()
    {
        yield return new WaitForSeconds(secondBGMWaitTime);
        SecondBGM.Play();
    }

    private IEnumerator DelayWhiteFadeOut()
    {
        yield return new WaitForSeconds(2.0f);
        Database.StartWhiteFade = true;
    }
    


}
