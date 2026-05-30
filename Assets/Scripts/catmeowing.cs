using UnityEngine;

public class catmeowing : MonoBehaviour
{ 
    public AudioSource sound;

   

    public void meow()
    {
        sound.Play(); 
    }

}


