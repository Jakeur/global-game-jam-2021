using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipItemManager : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] Text title;
    [SerializeField] Image itemImage;
    [SerializeField] Image equipButtonImage;
    [SerializeField] Image cancelButtonImage;
    [SerializeField] Sprite[] equipSpriteResource;
    [SerializeField] Sprite[] cancelSpriteResource;

    public static EquipItemManager Instance { get; private set; }

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

    void Awake()
    {
        CreateInstance();
    }

    public void ShowInventory()
    {
        canvas.SetActive(true);
    }

    public void HideInventory()
    {
        canvas.SetActive(false);
    }

    public void RefreshInventoryUiContent(ArmUiSO tradeContent)
    {
        title.text = tradeContent.Name;
        itemImage.sprite = tradeContent.Sprite;
        if (CharacterInteraction.Instance != null)
        {
            equipButtonImage.sprite = equipSpriteResource[CharacterInteraction.Instance.GetControllerId()];
            cancelButtonImage.sprite = cancelSpriteResource[CharacterInteraction.Instance.GetControllerId()];
        }
    }
}
