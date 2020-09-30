using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolComponent : MonoBehaviour
{
    public float Amplitude,Vitesse;
    private float MinLeft, MaxRight;
    private Vector3 movement;
    private bool ADroite;

    private void Awake()
    {
        movement.x = Vitesse * Time.deltaTime;
        MinLeft = transform.position.x - Amplitude;
        MaxRight = transform.position.x + Amplitude;
    }
    void Update()
    {
       
        if (!ADroite)
        {
            transform.Translate(movement, Space.World);
            if (transform.position.x >= MaxRight)
            {
                ADroite = true;
            }
        }
        else
        {
            transform.Translate(-movement, Space.World);
            if (transform.position.x <= MinLeft)
            {
                ADroite = false;
            }
        }
    }
}
