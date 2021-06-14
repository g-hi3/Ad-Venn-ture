using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenuNavigation : MonoBehaviour {
  
  private const string SceneNameMainMenu = "Main Menu";
  private static readonly IList<Resolution> _configuredResolutions = new List<Resolution> {
    new Resolution() { width = 853, height = 480, refreshRate = 60 },
    new Resolution() { width = 1280, height = 720, refreshRate = 60 }
  };
  [SerializeField] private Text _volumeLabel;
  [SerializeField] private Dropdown _resolutionDropdown;
  [SerializeField] private Slider _volumeSlider;
  private Resolution _selectedResolution;
  private float _volumeValue;

  public void UpdateScreenResolution(int option) {
    _selectedResolution = _configuredResolutions[option];
  }

  public void UpdateVolume(float value) {
    _volumeValue = value;
    _volumeLabel.text = (int)Mathf.Ceil(_volumeValue * 100f) + "%";
  }

  public void SaveOptions() {
    PlayerPrefs.SetInt("Resolution Width", _selectedResolution.width);
    PlayerPrefs.SetInt("Resolution Height", _selectedResolution.height);
    PlayerPrefs.SetFloat("Volume", _volumeValue);
    PlayerPrefs.Save();
    CloseOptions();
  }

  public void CloseOptions() {
    SceneManager.LoadScene(SceneNameMainMenu);
  }

  private void Start() {
    for (var i = 0; i < _configuredResolutions.Count; i++) {
      var configuredResolution = _configuredResolutions[i];
      var resolutionWidth = PlayerPrefs.GetInt("Resolution Width", 1280);
      var resolutionHeight = PlayerPrefs.GetInt("Resolution Height", 720);
      if (configuredResolution.width == resolutionWidth
        && configuredResolution.height == resolutionHeight) {
        _resolutionDropdown.value = i;
        break;
      }
    }
    _volumeValue = PlayerPrefs.GetFloat("Volume", 0.8f);
    _volumeSlider.value = _volumeValue;
  }

}
