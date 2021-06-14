using UnityEngine;

public abstract class Interactable : MonoBehaviour {

  private const string TagLeftPlayerCharacter = "Left Player Character";
  private const string TagRightPlayerCharacter = "Right Player Character";

  public abstract void OnStartInteraction();

  private void OnCollisionEnter2D(Collision2D collision) {
    var collisionGameObject = collision.gameObject;
    if (collisionGameObject.CompareTag(TagLeftPlayerCharacter)
      || collisionGameObject.CompareTag(TagRightPlayerCharacter)) {
      Physics2D.IgnoreCollision(collision.collider, collision.otherCollider);
    }
  }
  private void OnTriggerEnter2D(Collider2D collision) {
    var collisionGameObject = collision.gameObject;
    var interactable = collisionGameObject.GetComponent<InteractionSubject>();
    if (interactable != null) {
      interactable.RegisterInteractable(this);
    }
  }

  private void OnTriggerExit2D(Collider2D collision) {
    var collisionGameObject = collision.gameObject;
    var interactable = collisionGameObject.GetComponent<InteractionSubject>();
    if (interactable != null) {
      interactable.UnregisterInteractable(this);
    }
  }

}
