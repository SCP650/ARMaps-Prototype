using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartTesting());
    }

    IEnumerator StartTesting()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3,10));
            SpawningManager.Instance.SpawnObject(Random.Range(0,4), Random.Range(0,3), new Vector3(1, 0, 0));

        }

    }
}
