using UnityEngine;

public class PendulumObject : MonoBehaviour {
  
  [SerializeField] private Vector3 _movementDirection;
  [SerializeField] private float _movementSpeed;
  private Transform _transform;
  private Vector3 _originalPosition;
  private Vector3 _targetPosition;
  
  private void Awake() {
    _transform = GetComponent<Transform>();
  }

  private void Start() {
    _originalPosition = _transform.position;
    _targetPosition = _originalPosition + _movementDirection;
  }

  private void FixedUpdate() {
    var delta = Mathf.PingPong(Time.fixedTime * _movementSpeed, 1);
    _transform.position = Vector3.Lerp(_originalPosition, _targetPosition, delta);
  }

}
