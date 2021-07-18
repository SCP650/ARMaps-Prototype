using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    public SteamVR_Action_Boolean grabPinch;
    public SteamVR_Input_Sources inputSource = SteamVR_Input_Sources.Any;
    // Start is called before the first frame update
    void Start()
    {
        grabPinch.AddOnStateDownListener(TriggerDown, inputSource);
        //grabPinch.AddOnStateUpListener(TriggerUp, inputSource);
    }


   /** public void TriggerUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Trigger is up");
      
    }**/
    public void TriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        if (SceneManager.GetActiveScene().name == SceneNames.VRScene)
        {
            GameManager.Instance.GoToARScene();
        }
     
    }
}
