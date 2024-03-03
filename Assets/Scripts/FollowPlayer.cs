using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    private Vector3 offset = new Vector3(0, 2, -10);
    public Vector3 posCam;
    private void Start()
    {
        posCam = player.transform.position;
    }
    void Update()
    {
        posCam = player.transform.position;
        transform.position = posCam + offset;
    }
}
