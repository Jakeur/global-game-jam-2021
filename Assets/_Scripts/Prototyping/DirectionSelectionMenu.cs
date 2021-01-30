using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DirectionSelectionMenu : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] Image upArrow;
    [SerializeField] Image downArrow;
    [SerializeField] Image leftArrow;
    [SerializeField] Image rightArrow;

    [SerializeField] Color disabledColor;
    [SerializeField] Color enabledcolor;

    private Waypoint _waypoint;
    [SerializeField] private List<KeyCode> authorizedKeys;

    bool opened = false;

    private void Update()
    {
        if (opened)
        {
            foreach (KeyCode key in authorizedKeys)
            {
                if (Input.GetKeyDown(key))
                {
                    _waypoint.HandleKey(key);
                    Close();
                    break;
                }
            }
        }
    }

    public void Open(Waypoint waypoint)
    {
        _waypoint = waypoint;
        authorizedKeys = new List<KeyCode>();
        menu.SetActive(true);
        SetArrowImages();
        opened = true;
    }

    void SetArrowImages()
    {
        ResetArrows();

        foreach (StageTransition transition in _waypoint.Transitions)
        {
            switch (transition.GetDirection(CameraAnimationManager.Instance.CurrentStage))
            {
                case KeyCode.UpArrow:
                    upArrow.color = enabledcolor;
                    authorizedKeys.Add(KeyCode.UpArrow);
                    break;
                case KeyCode.DownArrow:
                    downArrow.color = enabledcolor;
                    authorizedKeys.Add(KeyCode.DownArrow);
                    break;
                case KeyCode.LeftArrow:
                    leftArrow.color = enabledcolor;
                    authorizedKeys.Add(KeyCode.LeftArrow);
                    break;
                case KeyCode.RightArrow:
                    rightArrow.color = enabledcolor;
                    authorizedKeys.Add(KeyCode.RightArrow);
                    break;
            }
        }
    }

    void ResetArrows()
    {
        upArrow.color = disabledColor;
        downArrow.color = disabledColor;
        leftArrow.color = disabledColor;
        rightArrow.color = disabledColor;
    }

    public void Close()
    {
        menu.SetActive(false);
        opened = false;
        authorizedKeys.Clear();
    }
}
