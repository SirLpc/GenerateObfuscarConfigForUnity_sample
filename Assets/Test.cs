using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void OnGUI()
    {
        ShouldBeObfuscated();
    }

    private void ShouldBeObfuscated()
    {
        GUILayout.Label("Test");
    }
}
