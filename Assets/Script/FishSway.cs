using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSway : MonoBehaviour {

	private float lastTime;
    private float currentTime;
    private bool forward = true;
    private bool preSet = false;

    private float swaySpeed = 0.3f;
    private float rotateSpeed = 60.0f;
    private float frequency = 0.5f;

	void Start () {
        lastTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (!preSet)
        {
            Vector3 newPos = gameObject.transform.position;
            newPos.x -= (swaySpeed * 0.5f * frequency);
            gameObject.transform.position = newPos;
            gameObject.transform.Rotate(0f, rotateSpeed * 0.5f * frequency, 0f);
            preSet = true;
        }

		currentTime = Time.time;
        if (currentTime - lastTime >= frequency)
        {
            forward = !forward;
            lastTime = currentTime;
        }

        float swayStep = swaySpeed * Time.deltaTime;
        float rotateStep = rotateSpeed * Time.deltaTime;
        if (forward)
        {
            Vector3 newPos = gameObject.transform.position;
            newPos.x += swayStep;
            gameObject.transform.position = newPos;
            gameObject.transform.Rotate(0f, -rotateStep, 0f);
        } else
        {
            Vector3 newPos = gameObject.transform.position;
            newPos.x -= swayStep;
            gameObject.transform.position = newPos;
            gameObject.transform.Rotate(0f, rotateStep, 0f);
        }
    }
}
