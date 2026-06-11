using UnityEngine;

public class TreeInfo : MonoBehaviour
{
    public string nomePopular;
    public string especie;

    [TextArea]
    public string descricao;

    public void MostrarInformacao()
    {
        string texto =
            "<b>" + nomePopular + "</b>\n\n" +
            "Espécie: " + especie + "\n" +
            "Descrição: " + descricao;

        TooltipArvoreManager.Instance.Mostrar(transform, texto);
    }

    public void EsconderInformacao()
    {
        TooltipArvoreManager.Instance.Esconder();
    }
}