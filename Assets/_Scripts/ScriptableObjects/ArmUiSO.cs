using UnityEngine;

[CreateAssetMenu(fileName = "ArmUiSO", menuName = "ScriptableObjects/Arm Item", order = 1)]
public class ArmUiSO : ScriptableObject
{
    public string Name;
    public string Description;
    public ArmType Type;
    public ArmSide Side;
    public Sprite Sprite;
}