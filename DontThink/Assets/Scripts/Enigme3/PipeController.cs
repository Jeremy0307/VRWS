using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class PipeController : MonoBehaviour
{
    [SerializeField] private ETuyauEnum _type = ETuyauEnum.none;

    public ETuyauEnum Type => _type;

    private bool _snapable = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InHand()
    {
        _snapable = false;
    }

    public void OutHand()
    {
        _snapable = true;
    }

    public void Checking(GameObject pipe, GameObject zone)
    {
        Debug.Log("Les objets sont " + pipe.name + " et " + zone.name);

        if (pipe.name == "Pipe1" && zone.name == "Zone2" && _snapable == true)
        {
            pipe.SetActive(false);
            zone.GetComponent<MeshRenderer>().enabled = true;
        }

        if (pipe.name == "Pipe2" && zone.name == "Zone5" && _snapable == true)
        {
            pipe.SetActive(false);
            zone.GetComponent<MeshRenderer>().enabled = true;
        }

        if (pipe.name == "Pipe3" && zone.name == "Zone4" && _snapable == true)
        {
            pipe.SetActive(false);
            zone.GetComponent<MeshRenderer>().enabled = true;
        }

        if (pipe.name == "Pipe4" && zone.name == "Zone1" && _snapable == true)
        {
            pipe.SetActive(false);
            zone.GetComponent<MeshRenderer>().enabled = true;
        }

        if (pipe.name == "Pipe5" && zone.name == "Zone3" && _snapable == true)
        {
            pipe.SetActive(false);
            zone.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
