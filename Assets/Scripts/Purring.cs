using UnityEngine;

public class Purring : MonoBehaviour
{ 
    public AudioSource sound;

   

    public void purr()
    {
        sound.Play(); 
    }

}
