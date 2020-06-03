﻿using Unity.Entities;

public struct CarProperties : IComponentData
{
    public float DefaultSpeed;
    public float OvertakeSpeed;
    public float DistanceToCarBeforeOvertaking;
    public float OvertakeEagerness;
    public float MergeSpace;
    public float Acceleration;
}