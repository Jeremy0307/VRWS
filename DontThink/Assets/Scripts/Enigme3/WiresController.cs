using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class WiresController : MonoBehaviour
{

    [SerializeField] private GameObject[] _lights = null;

    [SerializeField] private Light _successLight = null;
    [SerializeField] private AudioSource _successSource = null;

    public void Reset()
    {

    }

    public void OnPress0(Hand hand)
    {
        _lights[0].SetActive(true);
        //Reset();

    }

    public void OnPress1(Hand hand)
    {
        _lights[1].SetActive(true);
        //Reset();

    }

    public void OnPress2(Hand hand)
    {
        _lights[2].SetActive(true);
        _successLight.color = Color.green;
        _successSource.Play(0);

    }
}

