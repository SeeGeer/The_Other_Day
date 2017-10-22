using UnityEngine;
using System.Collections;
using System.Threading;

public class DrawLine : MonoBehaviour
{

    public GameObject Fish;
    public GameObject RodHead;

    private GameObject LineRenderGameObject;
    private LineRenderer lineRenderer;

    private int lineLength = 2;

    private Vector3 v0;
    private Vector3 v1;


    void Start()
    {

        


        
        


    }


    void Update()
    {

        //在游戏更新中去设置点  
        //根据点将这个曲线链接起来  
        //第一个参数为 点的ID   
        //第二个 参数为点的3D坐标  
        //ID 一样的话就标明是一条线段  
        //所以盆友们须要注意一下！ 
        if (Database.ThrownBall)
        {
            if(Fish = GameObject.Find("Mark(Clone)"))
            {
                if(RodHead = GameObject.Find("RodHead"))
                {

                    v0 = Fish.transform.position;
                    v1 = RodHead.transform.position;

                    LineRenderGameObject = GameObject.Find("line");
                    lineRenderer = (LineRenderer)LineRenderGameObject.GetComponent("LineRenderer");


                    //lineRenderer.SetVertexCount(4);
                    lineRenderer.positionCount = 2;
                }
            
            }

        }

        
        


        lineRenderer.SetPosition(0, v0);
        lineRenderer.SetPosition(1, v1);



    }

}