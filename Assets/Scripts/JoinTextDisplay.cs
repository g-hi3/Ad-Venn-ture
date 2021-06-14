using UnityEngine;
using UnityEngine.UI;

public class JoinTextDisplay : MonoBehaviour {

  [SerializeField] private PlayerSpawner _playerSpawner;
  private Text _text;

  private void Awake() {
    _text = GetComponent<Text>();
  }

  private void Start() {
    _playerSpawner.PlayerJoined += HandlePlayerJoined;
  }

  private void HandlePlayerJoined() {
    _text.enabled = false;
  }

}
