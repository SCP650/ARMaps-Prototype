using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : GenericSingletonClass<GameManager>
{
    public int CarNum;
    public GameObject Player;

    public void SetCarNumber(int num)
    {
        CarNum = num;
    }

    public void GoToVRScene()
    {
        SceneManager.LoadScene(SceneNames.VRScene);
    }

    public void GoToARScene()
    {
        SceneManager.LoadScene(SceneNames.ARScene);
    }

    // called zero
    void Awake()
    {
    }

    // called first
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // called second
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if(scene.name == SceneNames.VRScene)
        {
            Messenger.Broadcast(GameEvents.VRLoaded);
        }
  
    }

    // called third
    void Start()
    {
 
    }

    // called when the game is terminated
    void OnDisable()
    {
 
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

}

struct SceneNames
{
   public const string VRScene = "CityScene"; 
   public const string ARScene = "ARScene";
}

struct GameEvents
{
    public const string VRLoaded = "VRLoaded";

}