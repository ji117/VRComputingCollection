using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowCaseScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int page;
    public int numOfPages;
    int numOfImages;
    int currentImage; 
    public Image image; 
    public Sprite[] images;
    public AudioSource audioPlayer;

    private void Start()
    {
        page = 1;
        numOfPages = text.textInfo.pageCount;

        currentImage = 0;
        numOfImages = images.Length;
    }

    private void Update()
    {
        
    }
    public void PageDown()
    {
        if (page != numOfPages)
        {
            page++;
            text.pageToDisplay = page;
        }
    }

    public void PageUp()
    {
        if (page != 1)
        {
            page--;
            text.pageToDisplay = page;
        }
    }

    public void ChangeImage()
    {
        currentImage++;
        if (currentImage < numOfImages)
        {
            image.sprite = images[currentImage];
        }
        else
        {
            currentImage = 0;
            image.sprite = images[currentImage];
        }
    }

    public void PlayRecording()
    {
        audioPlayer.Play();
    }

    public void PauseRecording()
    {
        audioPlayer.Pause();
    }

    public void StopRecording()
    {
        audioPlayer.Stop();
    }
}
