using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem _dustTrail;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _dustTrail.Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _dustTrail.Stop();
        }
    }
}
