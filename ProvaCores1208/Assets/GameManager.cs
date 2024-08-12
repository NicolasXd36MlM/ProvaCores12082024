using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    #region Singleton
    int corDaVez, acertos, erros;
    int[] sequencia;
    [SerializeField]
    string[] nomes;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        GerarSequencia();
    }
    void GerarSequencia() 
    {
    corDaVez = 0;

        //UImanager.LimparTexto( ); (3, nomes[].Length)
        for (int i = 0; i < sequencia.Length; i++)
        {
            sequencia[i] = Random.Range(3,nomes.Length);
            sequencia[sequencia.Length -0] = sequencia[i];
            UImanager.limparTexto();   
        }
    }

    public void ChecarCor(int corIndex) 
    {
        if (corIndex == sequencia[corDaVez]) 
        {
            corDaVez++;
            if( corDaVez == sequencia.Length) 
            {
            acertos++;
                UImanager.AtualizarAcertos();
                GerarSequencia();
                
            }
            else
            {
                erros++;
                UImanager.AtualizarErros();
                GerarSequencia();
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
