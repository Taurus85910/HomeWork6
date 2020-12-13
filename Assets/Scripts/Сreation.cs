using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Сreation : MonoBehaviour
{
    [SerializeField] private float _frequency;
    private CreateRobber[] _portals;

    private void Start()
    {
        _portals = gameObject.GetComponentsInChildren<CreateRobber>();
        StartCoroutine(Delay());
    }

    private IEnumerator Delay()
    {
        while(true)
        { 
            foreach (var portal in _portals)
            {
                portal.Spawn();
                yield return new WaitForSeconds(_frequency);
            }
        } 
        
    }
}
