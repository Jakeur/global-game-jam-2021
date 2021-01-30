using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This script is automatically adding to a menuPannel. 
/// It controls a basic menu of a game with differents options.
/// Code optimisation can be realised for the back option.
/// </summary>
public class MainMenu : MonoBehaviour
{
    /// Public variables.
    [Header("Canvas")]
    public GameObject OptionUI;

    public string sceneToLoad = "Axel_Scene";

    /// <summary> Function called to play the game. </summary>
    public void PlayGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    /// <summary> Function called to play the game. </summary>
    public void PlayTutorial()
    {
        SceneManager.LoadScene("Tutorial");
        Manager.manager.actualTime = 1;
    }

    /// <summary> Function called to open the menu option. </summary>
    public void Option()
    {
        OptionUI.SetActive(true);
    }

    /// <summary> Function called to return in the menu option. </summary>
    public void BackOption()
    {
        OptionUI.SetActive(false);
    }

    /// <summary> Function called to leave the game. </summary>
    public void ExitGame()
    {
        Application.Quit();
    }
}
