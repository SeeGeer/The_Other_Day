using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScene : MonoBehaviour {

    public string scene;
    public Color loadToColor = Color.black;
    public GameObject Flash;
    public float FlashTime = 0.1f;

    private void OnGUI()
    {
        if(GUI.Button(new Rect(0,0,100,30), "Start"))
        {

            Flash.SetActive(true);
            StartCoroutine(StartCountDown());
            //Flash.SetActive(true);


            Initiate.Fade(scene, loadToColor, 0.1f);
        }
    }


    public IEnumerator StartCountDown()
    {
        yield return new WaitForSeconds(FlashTime);
        Flash.SetActive(false);

    }


}
