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
    public GameObject BackOfPhoto;
    public GameObject BoatBroken;
    public GameObject Boat;
    public GameObject WhiteBoard;


    private void OnGUI()
    {
        //if (Database.SwitchScene && !Database.InSunSet && Database.FacingFather)
        if (Database.SwitchScene && !Database.InSunSet)
        {
            
            Flash.SetActive(true);
            StartCoroutine(StartCountDown());
            Database.StartWhiteFade = true;
            WhiteBoard.SetActive(true);

            Database.SwitchScene = false;
            Database.InSunSet = true;
            Destroy(Father, 0.1f);
            StartCoroutine(DelayDisable());
           
            Database.FishCount++;
            BoatBroken.SetActive(true);
            Boat.SetActive(false);
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


}
