﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public static Database _instance;

    // Xuefan
    public static bool isPull = false;
    // Xuefan

    public static bool GetRod = false;
    public static bool ThrownBall = false;
    public static bool WaitForFish = false;
    public static bool HaveFish = false; // fish bites the hook
    public static bool FishArrive = false;
    public static bool PickFish = false;
    public static bool GiveFish = false;

    public static int FishCount = 0;
    public static int FailedFish = 2;
    public static int BigFish = 3;
    public static int EndFish = 4;


    public static bool CameraReady = false;
    public static bool SwitchScene = false;
    public static bool TakePhotoNotSwitchScene = false;
    public static bool PickUpCamera = false;
    public static bool InSunSet = false;
    public static bool FacingFather = false;

    public static bool TakenPic = false;
    public static bool clickCamera = false;

    public static bool StartToFade = false;
    public static bool StartWhiteFade = false;
    //public static bool ChangeSkybox = false;
}