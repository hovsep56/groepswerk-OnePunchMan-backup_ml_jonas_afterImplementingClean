using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Climber : MonoBehaviour
{

    private CharacterController character;
    public static XRController climbinghand;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (climbinghand)
        {
            Climb();
        }
    }

    private void Climb()
    {
        InputDevices.GetDeviceAtXRNode(climbinghand.controllerNode).TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 velocity);

        character.Move(-velocity * Time.fixedDeltaTime);
    }
}
