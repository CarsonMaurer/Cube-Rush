using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    private PlayerController _playerScript;
    public float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        _playerScript = GameObject.Find("Player").GetComponent<PlayerController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(_playerScript.isGameover == false)
        {
             transform.Translate(Vector2.right * moveSpeed *Time.deltaTime);
        }
       
    }
}
