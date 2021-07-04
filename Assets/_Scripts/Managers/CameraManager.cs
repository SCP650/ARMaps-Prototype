using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] Transform PlayerHead;
    [SerializeField] Transform BlueCarObject;

   public void SwitchCameraView()
    {
        PlayerHead.SetParent(BlueCarObject);
    }
}
