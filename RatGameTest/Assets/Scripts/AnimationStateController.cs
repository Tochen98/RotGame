using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("d") || Input.GetKey("s")) animator.SetBool("isRunning", true);
        else animator.SetBool("isRunning", false);
    }
}
