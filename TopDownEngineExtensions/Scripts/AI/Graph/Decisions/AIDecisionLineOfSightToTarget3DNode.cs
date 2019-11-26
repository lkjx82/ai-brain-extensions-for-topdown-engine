﻿using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionLineOfSightToTarget3D"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/3D/Line Of Sight To Target")]
    public class AIDecisionLineOfSightToTarget3DNode : AIDecisionNode
    {
        public LayerMask obstacleLayerMask;
        public Vector3 lineOfSightOffset = new Vector3(0, 0, 0);

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionLineOfSightToTarget3D>();
            decision.Label = label;
            decision.ObstacleLayerMask = obstacleLayerMask;
            decision.LineOfSightOffset = lineOfSightOffset;
            return decision;
        }
    }
}