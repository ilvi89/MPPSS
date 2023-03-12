﻿using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LevelData
{
    public string name;
    public List<EnemyData> enemies = new();
}

[Serializable]
public class EnemyData
{
    public string id;
    public ShipData shipData;
    public Quaternion shipRotation;
    public float shipMoveSpeed;
    public List<Vector3> pathPoints = new();
}