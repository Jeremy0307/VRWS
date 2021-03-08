using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class LaserInput : MonoBehaviour
{
    private static GameObject _currentObject = null;

    int _currentID = 0;

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

    private void Start()
    {
        _currentObject = null;
        _currentID = 0;
    }

    private void Update()
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, 100.0f);

        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            int id = hit.collider.gameObject.GetInstanceID();

            if(_currentID != id)
            {
                _currentID = id;
                _currentObject = hit.collider.gameObject;
                string name = _currentObject.name;

                if(name == "ButtonPlay")
                {
                    Debug.Log("Hit Play");
                }

                string tag = _currentObject.tag;

                if(tag == "Button")
                {
                    Debug.Log("HIT BUTTON");
                }
            }
        }
    }
}
