﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSDirector : System.Object
{
    private static SSDirector instance;
    public SceneController currentSceneController { get; set; }

    private SSDirector() { }

    public static SSDirector getInstance()
    {
        if (instance == null)
        {
            instance = new SSDirector();
        }
        return instance;
    }
}