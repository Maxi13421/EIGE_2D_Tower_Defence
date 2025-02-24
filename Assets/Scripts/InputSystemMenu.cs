﻿using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystemMenu : MonoBehaviour
{
    public InputAction chooseAction;
    public InputAction acceptAction;
    public InputAction backAction;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        chooseAction.Enable();
        acceptAction.Enable();
        backAction.Enable();
    }

    private void OnDisable()
    {
        chooseAction.Disable();
        acceptAction.Disable();
        backAction.Disable();
    }
}