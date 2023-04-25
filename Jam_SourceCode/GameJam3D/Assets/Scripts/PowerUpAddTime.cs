using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpAddTime : MonoBehaviour
{
    [SerializeField] private float _timeAdd = 10;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<TimerScript>().GainTime(_timeAdd);

            Destroy(gameObject);
        }
    }
}
