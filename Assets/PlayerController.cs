using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float inputx;
    public float inputy;
    void Start()
    {
        animator =this.gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        inputx = Input.GetAxis("Horizontal");
        inputy = Input.GetAxis("Vertical");
        animator.SetFloat("inputx", inputx);
        animator.SetFloat("inputy", inputy);
    }
}
