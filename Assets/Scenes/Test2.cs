using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    void Start()
    {
        var resource = Resources.Load<GameObject>("GameObject");
        GameObject.Instantiate(resource);

    }
}
