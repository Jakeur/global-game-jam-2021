using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public GameObject previousButton;
    public GameObject nextButton;

    private int worldIndex;
    private int numberOfWorld;
    private string world;

    private void Start()
    {
        worldIndex = 0;
        gameObject.transform.GetChild(worldIndex).gameObject.SetActive(true);
        numberOfWorld = gameObject.transform.childCount;
        CheckWorldPosition();
    }

    public void Back()
    {
        gameObject.SetActive(false);
    }

    public void LoadWorld()
    {
        Manager.manager.actualTime = 1;
        SceneManager.LoadScene(world);
        PlayerPrefs.DeleteKey("Spawn");
    }

    public void NextWorld()
    {
        if(worldIndex + 4 < numberOfWorld)
        {
            gameObject.transform.GetChild(worldIndex).gameObject.SetActive(false);            
            worldIndex += 1;
            gameObject.transform.GetChild(worldIndex).gameObject.SetActive(true);
            CheckWorldPosition();
        }
    }

    public void PreviousWorld()
    {
        if (worldIndex - 1 >= 0)
        {
            gameObject.transform.GetChild(worldIndex).gameObject.SetActive(false);
            worldIndex -= 1;
            gameObject.transform.GetChild(worldIndex).gameObject.SetActive(true);
            CheckWorldPosition();
        }
    }


    private void CheckWorldPosition()
    {
        if (worldIndex == 0)
        {
            previousButton.SetActive(false);
            nextButton.SetActive(true);
        }
        else if (worldIndex == numberOfWorld - 4)
        {
            previousButton.SetActive(true);
            nextButton.SetActive(false);
        }
        else
        {
            previousButton.SetActive(true);
            nextButton.SetActive(true);
        }
        world = gameObject.transform.GetChild(worldIndex).gameObject.name;
    }
}
