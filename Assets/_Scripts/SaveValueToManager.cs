using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveValueToManager : MonoBehaviour
{
   public void SetCarValue(int carNum)
    {
        GameManager.Instance.CarNum = carNum;
        GameManager.Instance.GoToVRScene();
    }

    
}
