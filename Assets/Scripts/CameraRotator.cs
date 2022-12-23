using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public Transform cameraPivot; // Во круг чего вращаемся
    public float mouseSensivity = 3.0f; // Коэффициент
    public float dist = 10f; // Дистанция до объекта во круг которого будем вращаться
    private Vector2 posOnSphere = Vector2.up;

  

    private void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        posOnSphere.x -= mouseSensivity * Mathf.Deg2Rad * Input.GetAxis("Mouse X");
        posOnSphere.y -= mouseSensivity * Mathf.Deg2Rad * Input.GetAxis("Mouse Y");

        transform.position = SphericalCoodinateSystem(dist, posOnSphere) + cameraPivot.position;
        transform.LookAt(cameraPivot, Vector3.up);
    }

    public Vector3 SphericalCoodinateSystem(float r, Vector2 pos)
    {
        return new Vector3(r * Mathf.Sin(pos.y) * Mathf.Cos(pos.x), r * Mathf.Cos(pos.y), r * Mathf.Sin(pos.y) * Mathf.Sin(pos.x));
    }
  
}
