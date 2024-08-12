using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    #region Singleton
    Button[] botoes;
    [SerializeField]
    TextMeshProUGUI sequenciaTexto, acertouTexto, errouTexto;
    #endregion
    // Start is called before the first frame update
    public void Start()
    {
        for (int i = 0; i < botoes.Length; i++)
        {
            botoes[i] += GameManager.ChecarCor(i); //erro que eu preciso tirar duvida

        }
    }

    public void atualizarAcertos(int acertouTexto)
    {
        acertouTexto.ToString();
    }

    public void atualizarErros(int errouTexto)
    {
        errouTexto.ToString();
    }

    public void LimparTexto(int texto)
    {
        texto.ToString("");
    }
    public void AtualizarSequencia(string cor)
    {
        cor = cor.ToString();

    }
}
