﻿using UnityEngine;
using Valve.VR.InteractionSystem;

public class EventTest : MonoBehaviour
{
    public void OnPress(Hand hand)
    {
        Debug.Log("SteamVR Button pressed!");
    }

    public void OnCustomButtonPress()
    {
        Debug.Log("We pushed our custom button!");
    }
}