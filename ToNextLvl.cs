using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLvl : MonoBehaviour
{
    private static int level = 1;
    public int levels;
    
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D player)
    {
        try
        {
            if(player.tag == "Player")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                
                level += 1;
                Debug.Log(level);
                
                levels = level;
                Debug.Log(levels);
            }
        }
        catch
        {

        }
    }
    IEnumerator NextLvl()
    {
        //Disable player's movement
        yield return new WaitForSeconds(2f);
        
        
    }
    void Update()
    {
        
    }
}

