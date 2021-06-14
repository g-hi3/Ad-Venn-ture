using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

  [SerializeField] private AudioClip _fanfareClip;
  [SerializeField] private ParticleSystem _confettiEffect;
  [SerializeField] private CurrentTimeClock _currentTimeClock;
  private AudioSource _audioSource;
  private int _playerCount;

  private void OnTriggerEnter2D(Collider2D collision) {
    _playerCount++;
    if (_playerCount == 2) {
      _currentTimeClock.StopClock();
      _audioSource.Play();
      _confettiEffect.Play();
      StartCoroutine(LoadNextScene());
    }
  }

  private IEnumerator<WaitUntil> LoadNextScene() {
    yield return new WaitUntil(() => !_audioSource.isPlaying);
    yield return new WaitUntil(() => !_confettiEffect.isPlaying);
    var activeScene = SceneManager.GetActiveScene();
    SceneManager.LoadScene(activeScene.buildIndex + 1);
  }

  private void OnTriggerExit2D(Collider2D collision) {
    _playerCount--;
  }

  private void Awake() {
    _audioSource = GetComponent<AudioSource>();
  }

  private void Start() {
    _audioSource.clip = _fanfareClip;
  }

}
