using UnityEngine;

public class Hole : MonoBehaviour {

  [SerializeField] private AudioClip _fallingClip;
  private AudioSource _audioSource;
  private void OnTriggerEnter2D(Collider2D other) {
    _audioSource.Play();
    var playerInputDelegate = other.GetComponentInParent<PlayerInputDelegate>();
    playerInputDelegate.RespawnPlayer();
  }

  private void Awake() {
    _audioSource = GetComponent<AudioSource>();
  }

  private void Start() {
    _audioSource.clip = _fallingClip;
  }

}
