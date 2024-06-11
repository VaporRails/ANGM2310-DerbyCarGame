using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringVolume : MonoBehaviour{
    // simply boops the car up when entering the trigger
    private void OnTriggerEnter(Collider other) {
        other.GetComponent<Rigidbody>().velocity = new Vector3(20, 20);
    }
}
