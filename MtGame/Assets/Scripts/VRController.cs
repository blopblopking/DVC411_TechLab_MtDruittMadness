using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class VRController : MonoBehaviour
{
    public XRNode inputSource;
    private XROrigin rig;

    private Vector2 inputAxis;
    private CharacterController character;

    public float speed = 30;
    public float gravity = 9.81f;
    private float fallingSpeed;
    public float addHeight = 0.2f;
    public LayerMask groundLayer;
    float rayLength;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<XROrigin>();
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
    }
    private void FixedUpdate()
    {
        CapsuleFollow();
        Quaternion headYaw = Quaternion.Euler(0, rig.Camera.transform.eulerAngles.y, 0);
        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);
        character.Move(speed * Time.fixedDeltaTime * direction);
 //Gravity Stuff
        if (CheckIfGrounded())
        {
            fallingSpeed = 0;
        }
        else
            fallingSpeed += gravity * Time.fixedDeltaTime;
        character.Move(fallingSpeed * Time.fixedDeltaTime * Vector3.up);
    }

     bool CheckIfGrounded()
     {
            Vector3 rayStart = transform.TransformPoint(character.center);
            rayLength = character.center.y + 0.01f;
            //Reports true if on Ground
            if (Physics.SphereCast(rayStart, character.radius, Vector3.down, out _, rayLength, groundLayer))
                return true;
            else
                return false;
     }

    void CapsuleFollow()
    {
        character.height = rig.CameraInOriginSpaceHeight + addHeight;
        Vector3 capsuleCenter =
           transform.InverseTransformPoint(rig.Camera.transform.position);
        character.center =
           new Vector3(capsuleCenter.x, character.height / 2, capsuleCenter.z);
    }


}
