using UnityEngine;

public class Background : MonoBehaviour
{

    public float limiteY;
    public float retornarY;
    public static float velocidade;

    // Update is called once per frame
    void Update()
    {
        if (Botao.jogando)
        {
            if (transform.position.y < limiteY)
            {
                transform.position = new Vector3(transform.position.x, retornarY, 0.0f);
            }
            Debug.Log(velocidade);
            transform.Translate(Vector3.down * velocidade * Time.deltaTime);
        }
    }
}
