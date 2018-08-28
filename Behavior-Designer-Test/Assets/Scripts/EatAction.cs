using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class EatAction : Action
{
    public SharedString Food;
    public TimelineAsset asset;

    public override TaskStatus OnUpdate()
    {
        Debug.Log("Eat" + Food.Value);
        return TaskStatus.Success;
    }
}