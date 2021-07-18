using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class GameManager : GenericSingletonClass<GameManager>
{
    public int CarNum;
    public GameObject Player;

    public void GoToVRScene()
    {
        SteamVR_LoadLevel.Begin(SceneNames.VRScene);
        Messenger.Broadcast("ZoomUpMap");
        //SceneManager.LoadScene(SceneNames.VRScene);
    
    }

    public void GoToARScene()
    {
        SteamVR_LoadLevel.Begin(SceneNames.ARScene);
        //SceneManager.LoadScene(SceneNames.ARScene);
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