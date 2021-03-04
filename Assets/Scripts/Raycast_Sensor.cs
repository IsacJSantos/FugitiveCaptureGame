using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_Sensor : MonoBehaviour
{
    RaycastHit2D _hitInfo;
    [SerializeField]
    LayerMask _layerMask;
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckRaycast(Input.mousePosition);
        }

    }

    void CheckRaycast(Vector3 origin) 
    {
        _hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(origin), Vector3.forward, 2f, _layerMask);
        if (_hitInfo.collider)
        {
            try
            {
                _hitInfo.collider.GetComponent<FugitiveController>().Capture();
            }
            catch (NullReferenceException)
            {
                // play a fx
            }

        }
    }
}
