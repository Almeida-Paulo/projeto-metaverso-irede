using UnityEngine;
using TMPro;

public class TooltipArvoreManager : MonoBehaviour
{
    public static TooltipArvoreManager Instance;

    public GameObject Info;
    public TMP_Text TextInfo;

    public Vector3 offsetTela = new Vector3(80, 80, 0);

    private Transform alvoAtual;

    private void Awake()
    {
        Instance = this;
        Info.SetActive(false);
    }

    private void Update()
    {
        if (alvoAtual != null)
        {
            Vector3 posicaoTela =
                Camera.main.WorldToScreenPoint(alvoAtual.position);

            Info.transform.position =
                posicaoTela + offsetTela;
        }
    }

    public void Mostrar(Transform alvo, string texto)
    {
        alvoAtual = alvo;
        TextInfo.text = texto;
        Info.SetActive(true);
    }

    public void Esconder()
    {
        alvoAtual = null;
        Info.SetActive(false);
    }
}