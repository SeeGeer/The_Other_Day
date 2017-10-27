using UnityEngine;
using System.Collections;
using System.Threading;

public class DrawLine : MonoBehaviour
{
    public GameObject RodHead;
    public GameObject Hook;
    public GameObject[] fishInWater;
    public GameObject[] fishOnHook;

    private LineRenderer lineRenderer;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        if (Database.GetRod)
        {
            if (Database.ThrownBall && !Database.FishArrive)
            {
                lineRenderer.SetPosition(0, RodHead.transform.position);
                lineRenderer.SetPosition(1, fishInWater[Database.FishCount].transform.position);
            }
            else if (Database.FishArrive && !Database.PickFish)
            {
                lineRenderer.SetPosition(0, RodHead.transform.position);
                lineRenderer.SetPosition(1, fishOnHook[Database.FishCount].transform.position);
            } else
            {
                lineRenderer.SetPosition(0, RodHead.transform.position);
                lineRenderer.SetPosition(1, Hook.transform.position);
            }
        } else
        {
            lineRenderer.SetPosition(0, new Vector3(0f, 0f, 0f));
            lineRenderer.SetPosition(1, new Vector3(0f, 0f, 0f));
        }
    }

}