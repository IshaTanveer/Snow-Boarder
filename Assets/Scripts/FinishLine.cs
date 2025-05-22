using UnityEngine;
using UnityEngine.SceneManagement;

class FinishLine : MonoBehaviour
{
    [SerializeField] float restartFinishDelay = 2f;
    [SerializeField] ParticleSystem FinishEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FinishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", restartFinishDelay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
        Debug.Log("I won! Hurray!!");
    }
}
