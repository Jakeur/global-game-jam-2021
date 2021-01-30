using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMoveCommand : Command
{
    private Rigidbody _rigidbody;
    private IMoveInput _move;
    private IRotationInput _rotation;
    private Transform _transform;
    private Coroutine _moveCoroutine;

    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _move = GetComponent<IMoveInput>();
        _transform = transform;
    }

    public override void Execute()
    {
        if (_moveCoroutine == null)
            _moveCoroutine = StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        Debug.Log("Move");
        // TODO Move to target direction
        yield return null;
    }
}
