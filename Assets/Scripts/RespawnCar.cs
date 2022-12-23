using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCar : MonoBehaviour
{
    [SerializeField]
    private GameObject car;


    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            car.transform.position = new Vector3(51.43f, 23.73f, -28.17f);
        }
        
    }
}
