using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadewithProb : MonoBehaviour
{
    public AnimationCurve prob;
    public MeshRenderer[] meshes;
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
            float val = prob.Evaluate(t / maxFadeTime);
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
