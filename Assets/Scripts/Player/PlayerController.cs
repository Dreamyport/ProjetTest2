using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 5f;

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
        float xPos = Input.GetAxis("Horizontal");
        float zPos = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(xPos, 0f, zPos);
        transform.Translate(direction * Time.deltaTime * moveSpeed);
    }
}
