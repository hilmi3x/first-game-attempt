using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelComplete : MonoBehaviour {

       public void loadNextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
