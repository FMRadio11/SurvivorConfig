using System;
using UnityEngine;
using BepInEx;

namespace LabRebalance
{
    [BepInPlugin("com.ZMRadio11.ZSurvivorConfig", "SurvivorConfig", "0.0.1")]
    public class RebalPlugin : BaseUnityPlugin
    {
        public void Awake()
        {
            RebalBase.Rebalance();
        }
    }
}
