﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyFactory : MonoBehaviour, IFactory
{
    [SerializeField]
    public GameObject[] enemyPrefab;

    public GameObject FactoryMethod(int tag, Transform spawnPoint)
    {
        GameObject enemy = Instantiate(enemyPrefab[tag], spawnPoint.position, Quaternion.identity);
        return enemy;
    }
}
