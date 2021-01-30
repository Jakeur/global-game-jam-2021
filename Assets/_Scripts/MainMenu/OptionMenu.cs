using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This script control all option in the game.
/// It is possible to change all these options into the game or at the beginning.
/// </summary>
public class OptionMenu : MonoBehaviour
{
    /// Public variables.
    [Header("Gameobject")]   
    public InputField resolutionX;
    public InputField resolutionY;
    public Dropdown quality;
    public Slider newVolume;
    public Toggle isMute;

    /// Private variables
    private AudioSource source;
    private int resX; 
    private int resY; 

    /// Use parameters of the Manager when the scrpt is calling. 
    private void Start()
    {
        source = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();

        resX = Manager.manager.resolutionX;
        resolutionX.text = resX.ToString();
        resY = Manager.manager.resolutionY;
        resolutionY.text = resY.ToString();
        quality.value = Manager.manager.qualityIndex;
        newVolume.value = Manager.manager.myVolume;
        isMute.isOn = Manager.manager.mute;
    }

    private void Update()
    {
        SetQuality();

        SetVolume();
    }

    /// <summary> Set the quality (Medium by default). </summary>
    private void SetQuality()
    {
        Manager.manager.qualityIndex = quality.value;
        QualitySettings.SetQualityLevel(Manager.manager.qualityIndex);
    }

    /// <summary> Set the volume (Maximum by default). </summary>
    private void SetVolume()
    {
        if (isMute.isOn == true)
        {
            Manager.manager.myVolume = 0;
            Manager.manager.mute = true;
        }
        else
        {
            Manager.manager.myVolume = newVolume.value;
            source.volume = newVolume.value;
        }
    }

    /// <summary> Function called when the button "Change Resolution" is pressed. </summary>
    public void SetResolution()
    {
        if (resolutionX.text.Length > 0)
        {
            resX = int.Parse(resolutionX.text);
            Manager.manager.resolutionX = resX;
        }
        else
        {
            resX = Manager.manager.resolutionX;
            resolutionX.text = resX.ToString();
        }

        if (resolutionY.text.Length > 0)
        {
            resY = int.Parse(resolutionY.text);
            Manager.manager.resolutionY = resY;
        }
        else
        {
            resY = Manager.manager.resolutionY;
            resolutionY.text = resY.ToString();
        }
    }

    /// <summary> Function called when the button "Reset" is pressed. </summary>
    public void Back()
    {
        gameObject.SetActive(false);
    }

    /// <summary> Function called when the button "Reset" is pressed. </summary>
    public void ResetValues()
    {
        Manager.manager.myVolume = 1;
        Manager.manager.resolutionX = 1024;
        Manager.manager.resolutionY = 640;
        Manager.manager.qualityIndex = 2;
        Manager.manager.mute = false;

        resolutionX.text = Manager.manager.resolutionX.ToString();
        resolutionY.text = Manager.manager.resolutionY.ToString();
    }
}
