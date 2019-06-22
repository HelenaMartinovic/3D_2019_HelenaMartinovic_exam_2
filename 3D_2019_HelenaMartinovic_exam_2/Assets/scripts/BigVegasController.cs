using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigVegasController : MonoBehaviour
{

    const float speed = 2f;

    void Update()
    {
        var currentPosition = transform.position;
        currentPosition.z += (speed * Time.deltaTime);
        transform.position = currentPosition;
    }
}
