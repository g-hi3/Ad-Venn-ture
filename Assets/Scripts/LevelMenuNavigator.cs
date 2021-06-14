using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenuNavigator : MonoBehaviour {

  private const string SceneNameTemplateLevel = "Level {0}";
  private const string SceneNameMainMenu = "Main Menu";

  public void OpenLevel(int level) {
    var sceneName = string.Format(SceneNameTemplateLevel, level);
    SceneManager.LoadScene(sceneName);
  }

  public void GoBackToMainMenu() {
    SceneManager.LoadScene(SceneNameMainMenu);
  }

}
