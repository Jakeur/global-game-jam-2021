
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class Waypoint : MonoBehaviour
{
    [SerializeField] StageTransition[] transitions;

    public StageTransition[] Transitions => transitions;

    [SerializeField] private int stageId;
    public int StageId => stageId;

    //[SerializeField] GameObject gate;

    private bool triggerCamera;

    public bool TriggerCamera => triggerCamera;

    private void Awake()
    {
        if (transitions.Length > 0 && transitions[0].Key != KeyCode.None)
        {
            triggerCamera = true;
        }
        else
        {
            triggerCamera = false;
        }
    }

    public void HandleKey(KeyCode key)
    {
        int currentStage = CameraAnimationManager.Instance.CurrentStage;

        StageTransition transition = transitions.First(t => t.GetDirection(currentStage) == key);

        CameraAnimationManager.Instance.TriggerTransition(stageId + "to" + transition.EndPoint.StageId, transition.EndPoint);

        //gate.SetActive(false);
    }

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        gate.SetActive(true);
    //    }
    //}

    private void OnDrawGizmos()
    {
        SphereCollider col = GetComponent<SphereCollider>();

        Gizmos.color = Color.blue;

        Gizmos.DrawWireSphere(transform.position, col.radius);

        foreach (StageTransition transition in transitions)
        {
            if (transition.EndPoint != null)
                Gizmos.DrawLine(transform.position, transition.EndPoint.transform.position);
        }
    }
}