using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoController : MonoBehaviour
{

    public MovieTexture MTexture;
    void Update()
    {
        if (Input.GetButtonDown("M"))
        {

            Renderer r = GetComponent<Renderer>();
            r.material.mainTexture = MTexture;
            //MovieTexture movie = (MovieTexture)r.material.mainTexture;

            if (MTexture.isPlaying)
            {
                MTexture.Pause();
            }
            else
            {
                MTexture.Play();
            }
        }
    }
}
