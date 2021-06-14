using UnityEngine;

public static class SpeedrunStatistics {

  public const int NoRunYetTime = -1;

  public static int GetTime(int levelBuildIndex) {
    return PlayerPrefs.GetInt($"Best Time {levelBuildIndex}", NoRunYetTime);
  }

  public static void SetTime(int levelBuildIndex, int time) {
    var currentTime = GetTime(levelBuildIndex);
    if (currentTime != NoRunYetTime
      && currentTime <= time) {
      return;
    }

    PlayerPrefs.SetInt($"Best Time {levelBuildIndex}", time);
    PlayerPrefs.Save();
  }

}