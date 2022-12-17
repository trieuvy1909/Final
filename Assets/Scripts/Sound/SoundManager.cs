using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // public static AudioManager instance;
    // public GameObject prefab;
    // public AudioClip theme;
    // private AudioSource themesource;
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    // private void Awake(){
    //     instance = this;
    // }
    // public void PlaySound(AudioClip clip, float volume, bool isLoopback){
    //     if(clip == this.theme){
    //         Play(clip, ref themesource, volume, isLoopback);
    //     }
    // }
    // private void Play(AudioClip clip, ref AudioSource audiosource, float volume, bool isLoopback){
    //     if(audiosource != null && AudioSource.isPlaying){
    //         return;
    //     }
    //     audiosource = Instantiate(instance.prefab).GetComponent<AudioSource>();

    //     audiosource.volume = volume;
    //     audiosource.loop = isLoopback;
    //     audiosource.clip = clip;
    //     audiosource.Play();
    //     Destroy(audiosource.gameObjet,audiosource.clip.length);
    // }
}
