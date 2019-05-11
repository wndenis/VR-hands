using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollInput : MonoBehaviour
{
    public Transform LeftHandAnchor;
    public Transform RightHandAnchor;
    public Transform HeadAnchor;

    [Space]
    public Transform LeftHand;
    public Transform RightHand;
    public Transform Head;

    private Rigidbody leftHandRigidbody;
    private Rigidbody rightHandRigidbody;
    private Rigidbody headRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        leftHandRigidbody = LeftHand.GetComponent<Rigidbody>();
        rightHandRigidbody = RightHand.GetComponent<Rigidbody>();
        headRigidbody = Head.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
//        leftHandRigidbody.MovePosition(LeftHandAnchor.position);
        rightHandRigidbody.MovePosition(RightHandAnchor.position);
        rightHandRigidbody.MoveRotation(RightHandAnchor.rotation);
//        leftHandRigidbody.angularVelocity = (LeftHandAnchor.rotation.eulerAngles - LeftHand.rotation.eulerAngles) *
//                                            Time.fixedDeltaTime;
//        rightHandRigidbody.angularVelocity = (RightHandAnchor.rotation.eulerAngles - RightHand.rotation.eulerAngles) *
//                                            Time.fixedDeltaTime;
        
        
    }
}
