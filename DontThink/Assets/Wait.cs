using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(WaitSeconds());
    }

    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(1.1f);
        SceneManager.LoadScene(1);
    }
}
