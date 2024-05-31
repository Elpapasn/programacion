using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
  public int jumpFactor = 2;
    // Saltar mas
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength += jumpFactor;
    }

  // Saltar menos
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength -= jumpFactor;
    }
}
