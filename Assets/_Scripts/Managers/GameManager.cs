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