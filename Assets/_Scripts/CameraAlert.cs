using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraAlert : MonoBehaviour
{
    // Start is called before the first frame update
    public RawImage[] CarViewImages;
    public GameObject[] AlertIcons;
    public GameObject[] AlertButtons;

    void Start()
    {
        Messenger<int>.AddListener(GameEvents.AlertCar, AlertCamera);
    }
    private void OnDestroy()
    {
        Messenger<int>.RemoveListener(GameEvents.AlertCar, AlertCamera);
    }

    private void AlertCamera(int carNum)
    {
        StartCoroutine(FlashImage(CarViewImages[carNum]));
        AlertIcons[carNum].SetActive(true);
        AlertButtons[carNum].SetActive(true);

    }

    private IEnumerator FlashImage(RawImage selectedImage)
    {
        while (true)
        {
            selectedImage.color = Color.red;
            yield return new WaitForSeconds(1);
            selectedImage.color = Color.white;
            yield return new WaitForSeconds(1);
        }
     
    }

}
