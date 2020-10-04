using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private AudioSource[] allAudioSources;

    public GameObject CubeSatPresentation;
    public AudioSource CubeSatAudio;

    public GameObject ForestFirePresentation;
    public AudioSource ForestFireAudio;

    public GameObject GracePresentation;
    public AudioSource GraceAudio;

    public void StopAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }
    public void DisableCubeSat()
    {
        CubeSatPresentation.SetActive(false);
    }
    public void PlayCubeSat()
    {
        StopAllAudio();
        CubeSatAudio.Play();
        CubeSatPresentation.SetActive(true);
        Invoke("DisableCubeSat", 56);
        Debug.Log("PLAY TV");
    }

    public void DisableForestFire()
    {
        ForestFirePresentation.SetActive(false);
    }
    public void PlayForestFire()
    {
        StopAllAudio();
        ForestFireAudio.Play();
        ForestFirePresentation.SetActive(true);
        Invoke("DisableForestFire", 70);
        Debug.Log("PLAY TV");
    }
    public void DisableGrace()
    {
        GracePresentation.SetActive(false);
    }
    public void PlayGrace()
    {
        StopAllAudio();
        GraceAudio.Play();
        GracePresentation.SetActive(true);
        Invoke("DisableGrace", 135);
        Debug.Log("Play GRace");
    }
}
