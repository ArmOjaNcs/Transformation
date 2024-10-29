using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    private void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
