
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMovement : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Animator animator;

    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotationSpeed = 10f;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        // Configure NavMeshAgent if it exists
        if (navMeshAgent != null)
        {
            navMeshAgent.speed = moveSpeed;
        }
    }

    private void Update()
    {
        // Get input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 input = new Vector3(horizontal, 0, vertical);

        // Normalize diagonal movement
        if (input.magnitude > 1f)
        {
            input.Normalize();
        }

        // Handle movement
        if (input.magnitude > 0.1f) // Using a small threshold to avoid jitter
        {
            // Move the agent
            if (navMeshAgent != null && navMeshAgent.isOnNavMesh)
            {
                // Convert input to world space relative to camera or character
                Vector3 moveDirection = transform.TransformDirection(input);
                navMeshAgent.Move(moveDirection * moveSpeed * Time.deltaTime);

                // Rotate to face movement direction
                Quaternion targetRotation = Quaternion.LookRotation(input);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }

            // Update animator
            if (animator != null)
            {
                animator.SetFloat("Speed", input.magnitude);
                animator.SetFloat("Horizontal", input.x);
                animator.SetFloat("Vertical", input.z);
            }
        }
        else
        {
            // Idle state
            if (animator != null)
            {
                animator.SetFloat("Speed", 0);
            }
        }
    }
}