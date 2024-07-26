using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioLoader : MonoBehaviour
{
    public AudioClip audioClip; // Drag and drop the audio clip in the Inspector
    private AudioSource audioSource;

    private void Start()
    {
       
        audioSource = GetComponent<AudioSource>();

        
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    
    public void ToggleAudio()
    {
        
        if (audioClip != null)
        {
            if (audioSource.isPlaying)
            {
              
                 audioSource.Stop();
            }
            else
            {
                
                audioSource.PlayOneShot(audioClip);
            }
        }
        else
        {
            Debug.LogWarning("Audio clip is not assigned!");
        }
    }

    
   
}
