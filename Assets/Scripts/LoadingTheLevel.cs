using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingTheLevel : MonoBehaviour
{
    public void loadingTheLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
