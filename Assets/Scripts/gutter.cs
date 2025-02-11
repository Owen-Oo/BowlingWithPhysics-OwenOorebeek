using UnityEngine;

public class gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider triggeredBody)
    {
        Rigidbody ballRB = triggeredBody.GetComponent<Rigidbody>();

        float velocityMagnitude = ballRB.linearVelocity.magnitude;

        ballRB.linearVelocity = Vector3.zero;
        ballRB.angularVelocity = Vector3.zero;

        ballRB.AddForce(transform.forward * velocityMagnitude, ForceMode.VelocityChange);
    }
}
