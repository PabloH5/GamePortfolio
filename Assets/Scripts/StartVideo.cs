using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartVideo : MonoBehaviour
{
    private Animator anim;
    [SerializeField]
    private PabloController pablo;
    [SerializeField]
    private GameObject video;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("isClose", true);
            pablo.IsFinish = true;
            Invoke("PlayVideo", 1.5f);
        }
    }
    void PlayVideo()
    {
        video.SetActive(true);
    }
}
