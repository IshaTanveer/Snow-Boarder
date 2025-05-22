using UnityEngine;

class SnowParticles : MonoBehaviour
{
    [SerializeField] ParticleSystem DustTrail;
    //[SerializeField] GameObject Ground;
    [SerializeField] GameObject Snowboard;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Snow")
        {
            //DustTrail.transform.position = Snowboard.transform.position;
            Debug.Log("Snowwww!!");
            DustTrail.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Snow")
        {
           // DustTrail.transform.position = BoarderBottom.transform.position;
            DustTrail.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
