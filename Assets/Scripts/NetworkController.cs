using System;
using System.Collections;
using System.Collections.Generic;
using SocketIO;
using UnityEngine;

public class NetworkController : SocketIOComponent
{
    public override void Start()
    {
        base.Start();
        SetEvents();
    }

    private void SetEvents()
    {
        On("open", (result) => 
        {
            this.Log("connected to server!!!");
        });
    }

    public override void Update()
    {
        base.Update();
    }
}
