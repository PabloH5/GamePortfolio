using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetrerosAnim : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("isClose", true);
        }
    }
}
