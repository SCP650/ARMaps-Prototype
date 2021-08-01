using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class GameManager : GenericSingletonClass<GameManager>
{
    public int CarNum;
    public GameObject Player;

    private void Start()
    {

        StartCoroutine("ShowAlert");
    }


    public void GoToVRScene()
    {
        SteamVR_LoadLevel.Begin(SceneNames.VRScene);
        Messenger.Broadcast(GameEvents.ZoomUpMap);
        //SceneManager.LoadScene(SceneNames.VRScene);
    
    }

    public void GoToARScene()
    {
        SteamVR_LoadLevel.Begin(SceneNames.ARScene);
        //SceneManager.LoadScene(SceneNames.ARScene);
    }

    private IEnumerator ShowAlert()
    {
        yield return new WaitForSeconds(10);
        Messenger<int>.Broadcast(GameEvents.AlertCar, 3);
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
    public const string AlertCar = "ALERTCAR";
    public const string ZoomUpMap = "ZoomUpMap";

}