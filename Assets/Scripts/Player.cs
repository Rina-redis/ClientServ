using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.UI;


public class Player : NetworkBehaviour
{
    float DeltaMovement = 0.03f;
    public const int MaxHealth = 100;
    [SyncVar] int Health = MaxHealth;
    public Text HealthBar;
    private void Update()
    {
        HandleMovement();
        HealthBar.text = System.Convert.ToString(Health);

        void HandleMovement()
        {
            if (isLocalPlayer)
            {
                float MoveHorizontal = Input.GetAxis("Horizontal");
                float MoveVertical = Input.GetAxis("Vertical");
                Vector3 movement = new Vector3(MoveHorizontal, 0, MoveVertical);
                transform.position = transform.position + movement * DeltaMovement;
            }
        }
    }
}
