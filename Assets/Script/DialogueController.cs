using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour {


    //public AudioSource[] dialogues;
    public AudioClip[] dialogues;



    // Use this for initialization
    void Start () {
        StartCoroutine(DelayPlay(2.0f, 0)); //Hey
        
    }
	
	// Update is called once per frame
	void Update () {

    }




    private IEnumerator DelayPlay(float waitTime, int dNumber)
    {
        yield return new WaitForSeconds(waitTime);

        
    }


}
