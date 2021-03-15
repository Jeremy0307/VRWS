using UnityEngine;
using Valve.VR.InteractionSystem;

public class EventTest : MonoBehaviour
{

    [SerializeField] private KeyboardManager _keyboardManager = null;

    [SerializeField] private AudioSource _tapyingSound = null;

    private string _keyValue = string.Empty;

    public void OnPressA(Hand hand)
    {
        Debug.Log("A pressed");
        _tapyingSound.Play(0);
        _keyValue = "A";

        if(_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressB(Hand hand)
    {
        Debug.Log("B pressed");
        _tapyingSound.Play(0);
        _keyValue = "B";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);

    }

    public void OnPressC(Hand hand)

    {
        Debug.Log("C pressed");
        _tapyingSound.Play(0);
        _keyValue = "C";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressD(Hand hand)
    {
        Debug.Log("D pressed");
        _tapyingSound.Play(0);
        _keyValue = "D";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressE(Hand hand)
    {
        Debug.Log("E pressed");
        _tapyingSound.Play(0);
        _keyValue = "E";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressF(Hand hand)
    {
        Debug.Log("F pressed");
        _tapyingSound.Play(0);
        _keyValue = "F";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressG(Hand hand)
    {
        Debug.Log("G pressed");
        _tapyingSound.Play(0);
        _keyValue = "G";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressH(Hand hand)
    {
        Debug.Log("H pressed");
        _tapyingSound.Play(0);
        _keyValue = "H";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressI(Hand hand)
    {
        Debug.Log("I pressed");
        _tapyingSound.Play(0);
        _keyValue = "I";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressJ(Hand hand)
    {
        Debug.Log("J pressed");
        _tapyingSound.Play(0);
        _keyValue = "J";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressK(Hand hand)
    {
        Debug.Log("K pressed");
        _tapyingSound.Play(0);
        _keyValue = "K";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressL(Hand hand)
    {
        Debug.Log("L pressed");
        _tapyingSound.Play(0);
        _keyValue = "L";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressM(Hand hand)
    {
        Debug.Log("M pressed");
        _tapyingSound.Play(0);
        _keyValue = "M";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressN(Hand hand)
    {
        Debug.Log("N pressed");
        _tapyingSound.Play(0);
        _keyValue = "N";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressO(Hand hand)
    {
        Debug.Log("O pressed");
        _tapyingSound.Play(0);
        _keyValue = "O";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressP(Hand hand)
    {
        Debug.Log("P pressed");
        _tapyingSound.Play(0);
        _keyValue = "P";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressQ(Hand hand)
    {
        Debug.Log("Q pressed");
        _tapyingSound.Play(0);
        _keyValue = "Q";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressR(Hand hand)
    {
        Debug.Log("R pressed");
        _tapyingSound.Play(0);
        _keyValue = "R";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressS(Hand hand)
    {
        Debug.Log("S pressed");
        _tapyingSound.Play(0);
        _keyValue = "S";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressU(Hand hand)
    {
        Debug.Log("U pressed");
        _tapyingSound.Play(0);
        _keyValue = "U";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressV(Hand hand)
    {
        Debug.Log("V pressed");
        _tapyingSound.Play(0);
        _keyValue = "V";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressW(Hand hand)
    {
        Debug.Log("W pressed");
        _tapyingSound.Play(0);
        _keyValue = "W";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressX(Hand hand)
    {
        Debug.Log("X pressed");
        _tapyingSound.Play(0);
        _keyValue = "X";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressY(Hand hand)
    {
        Debug.Log("Y pressed");
        _tapyingSound.Play(0);
        _keyValue = "Y";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPressZ(Hand hand)
    {
        Debug.Log("Z pressed");
        _tapyingSound.Play(0);
        _keyValue = "Z";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPress1(Hand hand)
    {
        Debug.Log("1 pressed");
        _tapyingSound.Play(0);
        _keyValue = "1";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPress2(Hand hand)
    {
        Debug.Log("2 pressed");
        _tapyingSound.Play(0);
        _keyValue = "2";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPress3(Hand hand)
    {
        Debug.Log("3 pressed");
        _tapyingSound.Play(0);
        _keyValue = "3";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPress4(Hand hand)
    {
        Debug.Log("4 pressed");
        _tapyingSound.Play(0);
        _keyValue = "4";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPress5(Hand hand)
    {
        Debug.Log("5 pressed");
        _tapyingSound.Play(0);
        _keyValue = "5";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPress6(Hand hand)
    {
        Debug.Log("6 pressed");
        _tapyingSound.Play(0);
        _keyValue = "6";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPress7(Hand hand)
    {
        Debug.Log("7 pressed");
        _tapyingSound.Play(0);
        _keyValue = "7";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }

    public void OnPress8(Hand hand)
    {
        Debug.Log("8 pressed");
        _tapyingSound.Play(0);
        _keyValue = "8";

        if (_keyboardManager.UpdatedKey != null)
        {
            _keyboardManager.UpdatedKey = _keyboardManager.UpdatedKey + _keyValue;
        }

        Debug.Log("Actual key : " + _keyboardManager.UpdatedKey);
    }
}