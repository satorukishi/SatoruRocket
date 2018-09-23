using System.Collections;
using UnityEngine;

public class Lancamento : MonoBehaviour
{
    public GameObject loading;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(2.0f);
        Background.velocidade = 2.0f;
        Destroy(gameObject);
        Instantiate(loading);
    }

    void Update()
    {
    }
}
