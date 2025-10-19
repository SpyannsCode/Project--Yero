using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] Transform _target;
    public float Distance = 5f;
    public float Sensitivity = 500f;
    public bool Camerarot = false;
    public float yaw = 0f;
    public float pitch = 90f;

    public float UpperLimit=90f;
    public float DownwardLimit = 15f;

    void Start()
    {
        transform.position = new Vector3(0, 10, 0);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            AllowRotateCamera();
        }
        if (Camerarot==true)
        {
            Inputer();
            Quaternion yawRotation = Quaternion.Euler(pitch, yaw, 0f);
            Rotater(yawRotation);
        }
    }

    public void Inputer()
    {
        Vector2 inputDelta = Vector2.zero;
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            inputDelta = touch.deltaPosition;
        }
        else if(Input.GetMouseButton(1))
        {
            inputDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        }
        yaw += inputDelta.x * Sensitivity * Time.deltaTime;
        pitch -= inputDelta.y * Sensitivity * Time.deltaTime;
        if (pitch >= UpperLimit)
            pitch = UpperLimit;
        if (pitch <= DownwardLimit)
            pitch = DownwardLimit;
        if (Input.GetKeyDown(KeyCode.R))
        {
            pitch = 90;
            yaw = 0;
        }
    }
    void Rotater(Quaternion rotation)
    {
        Vector3 positionoffset = rotation * new Vector3(0, 0, -Distance);
        transform.position = _target.position + positionoffset;
        transform.rotation = rotation;
    }
    private void AllowRotateCamera()
    {
        if (Camerarot == true)
        {
            Camerarot = false;
        }
        if (Camerarot == false)
        {
            Camerarot = true;
        }
    }
}
