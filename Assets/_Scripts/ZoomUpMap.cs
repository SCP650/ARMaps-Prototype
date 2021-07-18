using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomUpMap : MonoBehaviour
{
    public Transform map;
    public float speed = 3;
    public bool isZooming;
    // Start is called before the first frame update
    void Start()
    {
        Messenger.AddListener("ZoomUpMap", ZoomUp);       
    }

    private void ZoomUp()
    {
        isZooming = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (isZooming)
        {
            map.localScale += map.localScale* speed * Time.deltaTime;
        }
    }
}
