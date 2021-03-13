using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{

    [SerializeField] private string[] _keys = null;
    [SerializeField] private Trigger2 _trigger = null;

    [SerializeField] private Light _lightSuccess = null;

    private GameObject _currentPatern = null;
    private string _currentString = string.Empty;
    private string _updatedKey = string.Empty;

    

    public string UpdatedKey
    {
        get => _updatedKey;
        set => _updatedKey = value;
    }

    void Start()
    {
        _currentString = _keys[_trigger.Index];
    }

    // Update is called once per frame
    void Update()
    {
        if(_trigger.Index == 0)
        {
            if(_updatedKey.Length >= 1 && _updatedKey != "O")
            {
                Debug.Log("WRONG !");
                Reset();
            }

            if (_updatedKey.Length >= 2 && _updatedKey != "OW")
            {
                Debug.Log("WRONG !");
                Reset();
            }

            if (_updatedKey.Length >= 3 && _updatedKey != "OWX")
            {
                Debug.Log("WRONG !");
                Reset();
            }

            if (_updatedKey.Length >= 4 && _updatedKey != "OWX7")
            {
                Debug.Log("WRONG !");
                Reset();
            }

            if (_updatedKey.Length >= 5 && _updatedKey != "OWX7A")
            {
                Debug.Log("WRONG !");
                Reset();
            }
        }

        if (_trigger.Index == 1)
        {
            if (_updatedKey.Length >= 1 && _updatedKey != "D")
            {
                Debug.Log("WRONG !");
                Reset();
            }

            if (_updatedKey.Length >= 2 && _updatedKey != "DR")
            {
                Debug.Log("WRONG !");
                Reset();
            }

            if (_updatedKey.Length >= 3 && _updatedKey != "DRS")
            {
                Debug.Log("WRONG !");
                Reset();
            }

            if (_updatedKey.Length >= 4 && _updatedKey != "DRSM")
            {
                Debug.Log("WRONG !");
                Reset();
            }

            if (_updatedKey.Length >= 5 && _updatedKey != "DRSM3")
            {
                Debug.Log("WRONG !");
                Reset();
            }
        }

        if (_trigger.Index == 2)
        {
            if (_updatedKey.Length >= 1 && _updatedKey != "Z")
            {
                Debug.Log("WRONG !");
                Reset();
            }

            if (_updatedKey.Length >= 2 && _updatedKey != "Z8")
            {
                Debug.Log("WRONG !");
                Reset();
            }

            if (_updatedKey.Length >= 3 && _updatedKey != "Z8H")
            {
                Debug.Log("WRONG !");
                Reset();
            }

            if (_updatedKey.Length >= 4 && _updatedKey != "Z8HL")
            {
                Debug.Log("WRONG !");
                Reset();
            }

            if (_updatedKey.Length >= 5 && _updatedKey != "Z8HL2")
            {
                Debug.Log("WRONG !");
                Reset();
            }
        }

        if (_updatedKey.Length >= 5)
        {
            UpdatingWord();
        }
    }

    public void UpdatingWord()
    {
        if (_updatedKey == _currentString)
        {
            //Play Sound

            //Change la couleur de la light

            _lightSuccess.color = Color.green;

            Debug.Log("We did it !");
            _updatedKey = string.Empty;
        }
    }

    private void Reset()
    {
        _updatedKey = string.Empty;
        _trigger.Reset();
        _currentString = _keys[_trigger.Index];
    }
}
