using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardComponent : MonoBehaviour
{
    public float displacementPerSecond = 20;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * displacementPerSecond * Time.deltaTime, Space.Self);
    }
}
