﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* ColourData.cs is a scriptable object responsible for holding colour scheme data. */

public class ColourData : ScriptableObject
{
    public string colourName;
    public Color32 colourCamera;
    public Material colourCube;
    public int[] colourGhoulmates;

    public ColourData()
    {
    }

    public void Init(string name, Color32 cameraColour, Material cubeColour, int[] ghoulmatesColour)
    {
        colourName = name;
        colourCamera = cameraColour;
        colourCube = cubeColour;
        colourGhoulmates = ghoulmatesColour;
    }
}
