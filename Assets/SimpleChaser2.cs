using UnityEngine;
public class SimpleChaser : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    [SerializeField] private float chaseRange = 50f;
    [SerializeField] private float speed = 3.5f;

    private Transform _player;
    private NavMeshAgentMover _mover;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player")?.transform;
        _mover = GetComponent<NavMeshAgentMover>();

        if (!_player || !_mover)
            enabled = false;
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, _player.position);

        if (distance <= chaseRange)
        {
            _mover.SetDestination(_player.position);
        }
        else
        {
            _mover.Stop();
        }
    }
}