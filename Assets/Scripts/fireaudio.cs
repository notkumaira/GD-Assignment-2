using UnityEngine;

public class Fireaudio : MonoBehaviour
{
    public Transform player;
    public AudioSource fireplaceAudio;

    public float maxDistance = 10f;
    public float minVolume = 0f;
    public float maxVolume = 1f;

    void Update()
    {
        if (player == null || fireplaceAudio == null)
            return;

        float distance = Vector3.Distance(transform.position, player.position);


        float volume = Mathf.Lerp(maxVolume, minVolume, distance / maxDistance);


        fireplaceAudio.volume = Mathf.Clamp(volume, minVolume, maxVolume);
    }
}
