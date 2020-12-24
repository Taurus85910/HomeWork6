using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    [SerializeField] private float _frequency;
    private CreaterRobber[] _portals;

    private void Start()
    {
        _portals = gameObject.GetComponentsInChildren<CreaterRobber>();
        StartCoroutine(DelayedСreation());
    }

    private IEnumerator DelayedСreation()
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
