using UnityEngine;
using UnityEngine.Events;

public class inputManager : MonoBehaviour
{
    public UnityEvent OnSpacePressed = new UnityEvent();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) OnSpacePressed?.Invoke();
    }
}
