using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRPRefaccotredPlayer : MonoBehaviour
{

    // 单一职能
    [SerializeField] private PlayerAudio playerAudio;
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private PlayerMovement playerMovement;
    void Start()
    {
        playerAudio = GetComponent<PlayerAudio>();
        playerInput = GetComponent<PlayerInput>();
        playerMovement = GetComponent<PlayerMovement>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class PlayerInput
{

}

public class PlayerMovement 
{
    
}

public class PlayerAudio
{

}
