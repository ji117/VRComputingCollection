using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMenuScript : MonoBehaviour
{
    [SerializeField] ShowCaseScript[] showcaseObjects;
    int size;

    public void Start()
    {
        size = showcaseObjects.Length;
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
}
