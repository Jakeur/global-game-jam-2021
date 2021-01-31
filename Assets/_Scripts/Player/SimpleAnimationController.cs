using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimationController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // OnPlayerMove();
        float h = Input.GetAxis("Horizontal");
        animator.SetFloat("Direction", h);
        float v = Input.GetAxis("Vertical");
        animator.SetFloat("Speed", v);
    }
}
