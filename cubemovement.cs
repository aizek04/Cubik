using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Transform cubik;
    public float speed = 5;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            cubik.Translate(cubik.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            cubik.Translate(-cubik.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            cubik.Translate(-cubik.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            cubik.Translate(cubik.right * speed * Time.deltaTime);
        }
    }
}

