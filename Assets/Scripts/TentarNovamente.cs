using UnityEngine;

public class TentarNovamente : MonoBehaviour
{
    public GameObject foguete;

    //private GameObject logo;

    void Start()
    {
        //print("TENTE NOVAMENTE");
        //logo = GameObject.Find("TentarNovamente");
    }

    void Update()
    {
        print("TENTE NOVAMENTE - UPDATE");
        if (!Botao.jogando && Input.GetButtonUp("Fire1"))
        {
            Main.pontos = 0;
            Botao.jogando = true;
            //logo.GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("Gameover").GetComponent<SpriteRenderer>().enabled = false;

            Destroy(gameObject);
            Instantiate(foguete);
        }
    }
}
