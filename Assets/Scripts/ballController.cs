using UnityEngine;

public class ballController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] private inputManager inputManager;

    private bool isBallLaunched;
    private Rigidbody ballRB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Grabbing reference to rigidbody
        ballRB = GetComponent<Rigidbody>();

        //Add listener to OnSpacePressed event
        //Calls LaunchBall function when space is pressed
        inputManager.OnSpacePressed.AddListener(LaunchBall);
    }

    private void LaunchBall()
    {
        if(isBallLaunched) return;

        isBallLaunched = true;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }
}
