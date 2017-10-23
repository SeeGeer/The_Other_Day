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


    private void OnGUI()
    {
        if(Database.SwitchScene && !Database.InSunSet)
        {

            Flash.SetActive(true);
            StartCoroutine(StartCountDown());
            //Flash.SetActive(true);

            Database.SwitchScene = false;
            Database.InSunSet = true;
        }
    }


    public IEnumerator StartCountDown()
    {
        yield return new WaitForSeconds(FlashTime);
        Flash.SetActive(false);

        SunSet.SetActive(true);
        Morning.SetActive(false);
        CameraInHand.SetActive(false);
    }


}
