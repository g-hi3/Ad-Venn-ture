using UnityEngine;

public class RestrictedArea : MonoBehaviour {

  [SerializeField] private string _playerTag;

  private void OnCollisionEnter2D(Collision2D collision) {
    var collisionGameObject = collision.gameObject;
    if (collisionGameObject.CompareTag(_playerTag)) {
      Physics2D.IgnoreCollision(collision.collider, collision.otherCollider);
    }
  }

}
