using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

/// <summary>
/// This script control parametters of all scripts.
/// Each time a new scene is creating, adding this script to the main camera.
/// </summary>
public class Manager : MonoBehaviour
{
    public static Manager manager;

    /// Public variables
    [Header("Speed time")]
    public int actualTime = 1;
    public bool gameIsPaused = false;
    public float timePassed = 0f;

    [Header("Audio")]
    [Range(0.01f,1.0f)]
    public float myVolume;
    public bool mute;

    [Header("Screen resolution")]
    public int resolutionX;
    public int resolutionY;
    [Range(0, 5)]
    public int qualityIndex;

    public string currentWorld;
    public HashSet<string> players;

    public bool replay;

    private AudioSource source;

    private void Awake()
    {
        replay = false;
        manager = this;
        DontDestroyOnLoad(this);

        players = new HashSet<string>();
    }

    private void Update()
    {
        source = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();
        Time.timeScale = actualTime;
        source.volume = myVolume;
        Screen.SetResolution(resolutionX, resolutionY, true);
    }

}
