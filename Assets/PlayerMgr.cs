using System;
using UnityEngine;

public class PlayerMgr : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;

    public GameObject PlayerObject { get; internal set; }
    public static PlayerMgr Instance { get; internal set; }

    public bool HaspawnedPlayer => PlayerObject != null;

    public void SpawnedPlayer(Vector3 position, Quaternion rotation)
    {
        if (PlayerObject)
        {
            Debug.LogError("Player already spawned!");
            return;

        }


        PlayerObject = Instantiate(_playerPrefab, position, rotation);

        Debug.Log("Player spawned");

    }



}