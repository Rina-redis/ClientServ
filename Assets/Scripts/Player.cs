using Mirror;
using UnityEngine;
using UnityEngine.UI;


public class Player : NetworkBehaviour
{
    float DeltaMovement = 0.03f;
    public const int MaxHealth = 100;
    [SyncVar] int Health = MaxHealth;
    public Text HealthBar;
    public float MouseSesativity = 1.5f;


    private float x;
    private float y;
    private Vector3 rotateValue;


    private void Update()
    {

        HandleMovement();
        //CameraMovement();
        HealthBar.text = System.Convert.ToString(Health);



    }

    void HandleMovement()
    {
        if (isLocalPlayer)
        {

            float MoveHorizontal = Input.GetAxis("Horizontal");
            float MoveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(MoveHorizontal, 0, MoveVertical);
            transform.position = transform.position + movement * DeltaMovement;


            y = Input.GetAxis("Mouse X");
            x = Input.GetAxis("Mouse Y");

            rotateValue = new Vector3(x * MouseSesativity, (y * -1) * MouseSesativity, 0);
            transform.eulerAngles = transform.eulerAngles - rotateValue;
        }
    }
    //void CameraMovement()
    //{
    //    if (isLocalPlayer) 
    //    {

    //    }

    //}
}
