using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    InputActions inputActions;
    //Fisicas
    Rigidbody rb;
    [SerializeField] float fuerza;
    //Interruptor
    bool pausado = false;

    //Joystick
    [SerializeField] float joyV;
    float joyX;

    private void Awake()
    {
        inputActions = new InputActions();

        inputActions.Game.Pause.started += _ => Pausar();
        //inputActions.Game.Pause.canceled += _ => DesPausar();

        inputActions.Player.JoyV.performed += ctx => joyV = ctx.ReadValue<float>();
        inputActions.Player.JoyV.canceled += _ => joyV = 0f;


    }

    void Pausar()
    {
        if(pausado == false)
        {
            Time.timeScale = 0;  
        }
        else
        {
            Time.timeScale = 1;
        }

        pausado = !pausado;
        

    }

    void DesPausar()
    {
        Time.timeScale = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        fuerza = 300f;
    }

    // Update is called once per frame
    void Update()
    {
        print(Time.time);
    }

    private void FixedUpdate()
    {
        rb.AddForce(Vector3.up * fuerza * joyV);
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}
