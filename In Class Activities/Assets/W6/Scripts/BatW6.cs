using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] public Transform _playerTarget;
    [SerializeField] public float _speed = 1.0f;
    public bool _chase;

    private void Start()
    {
        startChase();
    }

    private void Update()
    {
        if (!_chase)
        {
            return;
        }
        transform.position = Vector3.MoveTowards(transform.position, _playerTarget.position, _speed * Time.deltaTime);

    }
    public void startChase()
    {
        _chase = true;
    }

    public void stopChase()
    {
        _chase = false;
    }
}
