using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SwitchMapMode : MonoBehaviour
{
    public GameObject CircularMap;
    public GameObject ScaleMap;
    private bool isRotate = true;
    // Start is called before the first frame update
    public void SwitchMap()
    {
        isRotate = !isRotate;
        if (isRotate)
        {
            CircularMap.SetActive(true);
            ScaleMap.SetActive(false);
        }
        else
        {
            ScaleMap.transform.parent = gameObject.transform;
            ScaleMap.transform.localPosition = Vector3.zero;
            ScaleMap.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            ScaleMap.transform.eulerAngles = Vector3.zero;
            CircularMap.SetActive(false);
            ScaleMap.SetActive(true);
        }

    }
}
