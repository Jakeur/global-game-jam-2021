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

    GamepadActions controls;

    bool opened = false;

    private void Awake()
    {
        controls = new GamepadActions();
    }

    private void OnEnable()
    {
        controls.Menu.Enable();
    }

    private void OnDisable()
    {
        UnsetControls();
    }

    private void OnChooseStage(StageDirection direction)
    {
        _waypoint.HandleKey(direction);
        UnsetControls();
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

    void UnsetControls()
    {
        controls.Menu.Up.performed -= ctx => OnChooseStage(StageDirection.UP);
        controls.Menu.Right.performed -= ctx => OnChooseStage(StageDirection.RIGHT);
        controls.Menu.Down.performed -= ctx => OnChooseStage(StageDirection.DOWN);
        controls.Menu.Left.performed -= ctx => OnChooseStage(StageDirection.LEFT);
        controls.Menu.Disable();
    }

    void SetArrowImages()
    {
        ResetArrows();

        foreach (StageTransition transition in _waypoint.Transitions)
        {
            switch (transition.GetDirection(CameraAnimationManager.Instance.CurrentStage))
            {
                case StageDirection.UP:
                    upArrow.color = enabledcolor;
                    controls.Menu.Up.performed += ctx => OnChooseStage(StageDirection.UP);
                    break;
                case StageDirection.DOWN:
                    downArrow.color = enabledcolor;
                    controls.Menu.Up.performed += ctx => OnChooseStage(StageDirection.DOWN);
                    break;
                case StageDirection.LEFT:
                    leftArrow.color = enabledcolor;
                    controls.Menu.Up.performed += ctx => OnChooseStage(StageDirection.LEFT);
                    break;
                case StageDirection.RIGHT:
                    rightArrow.color = enabledcolor;
                    controls.Menu.Up.performed += ctx => OnChooseStage(StageDirection.RIGHT);
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
