using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class LaserInput : MonoBehaviour
{
    private static GameObject _currentObject = null;

    public static GameObject CurrentObject
    {
        get
        {
            return _currentObject;
        }
        set
        {
            _currentObject = value;
        }
    }
}
