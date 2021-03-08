using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void LoadLevel()
   {
        Debug.Log("Accès au prochain lvl");
   }

    public void QuitApplicaition()
    {
        Application.Quit();
    }
}
