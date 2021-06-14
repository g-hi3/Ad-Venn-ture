using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSpawner : MonoBehaviour {

  [SerializeField] Transform _spawnPoint;
  private PlayerInputManager _playerInputManager;

  public delegate void OnPlayerJoined();

  public event OnPlayerJoined PlayerJoined;
  
  private void HandlePlayerJoined(PlayerInput playerInput) {
    playerInput.transform.position = _spawnPoint.position;
    PlayerJoined?.Invoke();
  }

  private void Awake() {
    _playerInputManager = GetComponent<PlayerInputManager>();
  }

  private void Start() {
    _playerInputManager.onPlayerJoined += HandlePlayerJoined;
  }

  private void OnDestroy() {
    _playerInputManager.onPlayerJoined -= HandlePlayerJoined;
  }
}
