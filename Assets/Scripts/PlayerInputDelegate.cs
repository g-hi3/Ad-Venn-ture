using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputDelegate : MonoBehaviour {

  private const string ActionNameMoveLeftCharacter = "Move Left Character";
  private const string ActionNameMoveRightCharacter = "Move Right Character";
  private const string ActionNameInteractAsLeftCharacter = "Interact As Left Character";
  private const string ActionNameInteractAsRightCharacter = "Interact As Right Character";
  [SerializeField] private GameObject _leftPlayerCharacterPrefab;
  [SerializeField] private GameObject _rightPlayerCharacterPrefab;
  private PlayerController _leftPlayerController;
  private PlayerController _rightPlayerController;
  private PlayerInput _playerInput;

  public void RespawnPlayer() {
    DestroyPlayer();
    SpawnPlayer();
  }

  private void DestroyPlayer() {
    Destroy(_leftPlayerController.gameObject);
    Destroy(_rightPlayerController.gameObject);
  }

  private void SpawnPlayer() {
    _leftPlayerController = InstantiatePlayerController(_leftPlayerCharacterPrefab);
    _rightPlayerController = InstantiatePlayerController(_rightPlayerCharacterPrefab);
  }

  private void DelegateTriggeredAction(InputAction.CallbackContext callbackContext) {
    if (callbackContext.performed) {
      DelegatePerformedAction(callbackContext);
    }
    if (callbackContext.canceled) {
      DelegateCanceledAction(callbackContext);
    }
  }

  private void DelegatePerformedAction(InputAction.CallbackContext callbackContext) {
    switch (callbackContext.action.name) {
      case ActionNameMoveLeftCharacter:
        OnMoveLeftCharacterPerformed(callbackContext);
        break;
      case ActionNameMoveRightCharacter:
        OnMoveRightCharacterPerformed(callbackContext);
        break;
      case ActionNameInteractAsLeftCharacter:
        OnInteractAsLeftCharacterPerformed();
        break;
      case ActionNameInteractAsRightCharacter:
        OnInteractAsRightCharacterPerformed();
        break;
      default:
        Debug.LogWarning($"Unhandled player input action {callbackContext.action.name} performed!");
        break;
    }
  }

  public void OnMoveLeftCharacterPerformed(InputAction.CallbackContext callbackContext) {
    var moveDirection = callbackContext.ReadValue<Vector2>();
    _leftPlayerController.Move(moveDirection);
  }

  public void OnMoveRightCharacterPerformed(InputAction.CallbackContext callbackContext) {
    var moveDirection = callbackContext.ReadValue<Vector2>();
    _rightPlayerController.Move(moveDirection);
  }

  public void OnInteractAsLeftCharacterPerformed() {
    _leftPlayerController.StartInteraction();
  }

  public void OnInteractAsRightCharacterPerformed() {
    _rightPlayerController.StartInteraction();
  }

  private void DelegateCanceledAction(InputAction.CallbackContext callbackContext) {
    switch (callbackContext.action.name) {
      case ActionNameMoveLeftCharacter:
        OnMoveLeftCharacterCanceled();
        break;
      case ActionNameMoveRightCharacter:
        OnMoveRightCharacterCanceled();
        break;
      case ActionNameInteractAsLeftCharacter:
      case ActionNameInteractAsRightCharacter:
        break; // ignore.
      default:
        Debug.LogWarning($"Unhandled player input action {callbackContext.action.name} canceled!");
        break;
    }
  }

  private void OnMoveLeftCharacterCanceled() {
    _leftPlayerController.StopMoving();
  }

  private void OnMoveRightCharacterCanceled() {
    _rightPlayerController.StopMoving();
  }

  private PlayerController InstantiatePlayerController(GameObject playerCharacterPrefab) {
    var playerCharacter = Instantiate(playerCharacterPrefab, transform);
    return playerCharacter.GetComponent<PlayerController>();
  }

  private void Awake() {
    _playerInput = GetComponent<PlayerInput>();
  }

  private void Start() {
    _playerInput.onActionTriggered += DelegateTriggeredAction;
    SpawnPlayer();
  }

  private void OnDestroy() {
    _playerInput.onActionTriggered -= DelegateTriggeredAction;
  }

}
