using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public static CheckpointManager Instance { get; private set; }

    // Saved datas
    private GameObject playerLastCheckPoint = null;
    private Transform cameraTransform;
    private int lastStage;

    private void CreateInstance()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void InstantiateCheckpoint(GameObject player, Transform camTransform, int stage)
    {
        player.SetActive(false);
        playerLastCheckPoint = Instantiate(player);
        player.SetActive(true);
        cameraTransform = camTransform;
        lastStage = stage;
    }

    public void UpdateCheckpoint(GameObject player, Transform camTransform, int stage)
    {
        Destroy(playerLastCheckPoint.gameObject);
        player.SetActive(false);
        playerLastCheckPoint = Instantiate(player);
        player.SetActive(true);
        cameraTransform = camTransform;
        lastStage = stage;
    }

    public void RestoreLastCheckpoint(GameObject player)
    {
        CameraAnimationManager.Instance.CurrentStage = lastStage;

        // TODO Make a transition here
        Camera.main.transform.position = cameraTransform.position;
        Camera.main.transform.rotation = cameraTransform.rotation;

        // Player restore values
        playerLastCheckPoint.SetActive(true);
        player.GetComponent<HealthManager>().currentHealth = playerLastCheckPoint.GetComponent<HealthManager>().currentHealth;
        player.GetComponent<CharacterInventory>().LeftArm = playerLastCheckPoint.GetComponent<CharacterInventory>().LeftArm;
        player.GetComponent<CharacterInventory>().RightArm = playerLastCheckPoint.GetComponent<CharacterInventory>().RightArm;
        player.transform.position = playerLastCheckPoint.transform.position;
        player.transform.rotation = playerLastCheckPoint.transform.rotation;
        
        UpdateCheckpoint(player, cameraTransform, lastStage);
    }

    void Awake()
    {
        CreateInstance();
    }
}
