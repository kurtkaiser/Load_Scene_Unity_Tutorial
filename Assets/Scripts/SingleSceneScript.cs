using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Need this, really
using UnityEngine.SceneManagement;

public class SingleSceneScript : MonoBehaviour
{
    public string SceneName;
    private GameObject Player;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            DontDestroyOnLoad(Player);
            SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
            Vector3 pos = Player.transform.position;
            pos.y = pos.y * -1;
            Player.transform.position = pos;
        }
    }
}
