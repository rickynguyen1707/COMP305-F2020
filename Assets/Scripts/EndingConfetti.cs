using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingConfetti : MonoBehaviour
{
    [SerializeField] private GameObject confetti;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(confetti);
        }
    }

}
