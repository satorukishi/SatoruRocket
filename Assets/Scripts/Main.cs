using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    private static int _pontos;
    public static int pontos
    {
        get
        {
            return _pontos;
        }
        set
        {
            _pontos = value;
            GameObject.Find("Placar").GetComponent<Text>().text = _pontos.ToString();
        }
    }
}
