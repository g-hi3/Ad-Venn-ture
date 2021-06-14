using UnityEngine;

public class FrameRateRegulator : MonoBehaviour {

  [SerializeField] [Min(1)] private int targetFrameRate;
  
  private void Start() {
    Application.targetFrameRate = targetFrameRate;
    var resolutionWidth = GetResolutionWidth();
    var resolutionHeight = GetResolutionHeight();
    Screen.SetResolution(resolutionWidth, resolutionHeight, false);
  }

  private static int GetResolutionWidth() {
    return PlayerPrefs.GetInt("Resolution Width", 1280);
  }

  private static int GetResolutionHeight() {
    return PlayerPrefs.GetInt("Resolution Height", 720);
  }

}
