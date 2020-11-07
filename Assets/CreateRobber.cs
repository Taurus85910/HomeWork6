using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CreateRobber : MonoBehaviour
{
    [SerializeField] private GameObject _robber;
    public void Spawn()
    {
        Vector3 _position = transform.position;
        Instantiate(_robber, _position, Quaternion.identity);
    }
}
