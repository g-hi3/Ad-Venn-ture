using System.Collections.Generic;
using UnityEngine;

public class InteractionSubject : MonoBehaviour {

  private readonly HashSet<Interactable> _registeredInteractables = new HashSet<Interactable>();

  public void StartInteractaction() {
    foreach (var interactable in _registeredInteractables) {
      interactable.OnStartInteraction();
    }
  }

  public void RegisterInteractable(Interactable interactable) {
    _registeredInteractables.Add(interactable);
  }

  public void UnregisterInteractable(Interactable interactable) {
    _registeredInteractables.Remove(interactable);
  }

}
