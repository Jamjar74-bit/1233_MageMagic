using UnityEngine;

/// <summary>
/// Interface for movement execution.
/// </summary>
public interface IMover
{
    /// <summary>
    /// Frequently called 
    /// </summary>
    Vector3 Velocity { get; }

    /// <summary>
    /// Frequently called
    /// </summary>
    float RemainingDistance { get; }

    /// <summary>
    /// Frequently called
    /// </summary>
    bool IsAtDestination { get; }

    /// <summary>
    /// Frequently called
    /// </summary>
    void SetDestination(Vector3 destination);

    /// <summary>
    /// Frequently called
    /// </summary>
    void Stop();

    /// <summary>
    /// Frequently called
    /// </summary>
    void Resume();

    /// <summary>
    /// Frequently called
    /// </summary>
    void SetEnabled(bool value);
}