using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float _timeBeforeReload = 1f;
    [SerializeField] ParticleSystem _finishEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _finishEffect.Play();
            Invoke("FinishLevelAndReload", _timeBeforeReload);
        }
    }

    void FinishLevelAndReload()
    {
        SceneManager.LoadScene("Slope_01");
    }
}
