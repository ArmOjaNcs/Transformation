using UnityEngine;

public class RotatorByY : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    
    private void Update()
    {
        RotateByY(_rotationSpeed);
    }

    private void RotateByY(float rotationSpeed)
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
