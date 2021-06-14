using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuNavigator : MonoBehaviour {

  private const string SceneNameLevelSelection = "Level Selection";
  private const string SceneNameMainMenu = "Main Menu";
  private const string SceneNameOptionsMenu = "Options Menu";

  public void OpenLevelSelection() {
    SceneManager.LoadScene(SceneNameLevelSelection);
  }

  public void OpenOptions() {
    SceneManager.LoadScene(SceneNameOptionsMenu);
  }

  public void ExitGame() {
#if UNITY_EDITOR
    EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
  }

  public void GoToMainMenu() {
    SceneManager.LoadScene(SceneNameMainMenu);
  }

}
