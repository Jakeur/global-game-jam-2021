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

    [SerializeField] InputReader inputReader;

    bool opened = false;

    private void OnEnable()
    {
        inputReader.chooseStageEvent += OnChooseStage;
    }

    private void OnDisable()
    {
        inputReader.chooseStageEvent -= OnChooseStage;
    }

    private void OnChooseStage(Vector2 vector)
    {
        KeyCode keyCode = KeyCode.None;

        if (!opened)
            return;

        if (vector.x > 0 && vector.y == 0)
            keyCode = KeyCode.RightArrow;
        else if (vector.x < 0 && vector.y == 0)
            keyCode = KeyCode.LeftArrow;
        else if (vector.y > 0 && vector.x == 0)
            keyCode = KeyCode.UpArrow;
        else if (vector.y < 0 && vector.x == 0)
            keyCode = KeyCode.DownArrow;

        _waypoint.HandleKey(keyCode);
        Close();

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
