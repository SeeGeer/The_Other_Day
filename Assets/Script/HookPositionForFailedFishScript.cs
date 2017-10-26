using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookPositionForFailedFishScript : MonoBehaviour {

    public GameObject rodHead;
    private Vector3 hookPosition;

    // Update is called once per frame
    void Update()
    {
        hookPosition = rodHead.transform.position;
        hookPosition.y -= 1.5f;
        gameObject.transform.position = hookPosition;
    }
}
