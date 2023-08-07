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
    [SerializeField] GameObject exhibitMenu;
    [SerializeField] GameObject exhibitMenu2;
    [SerializeField] GameObject group1;
    [SerializeField] GameObject group2;
    [SerializeField] GameObject group3;
    [SerializeField] GameObject group4;
    [SerializeField] GameObject group5;
    [SerializeField] GameObject group6;
    [SerializeField] GameObject group7;
    [SerializeField] GameObject group8;
    [SerializeField] GameObject group9;
    GameObject currentMenu;
    GameObject currentGroup; 
    int size;

    public void Start()
    {
        size = showcaseObjects.Length;
        currentMenu = mainMenu;
        currentGroup = group1;
    }

    public void LargeTextSize()
    {
        for (int i = 0; i < size; i++)
        {
            if (showcaseObjects[i].enabled == true)
                showcaseObjects[i].ChangeTextSizeL();
        }
    }

    public void MediumTextSize()
    {
        for (int i = 0; i < size; i++)
        {
            if (showcaseObjects[i].enabled == true)
                showcaseObjects[i].ChangeTextSizeM();
        }
    }

    public void SmallTextSize()
    {
        for (int i = 0; i < size; i++)
        {
            if (showcaseObjects[i].enabled == true)
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

    public void ChangeMenuToExhibit()
    {
        currentMenu.SetActive(false);
        currentMenu = exhibitMenu;
        currentMenu.SetActive(true);
    }

    public void ChangeMenuToExhibit2()
    {
        currentMenu.SetActive(false);
        currentMenu = exhibitMenu2;
        currentMenu.SetActive(true);
    }

    public void ChangeGroup1()
    {
        currentGroup.SetActive(false);
        currentGroup = group1;
        currentGroup.SetActive(true);
        
    }

    public void ChangeGroup2()
    {
        currentGroup.SetActive(false);
        currentGroup = group2;
        currentGroup.SetActive(true);
    }

    public void ChangeGroup3()
    {
        currentGroup.SetActive(false);
        currentGroup = group3;
        currentGroup.SetActive(true);
    }

    public void ChangeGroup4()
    {
        currentGroup.SetActive(false);
        currentGroup = group4;
        currentGroup.SetActive(true);
    }

    public void ChangeGroup5()
    {
        currentGroup.SetActive(false);
        currentGroup = group5;
        currentGroup.SetActive(true);
    }

    public void ChangeGroup6()
    {
        currentGroup.SetActive(false);
        currentGroup = group6;
        currentGroup.SetActive(true);
    }

    public void ChangeGroup7()
    {
        currentGroup.SetActive(false);
        currentGroup = group7;
        currentGroup.SetActive(true);
    }

    public void ChangeGroup8()
    {
        currentGroup.SetActive(false);
        currentGroup = group8;
        currentGroup.SetActive(true);
    }

    public void ChangeGroup9()
    {
        currentGroup.SetActive(false);
        currentGroup = group9;
        currentGroup.SetActive(true);
    }

    public void BackToStart()
    {
        SceneManager.LoadScene(1);
    }

}
