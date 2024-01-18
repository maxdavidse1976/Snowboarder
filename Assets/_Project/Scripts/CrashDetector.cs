using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float _timeBeforeReload = 1f;
    [SerializeField] ParticleSystem _crashEffect;
    [SerializeField] AudioClip _crashSFX;

    AudioSource _audioSource;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            _crashEffect.Play();
            _audioSource.PlayOneShot(_crashSFX);
            Invoke("LoseAndReloadLevel", _timeBeforeReload);
        }
    }

    void LoseAndReloadLevel()
    {
        SceneManager.LoadScene("Slope_01");
    }
}
