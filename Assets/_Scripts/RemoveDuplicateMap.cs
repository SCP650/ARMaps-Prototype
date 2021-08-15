using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

public class RemoveDuplicateMap : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    private void Start()
    {
        GameObject map = GameObject.FindGameObjectWithTag("Map");
        if (map != gameObject)
        {
            Destroy(map);
        }
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if ( scene.name == SceneNames.VRScene)
        {
            Interactable inter = gameObject.GetComponent<Interactable>();
       
            if (inter.attachedToHand)
            {
                inter.attachedToHand.DetachObject(gameObject, false);
            }
                
            Destroy(gameObject);
        }
          
    }

}
