using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moves : MonoBehaviour
{
    public float speed = 5.0f;
    public float boundaryX = 5.0f;
    public float boundaryZ = 5.0f;

    void Update()
    {
        float mX = Input.GetAxis("Horizontal");
        float mZ = Input.GetAxis("Vertical");

        Vector3 newPosition = transform.position + new Vector3(mX * speed * Time.deltaTime, 0, mZ * speed * Time.deltaTime);

        newPosition.x = Mathf.Clamp(newPosition.x, -boundaryX, boundaryX);
        newPosition.z = Mathf.Clamp(newPosition.z, -boundaryZ, boundaryZ);

        transform.position = newPosition;
    }
}