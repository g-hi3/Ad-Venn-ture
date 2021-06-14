using UnityEngine;

public class InteractableButton : Interactable {

  [SerializeField] private Gate _gate;

  public override void OnStartInteraction() {
    _gate.Open();
  }

}