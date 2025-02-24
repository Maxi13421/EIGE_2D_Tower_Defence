﻿using System;
using System.Collections.Generic;
using UnityEngine;

    
public class BigWeapon : Weapon
{
    public Vector3[] WeaponPositions = new []{new Vector3(1,0f,0)};
    
    
    
    private float _lastShot = float.MinValue;


    private void Awake()
    {
    }
    
    
    public override void Shoot()
    {
        AudioManager.instance.PlayLevelOneShot(FMODEvents.instance.fireBig,transform.position);
        if (Time.time - _lastShot > _cooldownMicro)
        {
            _lastShot = Time.time;
            foreach (var weaponPosition in WeaponPositions)
            {
                GameObject o = Level.BigProjectilePool.GetPooledObject();
                o.transform.position = transform.parent.position + weaponPosition;
                o.transform.right = Vector3.right;
            }
        }
    }

    public override void StopShooting()
    {
        
    }
}