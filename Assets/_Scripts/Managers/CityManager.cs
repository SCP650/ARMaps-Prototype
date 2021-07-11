using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityManager : MonoBehaviour
{
    public GameObject[] Cars;
    private void Start()
    {
        UpdatePlayerLocation();
    }

    public void UpdatePlayerLocation()
    {
        Debug.Log("Try to change location");
        GameObject player =  GameObject.FindGameObjectsWithTag("Player")[0];
        if (player)
        {
            player.transform.parent = Cars[GameManager.Instance.CarNum].transform;
            player.transform.localPosition = Vector3.zero;
        }
    }
}
