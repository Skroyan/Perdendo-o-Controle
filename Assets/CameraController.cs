﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject focus;
    public float distance = 5f;
    public float height = 2f;
    public float dampening = 1f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, focus.transform.position + focus.transform.TransformDirection(new Vector3(0f, height, -distance)), (dampening*3) * Time.deltaTime);
        transform.LookAt(focus.transform);
    }
}