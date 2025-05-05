using System;
using UnityEngine;

public class CameraShaque : MonoBehaviour
{
    public GameObject camera;

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Inimigo"))
        {
            Animator a = camera.gameObject.GetComponent<Animator>();
            a.SetTrigger("Shake");
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
