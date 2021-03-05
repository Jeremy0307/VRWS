﻿using UnityEngine;
using Valve.VR.InteractionSystem;

public class EventTest : MonoBehaviour
{

    [SerializeField] private KeyboardManager _keyboardManager = null;

    private string _keyValue = string.Empty;

    public void OnPressA(Hand hand)
    {
        Debug.Log("A pressed");

        _keyValue = "A";

        if(_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressB(Hand hand)
    {
        Debug.Log("B pressed");

        _keyValue = "B";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }

    }

    public void OnPressC(Hand hand)

    {
        Debug.Log("C pressed");

        _keyValue = "C";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressD(Hand hand)
    {
        Debug.Log("D pressed");

        _keyValue = "D";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressE(Hand hand)
    {
        Debug.Log("E pressed");

        _keyValue = "E";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressF(Hand hand)
    {
        Debug.Log("F pressed");

        _keyValue = "F";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressG(Hand hand)
    {
        Debug.Log("G pressed");

        _keyValue = "G";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressH(Hand hand)
    {
        Debug.Log("H pressed");

        _keyValue = "H";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressI(Hand hand)
    {
        Debug.Log("I pressed");

        _keyValue = "I";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressJ(Hand hand)
    {
        Debug.Log("J pressed");

        _keyValue = "J";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressK(Hand hand)
    {
        Debug.Log("K pressed");

        _keyValue = "K";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressL(Hand hand)
    {
        Debug.Log("L pressed");

        _keyValue = "L";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressM(Hand hand)
    {
        Debug.Log("M pressed");

        _keyValue = "M";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressN(Hand hand)
    {
        Debug.Log("N pressed");

        _keyValue = "N";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressO(Hand hand)
    {
        Debug.Log("O pressed");

        _keyValue = "O";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressP(Hand hand)
    {
        Debug.Log("P pressed");

        _keyValue = "P";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressQ(Hand hand)
    {
        Debug.Log("Q pressed");

        _keyValue = "Q";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressR(Hand hand)
    {
        Debug.Log("R pressed");

        _keyValue = "R";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressS(Hand hand)
    {
        Debug.Log("S pressed");

        _keyValue = "S";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressU(Hand hand)
    {
        Debug.Log("U pressed");

        _keyValue = "U";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressV(Hand hand)
    {
        Debug.Log("V pressed");

        _keyValue = "V";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressW(Hand hand)
    {
        Debug.Log("W pressed");

        _keyValue = "W";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressX(Hand hand)
    {
        Debug.Log("X pressed");

        _keyValue = "X";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressY(Hand hand)
    {
        Debug.Log("Y pressed");

        _keyValue = "Y";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPressZ(Hand hand)
    {
        Debug.Log("Z pressed");

        _keyValue = "Z";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPress1(Hand hand)
    {
        Debug.Log("1 pressed");

        _keyValue = "1";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }

    }  public void OnPress2(Hand hand)
    {
        Debug.Log("2 pressed");

        _keyValue = "2";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPress3(Hand hand)
    {
        Debug.Log("3 pressed");

        _keyValue = "3";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPress4(Hand hand)
    {
        Debug.Log("4 pressed");

        _keyValue = "4";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPress5(Hand hand)
    {
        Debug.Log("5 pressed");

        _keyValue = "5";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPress6(Hand hand)
    {
        Debug.Log("6 pressed");

        _keyValue = "6";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPress7(Hand hand)
    {
        Debug.Log("7 pressed");

        _keyValue = "7";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPress8(Hand hand)
    {
        Debug.Log("8 pressed");

        _keyValue = "8";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }

    public void OnPress(Hand hand)
    {
        Debug.Log("9 pressed");

        Debug.Log(_keyboardManager.UpdatedKey);

        _keyValue = "9";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;

        }
    }
}