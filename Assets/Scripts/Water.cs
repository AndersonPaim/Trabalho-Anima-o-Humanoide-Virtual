using System.Collections;
using System.Collections.Generic;
using _Project.Scripts;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _player.StartSwimming();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            _player.StopSwimming();
        }
    }
}
