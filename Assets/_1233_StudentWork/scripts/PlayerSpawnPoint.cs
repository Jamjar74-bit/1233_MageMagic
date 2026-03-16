using UnityEngine;

public class PlayerSpawnPoint : Singleton<PlayerSpawnPoint>
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius: 0.5f);
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * 1f);
    
        
    }
}
