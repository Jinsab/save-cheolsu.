﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemy : MonoBehaviour
{
    public enum ENEMY_TYPE
    {
        NULL = -1,
        PUNCH,
        KICK,
        NUMBEROFTYPES
    }

    public ENEMY_TYPE _eType = ENEMY_TYPE.NULL;
    public float _fMoveSpeed = 0f;

    private Transform _tr = null;

    private void Awake()
    {
        _tr = transform;
    }

    private void Update()
    {
        _tr.Translate(Vector3.left * _fMoveSpeed * Time.deltaTime);
    }
}