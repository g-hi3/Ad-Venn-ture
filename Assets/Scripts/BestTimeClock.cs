using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BestTimeClock : MonoBehaviour {

  private const string ClockTextFormat = "{0}:{1:00}";
  private const string ClockTextNoTimeYet = "--:--";
  [SerializeField] private Text _clockText;

  private void Start() {
    var activeScene = SceneManager.GetActiveScene();
    var sceneBuildIndex = activeScene.buildIndex;
    var bestTime = SpeedrunStatistics.GetTime(sceneBuildIndex);
    _clockText.text = GetTimeAsString(bestTime);
  }

  public static string GetTimeAsString(int time) {
    if (time == SpeedrunStatistics.NoRunYetTime) {
      return ClockTextNoTimeYet;
    }
    var minutes = time / 60;
    var seconds = time - minutes * 60;
    return string.Format(ClockTextFormat, minutes, seconds);
  }

}