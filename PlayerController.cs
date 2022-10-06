using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float horizontalInput;
    private float range = 10;

    public GameObject projetilPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RangePlayer();
        PlayerAtack();
    }

    void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

    }

    void RangePlayer()
    {
        if (transform.position.x < -range)
        {
            transform.position = new Vector3(-range, transform.position.y, transform.position.z);
        }

        if (transform.position.x > range)
        {
            transform.position = new Vector3(range, transform.position.y, transform.position.z);
        }
    }

    void PlayerAtack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projetilPrefab, new Vector3(transform.position.x,2,1), projetilPrefab.transform.rotation);
        }
    }
}
