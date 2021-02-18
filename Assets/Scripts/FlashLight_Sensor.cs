using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashLight_Sensor : MonoBehaviour
{
    [SerializeField]
    private CaptureController captureController;
    [SerializeField]
    private Button captureButton;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Fugitive"))
        {
            captureController.fugitive = col.gameObject.GetComponent<FugitiveController>();
            captureButton.interactable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Fugitive"))
        {            
            captureController.fugitive = null;
            captureButton.interactable = false;
        }
    }
}
