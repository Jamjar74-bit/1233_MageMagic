using UnityEngine;

/// <summary>
/// Interface for obtaining a target for AI.
/// </summary>
public interface ITargetProvider
{
    /// <summary>
    /// Frequently called
    /// </summary>
    bool HasTarget { get; }

    /// <summary>
    /// Frequently called
    /// </summary>
    Transform GetTarget();

    /// <summary>
    /// Frequently called
    /// </summary>
    Vector3 GetTargetPosition();
}