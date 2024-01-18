using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem _dustTrail;
    
    AudioSource _audioSource;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _dustTrail.Play();
            //_audioSource.Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _dustTrail.Stop();
            //_audioSource.Stop();
        }
    }
}
