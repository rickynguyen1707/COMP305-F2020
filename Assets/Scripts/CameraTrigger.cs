﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    [SerializeField] private GameObject cameraToActivate;
    [SerializeField] private GameObject cameraOut;

    public VirtualCameraController vCamController;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            vCamController.TransitionTo(cameraToActivate);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            vCamController.TransitionTo(cameraOut);
        }
    }
}
