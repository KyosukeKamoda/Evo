/*作成者 鴨田*/
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Impulse : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 Axis;
    public float Magnitude;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.maxAngularVelocity = Mathf.Infinity;
        Force();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Force()
    {
        rb.AddForce(Axis * Magnitude, ForceMode.Impulse);
    }
}
