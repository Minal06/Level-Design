
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{

    [SerializeField] private string targetSceneName;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(targetSceneName);
    }  
}
