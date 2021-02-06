using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] Text title;
    [SerializeField] Text description;
    [SerializeField] Image buttonImage;
    [SerializeField] DialogueSO defaultDialogueSO;

    public static DialogueManager Instance { get; private set; }

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

    void Start()
    {
        RefreshDialogueContent(defaultDialogueSO); 
    }

    public void ShowDialogue()
    {
        canvas.SetActive(true);
    }

    public void HideDialogue()
    {
        canvas.SetActive(false);
    }

    public void RefreshDialogueContent(DialogueSO newContent)
    {
        title.text = newContent.Title;
        description.text = newContent.Description;
        //if (CharacterInteraction.Instance != null && newContent.ButtonSprite.Length > 0)
        //    buttonImage.sprite = newContent.ButtonSprite[CharacterInteraction.Instance.GetControllerId()];
        //else
        //    buttonImage.sprite = null;
    }
}
