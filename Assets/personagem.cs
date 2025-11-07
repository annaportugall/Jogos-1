using UnityEngine;

public class personagem : MonoBehaviour
{
    public float angle;
    public float velocidade;

    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        float inputHorizontal = Input.GetAxis("Horizontal");
        Vector3 direcaoMovimento = transform.right * inputHorizontal;
        Debug.Log(direcaoMovimento);
        rb.linearVelocity = direcaoMovimento * velocidade;

       

    }
}