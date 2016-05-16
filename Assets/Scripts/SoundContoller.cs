using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class SoundContoller : MonoBehaviour {

    public AudioSource Main;
    public AudioSource SFX;
    public static SoundContoller Instance = null;

    public float lowPitchRange = 0.95f;
    public float highPitchRange = 1.05f;


	// Use this for initialization
	void Awake () {

        if (Instance == null)
            Instance = this;
        else if (Instance != null)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
	}

    public void PlaySingle (AudioClip clip)
    {
        SFX.clip = clip;
        SFX.Play();
    }

    public void RandomSFX(params AudioClip[] clips)
    {
        int RandomIndex = Random.Range(0, clips.Length);
        float randomPitch = Random.Range(lowPitchRange, highPitchRange);

        SFX.pitch = randomPitch;
        SFX.clip = clips[RandomIndex];
        SFX.Play();
    }
}
