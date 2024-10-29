using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    private Vector3 _scaleChanger;
    private float _maxSizeX;
    private float _minSizeX;
    private bool _isIncreasing;

    private void Awake()
    {
        _scaleChanger = new Vector3(0.01f, 0.01f, 0.01f);
        _minSizeX = 1;
        _maxSizeX = 2;
        _isIncreasing = true;
    }

    private void Update()
    {
        Scale(_scaleSpeed);
    }

    private void Scale(float scaleSpeed)
    {
        float currentSizeX = transform.localScale.x;

        if (currentSizeX > _maxSizeX)
            _isIncreasing = false;
        else if (currentSizeX < _minSizeX)
            _isIncreasing = true;

        if (_isIncreasing)
            transform.localScale += _scaleChanger * scaleSpeed * Time.deltaTime;
        else
            transform.localScale -= _scaleChanger * scaleSpeed * Time.deltaTime;
    }
}
