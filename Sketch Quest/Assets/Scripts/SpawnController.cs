using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SpawnController: MonoBehaviour
{


    private GameObject firstPlayer;
    private GameObject secondPlayer;

    public GameObject secondPlayerPrefab;

    public Vector3 spawnLocation1;
    public Vector3 spawnLocation2;

    public PlayerInputManager piMan;

    public void OnPlayerJoined(){
        Debug.Log("spawn character method");
        //find character spawned in

        if (firstPlayer == null){
            Debug.Log("check!");
            firstPlayer = GameObject.Find("Character_Male_Shirt_01(Clone)");
            firstPlayer.transform.position = spawnLocation1;
            piMan.playerPrefab = secondPlayerPrefab;
            //update prefab to other character
        }

        if (secondPlayer == null){
            Debug.Log("Check 2!");
            secondPlayer = GameObject.Find("Character_Female_Shirt_01(Clone)");
            secondPlayer.transform.position = spawnLocation2;
        }
    }
}
