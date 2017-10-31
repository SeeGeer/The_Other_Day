using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadFollow : MonoBehaviour {
    public GameObject MyCamera;
    public GameObject[] Fish;

    // Update is called once per frame
    void Update () {

        if (Database.HaveFish && !Database.FishArrive)
        {
            transform.LookAt(Fish[Database.FishCount].transform);
        }

        else
        {
            transform.LookAt(MyCamera.transform);
        }
    }

    private void OnDrawGizmos()
    {
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, transform.position + 3 * transform.forward);
        }
    }
}
