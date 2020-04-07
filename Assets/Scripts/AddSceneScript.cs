using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Need this, really
using UnityEngine.SceneManagement;

public class AddSceneScript : MonoBehaviour
{
    public string SceneName;
    private GameObject Player;
    private GameObject Camera;

    void Start()
    {
        Player = GameObject.Find("Player");
        Camera = GameObject.Find("Main Camera");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            DontDestroyOnLoad(Player);
            DontDestroyOnLoad(Camera);
            SceneManager.LoadScene(SceneName, LoadSceneMode.Additive);
            Camera.GetComponent<CameraScript>().moveCamera = true;
            Camera.GetComponent<CameraScript>().xMin -= 17;
        }
    }
}
