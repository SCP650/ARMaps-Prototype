using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTester : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isRandon;
    public int setFixInterval;
    void Start()
    {
        StartCoroutine(StartTesting());
    }

    IEnumerator StartTesting()
    {
        if (isRandon)
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.Range(3, 10));
                SpawningManager.Instance.SpawnObject(Random.Range(0, 4), Random.Range(0, 7), new Vector3(1, 0, 0));

            }
        }
        else
        {
            int item = 0;
            while (true)
            {
                if(item >= 7)
                {
                    item = 0;
                }
                yield return new WaitForSeconds(setFixInterval);
                SpawningManager.Instance.SpawnObject(1, item, new Vector3(0.5f, 0, 0));
                item += 1;
            }
        }
    

    }
}
