using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    Vector2 mouseLook;
    Vector2 smoothV;

    [SerializeField] float sensitivity = 5f;
    [SerializeField] float smoothing = 2f;

    GameObject character;

    void Start()
    {
        character = this.transform.parent.gameObject;    
    }

    void Update()
    {
        processRotation();
    }

    private void processRotation()
    {
        var vectorMD = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        smoothV.x = Mathf.Lerp(smoothV.x, vectorMD.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, vectorMD.y, 1f / smoothing);
        mouseLook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
    }
}
