using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan : MonoBehaviour
{
    [SerializeField] private int Speed = 2;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 position = transform.position;
            transform.position = new Vector3(position.x - Input.GetAxis("Mouse X") * Speed * Time.deltaTime, position.y, position.z - Input.GetAxis("Mouse Y") * Speed * Time.deltaTime);
        }
    }
}
