using UnityEngine;
using System.Collections;

public class MovimentoHorizontal : MonoBehaviour {

	  //Variavel que vai receber o valor da velocidade do movimento
	  public float Velocidade; 

	  void Update(){
	    	Movimento ();// a funçao e chamado na update para que ela seja exetultada a cada frame.
  	}

  	//Funçao responsavel por efetuar o movimento.
  	void Movimento(){
	    	// Anda para a direita
  	  	if(Input.GetAxisRaw("Horizontal") > 0) 
  	  	{
	    		transform.Translate(Vector2.right * Velocidade * Time.deltaTime);
	    		transform.eulerAngles = new Vector2(0, 0); // movimento em diraçao ao angulo 0.
	    	}
	    	// Anda para a esquerda
	    	if (Input.GetAxisRaw ("Horizontal") < 0) 
	    	{
	    		transform.Translate(Vector2.right * Velocidade * Time.deltaTime);
	    		transform.eulerAngles = new Vector2(0,180); // movimento em diraçao ao angulo 180.
	  	}
	}
}
