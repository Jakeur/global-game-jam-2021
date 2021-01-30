using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This script is automatically adding to a pausePannel. 
/// It controls pause during the game and esc key is pressed.
/// </summary>
public class PauseMenu : MonoBehaviour
{
    [Header("Canvas")]
    public GameObject optionUI;

    private void Update()
    {       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Resume();
        }
    }

    /// <summary> Function called to continue the game. </summary>
    public void Resume()
    {       
        Manager.manager.gameIsPaused = !Manager.manager.gameIsPaused;
        gameObject.SetActive(Manager.manager.gameIsPaused);

        if (Manager.manager.gameIsPaused)
        {
            Manager.manager.actualTime = 0;
        }
        else
        {
            Manager.manager.actualTime = 1;
        }
    }

    /// <summary> Function called to replay the level. </summary>
    public void Replay()
    {
        Manager.manager.replay = true;
        Manager.manager.actualTime = 0;
        Manager.manager.timePassed = 0;
        Manager.manager.gameIsPaused = true;

        PlayerPrefs.DeleteKey("Spawn");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Resume();
    }

    /// <summary> Function called to change the game option. </summary>
    public void Option()
    {
        optionUI.SetActive(true);
    }

    /// <summary> Function called to back to the menu of the game. </summary>
    public void Menu()
    {
        Manager.manager.gameIsPaused = true;
        Manager.manager.actualTime = 0;
        SceneManager.LoadScene("Menu");
    }

    public void Next()
    {
        Manager.manager.gameIsPaused = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Resume();
    }

    /// <summary> Function called to leave the game. </summary>
    public void Quit()
    {
        Application.Quit();
    }
}
