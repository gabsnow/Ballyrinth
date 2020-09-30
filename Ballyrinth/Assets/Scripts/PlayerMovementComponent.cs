using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementComponent : MonoBehaviour
{
    public KeyCode[] movementKeys;

    // transformations faits avec temps réel
    // vitesse * Time.deltaTime
    public float movementSpeed = 10f;
    public float turnSpeed = 180f;
    public bool bJumpPressed;

    private Action[] commands = null;

    private Quaternion CameraRotation;

    private void Advance(float value)
    {
        transform.Translate(Vector3.forward * value * Time.deltaTime, Space.Self);

        //transform.Rotate(Vector3.right * value * Time.deltaTime, Space.Self);
        //GetComponent<Camera>().transform.LookAt(gameObject.transform);
    }

    private void TurnRight(float value)
    {
        transform.Rotate(Vector3.up * value * Time.deltaTime, Space.World);
    }

    private void Jump()
    {

        if (!bJumpPressed)
        {
            bJumpPressed = true;
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 7.5f, 0), ForceMode.Impulse);
        }

        Debug.Log("We jump");
    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            if (contact.otherCollider.name != "Lava-Ground")
            {
                bJumpPressed = false;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //if (UnityEditor.SceneView.lastActiveSceneView.camera != null)
        //{
        //    CameraRotation = UnityEditor.SceneView.lastActiveSceneView.camera.transform.rotation;
        //    Debug.Log("NOT NULL");
        //}            
        CreateCommands();
        Debug.Assert(commands.Length == movementKeys.Length);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < movementKeys.Length; i++)
            if (Input.GetKey(movementKeys[i]))
                commands[i].Invoke();


        //UnityEditor.SceneView.lastActiveSceneView.camera.transform.rotation = CameraRotation;
    }

    private void CreateCommands()
    {
        commands = new Action[]{
            () => Advance(movementSpeed),
            () => TurnRight(-turnSpeed),
            () => Advance(-movementSpeed),
            () => TurnRight(turnSpeed),
            () => Jump()
        };
    }
}
