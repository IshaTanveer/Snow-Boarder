using UnityEngine;
using UnityEngine.SceneManagement;

class CrashDetector : MonoBehaviour
{
    [SerializeField] float restartDelay = 2f;
    [SerializeField] ParticleSystem CrashEffect;
    [SerializeField] AudioClip CrashSFX;
    bool hasCrashed = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Snow" && !hasCrashed)
        {
            hasCrashed = true;
            CrashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(CrashSFX);
            GetComponent<PlayerController>().DisableControllers();
            Invoke("ReloadScene", restartDelay);
        } //hehehaha ha hehe ha ha
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Aouchh!! I hit my head >w<!!");
    }
}
