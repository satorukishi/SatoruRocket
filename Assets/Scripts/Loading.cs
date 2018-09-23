using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Transform loadingBar;
    public Transform textIndicator;
    public Transform textLoading;
    public GameObject rocket;
    public GameObject explosion;
    //public GameObject tentarNovamente;
    //public Text placar;

    [SerializeField] private float currentAmount;
    [SerializeField] private float speed;

    void Start()
    {
        loadingBar.GetComponent<Image>().color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {

        if (currentAmount > 70 && currentAmount < 100)
        {
            if (currentAmount >= 70 && currentAmount <= 75)
            {
                loadingBar.GetComponent<Image>().color = new Color(1.0f, 1.0f, 0.0f);
                if (Input.GetButtonUp("Fire1"))
                {
                    AtualizarPlacar(100);
                    AtualizarVelocidade(2.0f);
                }
            }
            else if (currentAmount >= 76 && currentAmount <= 80)
            {
                loadingBar.GetComponent<Image>().color = new Color(1.0f, 0.8f, 0.0f);
                if (Input.GetButtonUp("Fire1"))
                {
                    AtualizarPlacar(300);
                    AtualizarVelocidade(3.6f);
                }
            }
            else if (currentAmount >= 81 && currentAmount <= 85)
            {
                loadingBar.GetComponent<Image>().color = new Color(1.0f, 0.6f, 0.0f);
                if (Input.GetButtonUp("Fire1"))
                {
                    AtualizarPlacar(500);
                    AtualizarVelocidade(5.2f);
                }
            }
            else if (currentAmount >= 86 && currentAmount <= 90)
            {
                loadingBar.GetComponent<Image>().color = new Color(1.0f, 0.4f, 0.0f);
                if (Input.GetButtonUp("Fire1"))
                {
                    AtualizarPlacar(700);
                    AtualizarVelocidade(6.8f);
                }
            }
            else if (currentAmount >= 91 && currentAmount <= 95)
            {
                loadingBar.GetComponent<Image>().color = new Color(1.0f, 0.2f, 0.0f);
                if (Input.GetButtonUp("Fire1"))
                {
                    AtualizarPlacar(900);
                    AtualizarVelocidade(8.4f);
                }
            }
            else if (currentAmount >= 96 && currentAmount < 100)
            {
                loadingBar.GetComponent<Image>().color = new Color(1.0f, 0.0f, 0.0f);
                if (Input.GetButtonUp("Fire1"))
                {
                    AtualizarPlacar(1500);
                    AtualizarVelocidade(10.0f);
                }
            }
            
        }
        else
        {
            loadingBar.GetComponent<Image>().color = Color.green;
        }

        if (currentAmount > 99 && Botao.jogando)
        {
            Botao.jogando = false;
            Background.velocidade = 2.0f;
            var foguete = GameObject.FindGameObjectWithTag("Player");
            print("chegou no 100");
            Instantiate(explosion, foguete.transform.position, foguete.transform.rotation);
            GameObject.Find("Gameover").GetComponent<SpriteRenderer>().enabled = true;
            Destroy(foguete);
            Destroy(gameObject);

            //var foguete = GameObject.FindGameObjectWithTag("Player");
            //Destroy(foguete);

            //if (!explosion.GetComponent<Animation>().isPlaying)
            //{
            //    Botao.jogando = false;
            //    GameObject.Find("Gameover").GetComponent<SpriteRenderer>().enabled = true;
            //    //tentarNovamente.GetComponent<SpriteRenderer>().enabled = true;
            //}


            //var btnTentarDeNovo = GameObject.FindGameObjectWithTag("ButtonRetry");
            //btnTentarDeNovo.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (currentAmount < 100)
        {
            currentAmount += speed * Time.deltaTime;
            textIndicator.GetComponent<Text>().text = ((int)currentAmount).ToString() + "%";
            textLoading.gameObject.SetActive(true);
        }
        else
        {
            textLoading.gameObject.SetActive(false);
            textIndicator.GetComponent<Text>().text = "100%";
        }
        loadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
    }

    private void AtualizarPlacar(int addPontuacao)
    {
        Main.pontos += addPontuacao;
        currentAmount = 0;
    }

    /// <summary>
    /// Atualiza a velocidade do espaço dando a impressão que o foguete está mais rápido
    /// </summary>
    /// <param name="velocidade"></param>
    private void AtualizarVelocidade(float velocidade)
    {
        GetComponent<AudioSource>().Play();
        Background.velocidade = velocidade;
    }
}
