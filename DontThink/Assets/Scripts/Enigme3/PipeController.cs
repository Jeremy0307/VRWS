using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    [SerializeField] private GameObject[] _pipes = null;
    [SerializeField] private GameObject[] _snapZones = null;

    [SerializeField] private ETuyauEnum _type = ETuyauEnum.none;

    public ETuyauEnum Type => _type; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
