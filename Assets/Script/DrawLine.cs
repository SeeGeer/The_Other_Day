using UnityEngine;
using System.Collections;
using System.Threading;

public class DrawLine : MonoBehaviour
{
    public GameObject RodHead;
    public GameObject Hook;
    public GameObject[] fishInWater;

    private LineRenderer lineRenderer;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, RodHead.transform.position);
    }

    private void Update()
    {
        /*
        //在游戏更新中去设置点  
        //根据点将这个曲线链接起来  
        //第一个参数为 点的ID   
        //第二个 参数为点的3D坐标  
        //ID 一样的话就标明是一条线段  
        //所以盆友们须要注意一下

        if (Database.ThrownBall)
        {
            if(Fish = GameObject.Find("Mark(Clone)"))
            {
                if(RodHead = GameObject.Find("RodHead"))
                {

                    v0 = Fish.transform.position;
                    v1 = RodHead.transform.position;

                    lineRenderer = GetComponent<LineRenderer>();
                    lineRenderer.positionCount = 2;
                }

            }
            
        }
        */

        if (Database.ThrownBall && !Database.FishArrive)
        {
            lineRenderer.SetPosition(1, fishInWater[Database.FishCount].transform.position);
        } else
        {
            lineRenderer.SetPosition(1, Hook.transform.position);
        }
    }

}