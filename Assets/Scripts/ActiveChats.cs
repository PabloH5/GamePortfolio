using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveChats : MonoBehaviour
{
    [SerializeField]
    private GameObject activeObject;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            activeObject.SetActive(true);
        }
    }
}
