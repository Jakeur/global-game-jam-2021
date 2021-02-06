using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradeManager : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] Text title;
    [SerializeField] Text description;
    [SerializeField] Image itemImage;
    [SerializeField] Image acceptButtonImage;
    [SerializeField] Image declineButtonImage;
    [SerializeField] Sprite[] acceptSpriteResource;
    [SerializeField] Sprite[] declineSpriteResource;

    public static TradeManager Instance { get; private set; }

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

    public void ShowTrade()
    {
        canvas.SetActive(true);
    }

    public void HideTrade()
    {
        canvas.SetActive(false);
    }

    public void RefreshTradeContent(ArmUiSO tradeContent)
    {
        title.text = tradeContent.Name;
        description.text = tradeContent.Description;
        itemImage.sprite = tradeContent.Sprite;
        //if (CharacterInteraction.Instance != null)
        //{
        //    acceptButtonImage.sprite = acceptSpriteResource[CharacterInteraction.Instance.GetControllerId()];
        //    declineButtonImage.sprite = declineSpriteResource[CharacterInteraction.Instance.GetControllerId()];
        //}
    }
}
