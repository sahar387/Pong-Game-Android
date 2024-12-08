using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    AudioSource musicSource;


    
    private void Start()
    {
      
        musicSource.Play();
    }
}
