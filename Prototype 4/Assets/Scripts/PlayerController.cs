﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    private GameObject focalPoint;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float ForwardInput = Input.GetAxis("Vertical");
        rb.AddForce(focalPoint.transform.forward * speed * ForwardInput);
        // Vektor3 e göre değil odak noktamızın gösterdiği yöne doğru
    }
}
