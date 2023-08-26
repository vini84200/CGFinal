using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct MaterialKey
{
    public string materialKey;
    public GameObject gameObject;
}

public class SceneController : MonoBehaviour
{
    // List of all the game objects in the scene and their material key 
    // Accessible from the inspector
    public List<MaterialKey> gameObjects;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
