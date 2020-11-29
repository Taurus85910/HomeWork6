using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayСreation : MonoBehaviour
{
    [SerializeField] private float _frequency;
    private CreatingRobber[] _portals;

    private void Start()
    {
        _portals = gameObject.GetComponentsInChildren<CreatingRobber>();
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
<<<<<<< HEAD
=======
        


>>>>>>> 6c2cf3347d4e884ddffeb931db00a4d4aef00272
}
