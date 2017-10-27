using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteFadeController : MonoBehaviour
{

    float alpha = 1;
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (Database.StartWhiteFade)
        {
            StartCoroutine(FadeOut());
        }
    }


    private IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(0.2f);
        Color c = GetComponent<Renderer>().material.color;
        c.a = alpha;
        if(alpha > 0.0f)
        {
            alpha -= 0.01f * speed;
        }
        
        GetComponent<Renderer>().material.color = c;
        //c = Color.Lerp(guiTexture.color, Color.clear, fadeSpeed * Time.deltaTime);
    }


}
