using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowCaseScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
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
}
