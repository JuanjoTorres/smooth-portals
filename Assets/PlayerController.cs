using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 2f;

    float xPosition, yPosition;

    void Update()
    {
        processTranslation();
    }

    private void processTranslation()
    {
        xPosition = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        yPosition = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(xPosition, 0f, yPosition);
    }
}
