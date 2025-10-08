using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioChangeVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public string exposedParam = "VolumeMusic"; // Nome do parâmetro exposto
    public Slider slider;

    private void Start()
    {
        float savedVolume = PlayerPrefs.GetFloat(exposedParam, 0.8f);
        slider.value = savedVolume;
        ChangeVolume(savedVolume);
        slider.onValueChanged.AddListener(ChangeVolume);
    }

    public void ChangeVolume(float value)
    {
        float dB = Mathf.Log10(Mathf.Clamp(value, 0.0001f, 1f)) * 20;
        mixer.SetFloat(exposedParam, dB);
        PlayerPrefs.SetFloat(exposedParam, value);
    }
}
