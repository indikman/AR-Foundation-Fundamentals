using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaneToggler : MonoBehaviour
{
    private ARPlaneManager planeManager;

    private void Start()
    {
        planeManager = GetComponent<ARPlaneManager>();
    }

    public void TogglePlanes()
    {
        planeManager.enabled = !planeManager.enabled;

        if (planeManager.enabled)
        {
            SetPlanesActive(true);
        }
        else
        {
            SetPlanesActive(false);
        }
    }

    private void SetPlanesActive(bool isActive)
    {
        foreach(  var plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(isActive);
        }
    }
}
