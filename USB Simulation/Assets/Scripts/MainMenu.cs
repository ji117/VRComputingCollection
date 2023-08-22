using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject main;
    [SerializeField] GameObject info; 
    public void StartApp()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeToInfo()
    {
        main.SetActive(false);
        info.SetActive(true);
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
