using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownComponent : MonoBehaviour
{
    public float Amplitude, Vitesse;
    private float MinLeft, MaxRight;
    private Vector3 movement;
    private bool EnHaut;

    private void Awake()
    {
        movement.y = Vitesse * Time.deltaTime;
        MinLeft = transform.position.y - Amplitude;
        MaxRight = transform.position.y + Amplitude;
    }
    void Update()
    {

        if (!EnHaut)
        {
            transform.Translate(movement, Space.World);
            if (transform.position.y >= MaxRight)
            {
                EnHaut = true;
            }
        }
        else
        {
            transform.Translate(-movement, Space.World);
            if (transform.position.y <= MinLeft)
            {
                EnHaut = false;
            }
        }
    }
}
