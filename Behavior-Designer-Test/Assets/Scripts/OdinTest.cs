using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdinTest : MonoBehaviour
{
    [MinValue(5)]
    public int age;
    public List<string> nages;
    public Vector3 pos;
    public bool isShowOJOEO;
    public bool isShowOJO;
    [ShowIf("isShowOJOEO")]
    public string owojog;
    public OJOofwe oJOofwe;
    [ShowInInspector()]
    public OJOEO oJOEO;
    public OJOEoihfowO oJOEoihfow;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}

public enum OJOofwe
{
    ABD,
    OJE,
    ODo,
}

[Serializable]
public class OJOEO
{
    public string ofmowe;
    public int momvowe;
}

[Serializable]
public class OJOEoihfowO
{
    public string ofmowjofjwe4fe;
    public int momvowgrwgl90uj4903e;
}