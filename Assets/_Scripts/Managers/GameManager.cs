using System.Collections;
using System.Collections.Generic;
using Assets._Scripts.Tools;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class GameManager : GenericSingletonClass<GameManager>
{
    public int CarNum;

    private void Start()
    {

        //StartCoroutine("ShowAlert");
    }


    public void GoToVRScene()
    {
        GameObject player = GameObject.FindGameObjectsWithTag("Player")[0];
        var cameraFade = player.GetComponent<CameraBackgroundFade>();
        cameraFade.StartAnimation(new Color(0, 0, 0, 1));

        SteamVR_LoadLevel.Begin(SceneNames.VRScene);
        Messenger.Broadcast(GameEvents.ZoomUpMap);
        //SceneManager.LoadScene(SceneNames.VRScene);
    
    }
    public string GetCurrentSceneName()
    {
        return SceneManager.GetActiveScene().name;
    }

    public void GoToARScene()
    {
        SteamVR_LoadLevel.Begin(SceneNames.ARScene);
        //SceneManager.LoadScene(SceneNames.ARScene);


        GameObject player = GameObject.FindGameObjectsWithTag("Player")[0];
        var cameraFade = player.GetComponent<CameraBackgroundFade>();
        cameraFade.StartAnimation(new Color(0, 0, 0, 1));
    }

    //private IEnumerator ShowAlert()
    //{
    //    yield return new WaitForSeconds(10);
    //    Messenger<int>.Broadcast(GameEvents.AlertCar, 3);
    //}
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