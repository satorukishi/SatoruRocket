using UnityEngine;

public class Botao : MonoBehaviour
{
    public GameObject foguete;
    public GameObject tentarNovamente;
    public static bool jogando;
    
	private GameObject logo;

    void Start()
    {
		jogando = false;
        logo = GameObject.Find("Logo");
        GameObject.Find("Gameover").GetComponent<SpriteRenderer>().enabled = false;
    }

    void Update()
    {
		if (!jogando && Input.GetButtonUp("Fire1"))
        {
			jogando = true;
            logo.GetComponent<SpriteRenderer>().enabled = false;
            //GameObject.Find("Gameover").GetComponent<SpriteRenderer>().enabled = false;
            //tentarNovamente.GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject);
            Instantiate(foguete);
            print("acabou o botao");
        }
    }

}
