using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{
    public enum PlayerStatement { idle, walk, attack, hit, defend, die };
    public PlayerStatement MyState = PlayerStatement.idle;

    void Start()
    {
        if (!isServer)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 180f, 0f));
        }
    }

    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.A)) { MyState = PlayerStatement.attack; }
        if (Input.GetKeyDown(KeyCode.D)) { MyState = PlayerStatement.defend; }

        switch (MyState)
        {
            case PlayerStatement.attack : break;
            case PlayerStatement.defend : break;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("들왔다");
        var health = collider.GetComponent<HealthController>();

        if (health != null)
        {
            Debug.Log("깍는다");
            health.TakeDamage(10);
        }
    }
}
