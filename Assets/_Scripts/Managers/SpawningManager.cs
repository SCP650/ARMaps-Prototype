using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningManager : GenericSingletonClass<SpawningManager>
{
    public GameObject[] detectableObjects;
    public GameObject[] cars;
    public Transform mapRoot;

    private List<(int, Vector3)> history = new List<(int, Vector3)>();

    public void SpawnObject(int carID, int objID, Vector3 location)
    {
        Debug.Log("Try to spown");
        GameObject obj = Instantiate(detectableObjects[objID],cars[carID].transform);
        obj.transform.localPosition = location;
        obj.transform.parent = mapRoot;
        obj.transform.localScale = Vector3.one;
        history.Add((objID, obj.transform.localPosition));
    }
}

