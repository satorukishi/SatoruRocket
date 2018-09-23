using System.Collections;
using UnityEngine;

public class Explosao : MonoBehaviour
{
    public float tempo;
    public GameObject tentarNovamente;

    IEnumerator Start()
    {
        gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(tempo);
        Destroy(gameObject);
        Instantiate(tentarNovamente);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
