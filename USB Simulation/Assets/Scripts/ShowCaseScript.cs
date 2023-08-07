using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowCaseScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI title; 
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TextMeshProUGUI pageNumber;
    [SerializeField] TextMeshProUGUI imageCaption;
    [SerializeField] TextMeshProUGUI clipLength;
    [SerializeField] TextMeshProUGUI clipProgress;
    int page;
    int numOfPages;
    int numOfImages;
    int currentImage;
    float playBackProgress;
    float audioClipLength;
    float playBackPercentage;
    [SerializeField] Image image;
    [SerializeField] Sprite[] images;
    [SerializeField] string[] imageCaptions; 
    [SerializeField] AudioSource audioPlayer;
    [SerializeField] Canvas imageInfo;
    [SerializeField] Slider volumeControl;
    [SerializeField] Slider progressBar; 
    AudioClip audioClip;

    private void Start()
    {
        page = 1;
        currentImage = 0;
        numOfImages = images.Length;
        imageCaption.text = imageCaptions[currentImage];
        audioClip = audioPlayer.clip;
        audioClipLength = audioClip.length;
        title.text = this.name;
        text.text = text.text.Replace("\r", "");

        int minutes;
        int seconds;
        minutes = Mathf.FloorToInt(audioClipLength / 60);
        seconds = Mathf.RoundToInt(audioClipLength % 60);
        clipLength.text = minutes.ToString() + ":" + seconds.ToString();

    }

    private void Update()
    {
        numOfPages = text.textInfo.pageCount;
        DisplayPageNumbers();

        if (page > numOfPages)
        {
            page = numOfPages;
            if (page == 0)
                page = 1;
            text.pageToDisplay = page;
        }

        ProgressBar();
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

    public void ChangeTextSizeS()
    {
        text.fontSize = 24;

    }

    public void ChangeTextSizeM()
    {
        text.fontSize = 36;
    }

    public void ChangeTextSizeL()
    {
        text.fontSize = 48;
    }

    public void ProgressBar()
    {
        playBackProgress = audioPlayer.time;
        playBackPercentage = (playBackProgress / audioClipLength) * 100;
        progressBar.value = playBackPercentage;

        int minutes;
        int seconds;
        minutes = Mathf.FloorToInt(playBackProgress / 60);
        seconds = Mathf.RoundToInt(playBackProgress % 60);
        clipProgress.text = minutes.ToString() + ":" + seconds.ToString();
    }

    public void ProgressUpdate()
    {
        playBackPercentage = progressBar.value;
        audioPlayer.time = (playBackPercentage / 100) * audioClipLength;
    }
}
