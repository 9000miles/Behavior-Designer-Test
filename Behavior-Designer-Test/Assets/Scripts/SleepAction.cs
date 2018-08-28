using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepAction : Action
{
    public SharedFloat SleepTime;
    private float m_sleepTime;
    private float m_startTime;

    public override void OnStart()
    {
        m_startTime = Time.time;
        m_sleepTime = (float)SleepTime.GetValue();
    }

    public override TaskStatus OnUpdate()
    {
        if (m_startTime + m_sleepTime < Time.time)
        {
            Debug.Log("I am Sleep Done----------------------------------------");
            return TaskStatus.Success;
        }
        Debug.Log("I am Sleeping");
        return TaskStatus.Running;
    }
}