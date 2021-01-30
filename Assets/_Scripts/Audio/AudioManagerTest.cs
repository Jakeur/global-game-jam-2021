using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerTest : MonoBehaviour
{
    [Header("SFX")]
    [SerializeField] AudioClip slingshot;
    [SerializeField] AudioClip slingshotHit;
    [SerializeField] AudioClip saw;
    [SerializeField] AudioClip taser;
    [SerializeField] AudioClip equipArm;
    [SerializeField] AudioClip interact;

    [Header("Music")]
    [SerializeField] AudioClip music1;
    [SerializeField] AudioClip music2;

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Instance.PlayMusic(music1);
        AudioManager.Instance.SetMusicVolume(0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
