using BehaviorDesigner.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    private BehaviorTree m_bt;

    private void Start()
    {
        var bt = gameObject.GetComponent<BehaviorTree>();
        //var extBt = Resources.Load<ExternalBehaviorTree>("Behavior");
        bt.StartWhenEnabled = false;
        //bt.ExternalBehavior = extBt;
        bt.EnableBehavior();
        m_bt = bt;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            BehaviorManager
            //吃红烧牛肉面//
            //m_bt.SetVariableValue("Food", "红烧牛肉面");
            m_bt.SendEvent("Eat");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            //谁10000秒//
            m_bt.SetVariableValue("SleepTime", 3f);
            m_bt.SendEvent("Sleep");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            //地震啦//
            m_bt.SendEvent("EarthQuake");
        }
    }
}