using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainC;
    public Camera subC;
    bool Cam = true;

    void Start()
    {
        mainCameraOn();
    }

    private void mainCameraOn()
    {
        mainC.enabled = true;
        subC.enabled = false;
    }
    private void subCameraOn()
    {
        subC.enabled = true;
        mainC.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (Cam == true)
            {
                Cam = false;
                subCameraOn();
            }
            else
            {
                Cam = true;
                mainCameraOn();
            }
        }
    }
}
