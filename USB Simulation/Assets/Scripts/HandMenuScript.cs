using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandMenuScript : MonoBehaviour
{
    [SerializeField] ShowCaseScript[] showcaseObjects;
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject textSizeMenu;
    [SerializeField] GameObject helpMenu;
    GameObject currentMenu;
    int size;

    public void Start()
    {
        size = showcaseObjects.Length;
        currentMenu = mainMenu;
    }

    public void LargeTextSize()
    {
        for (int i = 0; i < size; i++)
        {
            showcaseObjects[i].ChangeTextSizeL();
        }
    }

    public void MediumTextSize()
    {
        for (int i = 0; i < size; i++)
        {
            showcaseObjects[i].ChangeTextSizeM();
        }
    }

    public void SmallTextSize()
    {
        for (int i = 0; i < size; i++)
        {
            showcaseObjects[i].ChangeTextSizeS();
        }
    }

    public void ShowCurrentMenu()
    {
        currentMenu.SetActive(true);
    }

    public void HideCurrentMenu()
    {
        currentMenu.SetActive(false);
    }

    public void ChangeMenuToMain()
    {
        currentMenu.SetActive(false);
        currentMenu = mainMenu;
        currentMenu.SetActive(true);
    }
    public void ChangeMenuToTextSize()
    {
        currentMenu.SetActive(false);
        currentMenu = textSizeMenu;
        currentMenu.SetActive(true);
    }

    public void ChangeMenuToHelp()
    {
        currentMenu.SetActive(false);
        currentMenu = helpMenu;
        currentMenu.SetActive(true);
    }

    public void BackToStart()
    {
        SceneManager.LoadScene(1);
    }

}
