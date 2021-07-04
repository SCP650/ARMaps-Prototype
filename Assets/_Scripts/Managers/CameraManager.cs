using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] Transform PlayerHead;
    [SerializeField] Transform BlueCarObject;
    [SerializeField] GameObject[] VRObjs;

    public void SwitchCameraView()
    {
        DeactivateVR();
        PlayerHead.SetParent(BlueCarObject);

    }
    private void DeactivateVR()
    {
        foreach (GameObject i in VRObjs)
        {
            i.SetActive(false);
        }

    }
}
