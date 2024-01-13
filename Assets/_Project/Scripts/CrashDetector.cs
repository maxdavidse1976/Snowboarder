using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float _timeBeforeReload = 1f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            Invoke("LoseAndReloadLevel", _timeBeforeReload);
        }
    }

    void LoseAndReloadLevel()
    {
        SceneManager.LoadScene("Slope_01");
    }
}
