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
    public static int BigFish = 2;
}