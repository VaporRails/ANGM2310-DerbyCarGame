using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInput : MonoBehaviour{
    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Backspace)) {
            int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentLevelIndex);
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }
}
