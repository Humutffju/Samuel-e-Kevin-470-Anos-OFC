using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisicaCam : MonoBehaviour
{
    Vector3 M;
    Vector3 C;
    double P;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movi();
        Girar();
        C.y = 0f;
        C.x = 0;
        C.z = 0;
    }

    private void Movi()
    {
        if (Input.GetKey(KeyCode.W))
        {
            C.x = 0f;
            C.y = 0f;
            C.z += 0.0025f;
            transform.Translate(C);
        }
        if (Input.GetKey(KeyCode.S))
        {
            C.x = 0f;
            C.y = 0f;
            C.z += -0.0025f;
            transform.Translate(C);
        }
    }
    private void Girar()
    {
        if (Input.GetKey(KeyCode.A))
        {
            C.x = 0f;
            C.y = -0.15f;
            C.z += 0f;
            transform.Rotate(C);
        }
        if (Input.GetKey(KeyCode.D))
        {
            C.x = 0f;
            C.y = 0.15f;
            C.z += 0f;
            transform.Rotate(C);
        }
    }
}
