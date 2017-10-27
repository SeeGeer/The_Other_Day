using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeController : MonoBehaviour
{

    float alpha = 0;
    public float speed = 1.0f;
    public float waitFade = 3.0f;


    // Update is called once per frame
    void Update()
    {
        if (Database.StartToFade)
        {
            StartCoroutine(DelayFadeOut());

        }
    }

    private IEnumerator DelayFadeOut()
    {
        yield return new WaitForSeconds(waitFade);
        StartCoroutine(FadeOut());
    }





    private IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(0.2f);
        Color c = GetComponent<Renderer>().material.color;
        c.a = alpha;
        if (alpha < 1.0f)
        {
            alpha += 0.01f * speed;
        }

        GetComponent<Renderer>().material.color = c;
        //c = Color.Lerp(guiTexture.color, Color.clear, fadeSpeed * Time.deltaTime);
    }


}
