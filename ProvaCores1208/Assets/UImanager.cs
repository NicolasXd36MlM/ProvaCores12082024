using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
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
    void Start()
    {
        for (int  i= 0; i < botoes.Length; i++)
        {
            // botoes[i].GameManager.ChecarCor.onClick;
           
        }
    }

    public void atualizarAcertos(int acertouTexto) => acertouTexto.ToString();

    public void atualizarErros(int errouTexto) => errouTexto.ToString();

   public void LimparTexto (int texto) => texto.ToString("");
    // Update is called once per frame
    void Update()
    {
        
    }
}
