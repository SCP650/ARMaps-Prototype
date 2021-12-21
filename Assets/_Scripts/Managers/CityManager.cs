using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityManager : MonoBehaviour
{
    public GameObject[] Cars;

    public Vector3 CameraOffset = new Vector3(0, -0.4f, 0);
    public Vector3 CameraRotation = new Vector3(0, 0, 0);
    private void Start()
    {
        UpdatePlayerLocation();
    }

    public void UpdatePlayerLocation()
    {
  
        GameObject player =  GameObject.FindGameObjectsWithTag("Player")[0];
        if (player)
        {
            player.transform.parent = Cars[GameManager.Instance.CarNum].transform;
            //player.transform.localPosition = new Vector3(0,-0.4f,0);
            player.transform.localPosition = CameraOffset;
            player.transform.localRotation = Quaternion.Euler(CameraRotation);
        }
    }
}
