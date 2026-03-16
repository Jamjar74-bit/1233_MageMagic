using UnityEngine;
using UnityEngine.AI;
using System;

[RequireComponent(typeof(NavMeshAgent))]
public sealed class NavMeshAgentMover : MonoBehaviour
{
    private NavMeshAgent _agent;

    // Public gets for agent related information
    public Vector3 Velocity => _agent ? _agent.velocity : Vector3.zero;
    public bool HasPath => _agent && _agent.hasPath;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        if (!_agent)
        {
            Debug.LogError($"NavMeshAgent component missing on {gameObject.name}", this);
        }
    }

    public void SetDestination(Vector3 worldPos)
    {
        if (!_agent) return;

        // Best practice: don't spam SetDestination every frame if you don't need to.
        _agent.SetDestination(worldPos);
    }

    public void Stop()
    {
        if (!_agent) return;

        _agent.ResetPath();
    }
}