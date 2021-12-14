using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player_controller : MonoBehaviour
{

    public TextMeshProUGUI arrowText;

   
    void Start()
    { arrowText.text = $"Pulsa cualquiera de las cuatro flechas, pero ten cuidado"; }

    void Update()
    {
        ShowMessage(KeyCode.DownArrow, $"Abajo, al centro de la tierra");
        ShowMessage(KeyCode.LeftArrow, $"Izquierda, esta flecha no hace nada");
        ShowMessage(KeyCode.RightArrow, $"A su derecha, la derecha");
        ShowMessage(KeyCode.UpArrow, $"Arriba, ignici�n");
        ShowMessage(KeyCode.Space, $"Se ha a�adido a la cesta de compra un mu�eco de my little ponny");
    }

    public void ShowMessage(KeyCode tecla, string message)
    {
        if (Input.GetKey(tecla))
        { arrowText.text = message; }
    }


}
