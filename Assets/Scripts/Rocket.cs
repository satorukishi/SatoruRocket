using UnityEngine;

public class Rocket : MonoBehaviour
{
    //public GameObject logo;
    //public GameObject loading;

    private Animator animator;

    void Start()
    {
        Debug.Log("Start is called");

        ////logo.GetComponent<SpriteRenderer>().enabled = false;
        //loading.GetComponent<SpriteRenderer>().enabled = false;
        //animator = GetComponent<Animator>();
        //animator.enabled = false;
        GetComponent<AudioSource>().Play();

    }


    void Update()
    {
        //Debug.Log("Update is called");

        //if (Input.GetButtonDown("Fire1") && !Botao.jogando)
        //{
        //    //logo.GetComponent<SpriteRenderer>().enabled = false;
        //    loading.GetComponent<SpriteRenderer>().enabled = true;
        //    GetComponent<SpriteRenderer>().enabled = true;
        //    Botao.jogando = true;
        //    animator.enabled = true;
        //    animator.speed = 0.5f;
        //}
    }
    
}
