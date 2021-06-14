using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CurrentTimeClock : MonoBehaviour {

  [SerializeField] private PlayerSpawner _playerSpawner;
  [SerializeField] private Text _clockText;
  private bool _isStarted;
  private float _time;

  public void StopClock() {
    _isStarted = false;
    var activeScene = SceneManager.GetActiveScene();
    SpeedrunStatistics.SetTime(activeScene.buildIndex, (int)_time);
  }

  private void StartClock() {
    _time = 0;
    _isStarted = true;
  }

  private void Start() {
    _playerSpawner.PlayerJoined += StartClock;
  }

  private void Update() {
    if (!_isStarted) {
      return;
    }
    _time += Time.deltaTime;
    _clockText.text = BestTimeClock.GetTimeAsString((int)_time);
  }

}