using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 previusCameraPos;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
        previusCameraPos = cameraTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float deltaX = cameraTransform.position.x - previusCameraPos.x * delay;
        transform.Translate(new Vector3(deltaX, 0, 0));
        previusCameraPos = cameraTransform.position;
    }
}
