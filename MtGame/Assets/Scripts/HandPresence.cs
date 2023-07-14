using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;




public class HandPresence : MonoBehaviour
{
    public InputDeviceCharacteristics controllerCharacter;
    public GameObject handModelPrefab;
    public Animator handAnimator;

    private InputDevice targetDevice;
    private GameObject spawnedController;
    private GameObject spawnedHandModel;


    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();

        InputDevices.GetDevicesWithCharacteristics(controllerCharacter, devices);

        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }

        spawnedHandModel = Instantiate(handModelPrefab, transform);

        handAnimator = spawnedHandModel.GetComponent<Animator>();


    }
    void UpdateHandAnimation()
    {
// Checks if the current controller has the input, returns true if there is a value
        if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
// Sets the animation parameter “Trigger” to the found value from the controller
            handAnimator.SetFloat("Trigger", triggerValue);
        }
        else
        {
// Sets the animation parameter to 0 if nothing is found
            handAnimator.SetFloat("Trigger", 0);
        }

        if (targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            handAnimator.SetFloat("Grip", gripValue);
        }
        else
        {
            handAnimator.SetFloat("Grip", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHandAnimation();
    }
}
