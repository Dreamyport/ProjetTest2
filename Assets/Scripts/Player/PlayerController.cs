using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Attributs

    private float _vitesse = 10f;

    private void Start()
    {
        // Position initiale du joueur.
        transform.position = new Vector3(-12f, 0f, -12f);
    }
    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float PositionX = Input.GetAxis("Horizontal");
        float PositionZ = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(PositionX, 0f, PositionZ);
        transform.Translate(direction * Time.deltaTime * _vitesse);

        //Debug.Log(PositionX + " , " + PositionY);

        //Vector3 direction = new Vector3(xPos, 0f, zPos);
       // transform.Translate(direction * Time.deltaTime * moveSpeed);
    }
}
