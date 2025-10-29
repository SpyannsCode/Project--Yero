using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void SceneLoader(int i)
    {
        SceneManager.LoadScene(i);
    }

}
