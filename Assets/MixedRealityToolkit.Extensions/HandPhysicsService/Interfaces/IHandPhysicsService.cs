// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Extensions.HandPhysics
{
    /// <summary>
    /// Generic interface for applying rigidbodies to handJoints
    /// </summary>
    public interface IHandPhysicsService : IMixedRealityExtensionService
    {
        /// <summary>
        /// The Parent GameObject that contains all the PhysicsJoints
        /// </summary>
        GameObject HandPhysicsServiceRoot { get; }

        /// <summary>
        /// The LayerMask the PhysicsJoints will be on
        /// </summary>
        int HandPhysicsLayer { get; set; }

        /// <summary>
        /// Whether to make the Palm a PhysicsJoint
        /// </summary>
        bool UsePalmKinematicBody { get; set; }

        /// <summary>
        /// The prefab to represent each PhysicsJoint
        /// </summary>
        GameObject FingerTipKinematicBodyPrefab { get; set; }

        /// <summary>
        /// The prefab to represent the Palm PhysicsJoint
        /// </summary>
        GameObject PalmKinematicBodyPrefab { get; set; }
    }
}