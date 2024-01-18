using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float _timeBeforeReload = 1f;
    [SerializeField] ParticleSystem _finishEffect;

    AudioSource _audioSource;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _finishEffect.Play();
            _audioSource.Play();
            Invoke("FinishLevelAndReload", _timeBeforeReload);
        }
    }

    void FinishLevelAndReload()
    {
        SceneManager.LoadScene("Slope_01");
    }
}
