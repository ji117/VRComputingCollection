using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowCaseScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TextMeshProUGUI pageNumber;
    [SerializeField] TextMeshProUGUI imageCaption;
    int page;
    int numOfPages;
    int numOfImages;
    int currentImage;
    [SerializeField] Image image;
    [SerializeField] Sprite[] images;
    [SerializeField] string[] imageCaptions; 
    [SerializeField] AudioSource audioPlayer;
    [SerializeField] Canvas imageInfo;
    [SerializeField] Slider volumeControl;

    private void Start()
    {
        page = 1;
        currentImage = 0;
        numOfImages = images.Length;
        imageCaption.text = imageCaptions[currentImage];
    }

    private void Update()
    {
        numOfPages = text.textInfo.pageCount;
        DisplayPageNumbers();
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
            imageCaption.text = imageCaptions[currentImage];
        }
        else
        {
            currentImage = 0;
            image.sprite = images[currentImage];
            imageCaption.text = imageCaptions[currentImage];
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

    public void ShowImageInfo()
    {
        imageInfo.enabled = !imageInfo.enabled;
    }

    public void ChangeVolume()
    {
        audioPlayer.volume = volumeControl.value;
    }

    public void DisplayPageNumbers()
    {
        pageNumber.text = "Page " + page.ToString() + " of " + numOfPages.ToString();
    }
}
