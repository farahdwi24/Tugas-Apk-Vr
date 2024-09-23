using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideandshow : MonoBehaviour
{
    private Renderer sphereRenderer;
    private Color newSphereColor;
    private float randomChannelOne, randomChannelTwo, randomChannelThree;

    public void showIt(GameObject obj)
    {
        obj.SetActive(true);
    }

     public void hideIt(GameObject obj)
    {
        obj.SetActive(false);
    }
    
     public void ChangeColor(GameObject obj)
    {
        sphereRenderer = obj.GetComponent<Renderer>();
        randomChannelOne = Random.Range(0f,1f);
        randomChannelTwo = Random.Range(0f,1f);
        randomChannelThree = Random.Range(0f,1f);
        newSphereColor = new Color(randomChannelOne,randomChannelTwo,randomChannelThree,1f);

        sphereRenderer.material.SetColor("_Color", newSphereColor);
        
    }
}
