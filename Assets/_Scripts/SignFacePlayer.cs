using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignFacePlayer : MonoBehaviour
{
    public Vector3 tuneVector;
    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.RotateTowards(transform.rotation, GameManager.Instance.playerHead.transform.rotation, 1f);
        //transform.LookAt(GameManager.Instance.playerHead,tuneVector);
        //Debug.Log(GameManager.Instance.playerHead);
    }
}
