using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CreateRobber : MonoBehaviour
{
    [SerializeField] private GameObject _robber;

    public void Spawn()
    {
        Instantiate(_robber, transform.position, Quaternion.identity);
    }
}
