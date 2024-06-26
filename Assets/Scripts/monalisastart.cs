using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class monalisastart : MonoBehaviour
{   
    private bool triggerin;

    private void Update() 
    {
        if (!GameManager.talkedToGerald) { gameObject.SetActive(false); }
        else { gameObject.SetActive(true); }

        if (triggerin && Input.GetKeyDown(KeyCode.E)) 
        {   
            JigsawManager.previousPos = Player.Instance.transform.position;
            JigsawManager.previousLevel = GameManager.currentLevel.levelName;
            LevelManager.Instance.LoadLevel("Puzzle");
            Cursor.lockState = CursorLockMode.None;
        }

        if (GameManager.firstPuzzleCompleted) {
            Destroy(gameObject);
            
            CluesManager.Item key = GameManager.items[2];
            CluesManager.Instance.CollectItem(key);
        }
    }
 
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player")) 
        {
            triggerin = true;
        }
    }
 
    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.CompareTag("Player")) 
        {
            triggerin = false;
        }
    }
}
