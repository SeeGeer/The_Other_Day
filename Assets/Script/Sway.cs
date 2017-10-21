using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sway : MonoBehaviour
{


    public int WheelNum;
    public int WheelTotal = 5;
    public int count = 0;//At least
    public GameObject Mark;
    public GameObject TargetPos;
    bool Thrown = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Database.Count >= 2)
        {
            Database.Count = 0;

            
            //Database.isRunning = true;
            //Database.isRunning = true;

            if (!Thrown)
            {
                if(Database.GetRod)
                isThrown();
            }
            
             


        }

    }

    private void OnTriggerEnter(Collider other)
    {

       
        if (Database.WheelSet[WheelNum] == true)
        {

            //Database.WheelSet[WheelNum] = true;
            for (int k = 0; k < WheelNum + 1; k++)
            {
                Database.WheelSet[k] = false;
            }
        }

        else
        {
            Database.WheelSet[WheelNum] = true;

            for (int i = WheelNum + 1; i < WheelTotal; i++)
            {
                Database.WheelSet[i] = false;
            }

            for (int j = 0; j < WheelNum - 1; j++)
            {
                if (Database.WheelSet[j])
                {
                    Database.Count++;
                }
            }

        }




    }


    void isThrown()
    {
        Thrown = true;
        Instantiate(Mark, new Vector3(TargetPos.transform.localPosition.x, TargetPos.transform.localPosition.y, 
        TargetPos.transform.localPosition.z), Quaternion.identity);

    }
}
