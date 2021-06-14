using UnityEngine;

public class PlayerController : MonoBehaviour {
  
  private static readonly int AnimatorPropertyIsWalking = Animator.StringToHash("IsWalking");
  private static Vector3 _regularScale = new Vector3(1f, 1f, 1f);
  private static Vector3 _flippedScale = new Vector3(-1f, 1f, 1f);
  private Transform _transform;
  private InteractionSubject _interactionSubject;
  private Animator _animator;
  private bool _isMoving;
  private Vector3 _movementDirection;

  public void Move(Vector3 direction) {
    _movementDirection = direction;
    _isMoving = true;
    _animator.SetBool(AnimatorPropertyIsWalking, true);
    if (_movementDirection.x > 0f) {
      _transform.localScale = _regularScale;
    } else if (_movementDirection.x < 0f) {
      _transform.localScale = _flippedScale;
    }
  }

  public void StopMoving() {
    _isMoving = false;
    _animator.SetBool(AnimatorPropertyIsWalking, false);
  }

  public void StartInteraction() {
    _interactionSubject.StartInteractaction();
  }

  private void Awake() {
    _transform = GetComponent<Transform>();
    _interactionSubject = GetComponentInChildren<InteractionSubject>();
    _animator = GetComponentInChildren<Animator>();
  }

  private void FixedUpdate() {
    if (_isMoving) {
      _transform.position += Time.fixedDeltaTime * _movementDirection;
    }
  }

}
