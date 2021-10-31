using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FadewithProb : MonoBehaviour
{
    public AnimationCurve prob;
    public MeshRenderer[] meshes;
    public Gradient gradient;
    public TextMeshProUGUI text;
    public Image bg;
    public int maxFadeTime;

    private void Start()
    {
        StartCoroutine(StartFade());

    }
    IEnumerator StartFade()
    {
        float t = 0;
        while(t < maxFadeTime)
        {
            t += Time.deltaTime;
            float ratio = t / maxFadeTime;
            float val = prob.Evaluate(ratio);
            text.text = $"{Mathf.Round(val*100)}%";
            bg.color = gradient.Evaluate(ratio);
            foreach(MeshRenderer m in meshes){
                Color color = m.material.color;
                color.a = val;
                m.material.color = color;
                //Debug.Log(m.material.color);
            }
            yield return null;
        }
    }
}
