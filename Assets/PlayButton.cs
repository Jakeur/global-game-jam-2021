using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] string[] scenes;

    void Start()
    {
        PlayGame();
    }

    /// <summary> Function called to play the game. </summary>
    public void PlayGame()
    {
        StartCoroutine(LoadScenes());
    }

    IEnumerator LoadScenes()
    {
        foreach (string scene in scenes)
        {
            yield return SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
        }
    }
}
