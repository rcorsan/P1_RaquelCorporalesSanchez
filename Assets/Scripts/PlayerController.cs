using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float velocidad = 2.0f;
    [SerializeField] private float fuerzasuelo = 30.0f;
    [SerializeField] private Rigidbody rb;
    private bool isGrounded;
    private Vector3 posicionRespawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        posicionRespawn = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    //MOVIMIENTO
       float horiz = Input.GetAxis("Horizontal");
       float verti = Input.GetAxis("Vertical");
       //Debug.Log("Valor Vertical: " + verti);

       Vector3 movimient= new Vector3(horiz*velocidad,rb.linearVelocity.y,verti*velocidad);
       rb.linearVelocity =movimient;
    //SALTO
       if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Salta();
        }

    }
    void Salta()
    {
        rb.AddForce(Vector3.up * fuerzasuelo,ForceMode.Impulse);
        isGrounded = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
            {
            isGrounded = true;
            }
    }
    public void Respawn()
    {
        transform.position = posicionRespawn;
        
        rb.linearVelocity = Vector3.zero; 
    }

}
