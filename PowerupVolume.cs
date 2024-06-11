using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupVolume : MonoBehaviour{
    public float boostSpeed;
    public float powerupTime;
    public float accel;
    
    private void OnTriggerEnter(Collider other) {
        // gets the car controller and passes it onto the speed boost function
        CarController carController = other.GetComponent<CarController>();
        ApplySpeedBoost(carController);
    }

    // increases the car's max speed by the boost speed
    void ApplySpeedBoost(CarController controller) {
        controller.maxForwardSpeed *= boostSpeed;
        accel = controller.accelTimeToForwardMaxSpeed;
        controller.accelTimeToForwardMaxSpeed -= accel;
        StartCoroutine(RemoveSpeedBoost(controller));
    }

    // reduces the car's max speed by the boost speed to get the car back to the original max speed
    IEnumerator RemoveSpeedBoost(CarController controller) {
        yield return new WaitForSeconds(powerupTime);
        controller.maxForwardSpeed /= boostSpeed;
        controller.accelTimeToForwardMaxSpeed += accel;
    }
}
