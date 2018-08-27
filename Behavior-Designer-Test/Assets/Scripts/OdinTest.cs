using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdinTest : MonoBehaviour
{
    [MinValue(5)]
    public int age;
    public List<string> nages;
    public Vector3 pos;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}