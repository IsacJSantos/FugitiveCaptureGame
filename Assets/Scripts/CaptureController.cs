using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureController : MonoBehaviour
{
    public FugitiveController fugitive;

    public void CaptureFugitive()
    {
        if (fugitive != null)     
        fugitive.Capture();
    }
}
