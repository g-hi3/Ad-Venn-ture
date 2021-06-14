using UnityEngine;

public class VolumeRegulator : MonoBehaviour {

  private AudioSource _audioSource;

  private void Awake() {
    _audioSource = GetComponent<AudioSource>();
  }

  private void Start() {
    _audioSource.volume = PlayerPrefs.GetFloat("Volume", 0.8f);
  }

}
