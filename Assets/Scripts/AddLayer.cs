using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLayer : MonoBehaviour
{
    public GameObject layer;
    public List<GameObject> childObject;
    private void OnEnable()
    {
        layer.SetActive(true);
    }

    private void OnDisable()
    {
        layer.SetActive(false);
        foreach(GameObject child in childObject)
            child.SetActive(false);
    }
}
