using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform TeleportPlace;
    public GameObject Player;
    CharacterController cc;
    [SerializeField]
    private AudioSource Effect;

    private void Start()
    {
        cc = Player.GetComponent<CharacterController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Effect.Play();
        cc.enabled = false;
          
        Player.transform.position = TeleportPlace.transform.position;
        
        cc.enabled = true;
    }
}
