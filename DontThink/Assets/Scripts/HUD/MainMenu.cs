using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private GameObject _mainMenu = null;
    [SerializeField] private GameObject _InputsMenu = null;

   public void LoadLevel()
   {
        Debug.Log("Loading");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitApplicaition()
    {
        Application.Quit();
    }

    public void DisplayInputsUI()
    {
        _mainMenu.SetActive(false);
        _InputsMenu.SetActive(true);
    }

    public void DisplayMainMenu()
    {
        _mainMenu.SetActive(true);
        _InputsMenu.SetActive(false);
    }
}
