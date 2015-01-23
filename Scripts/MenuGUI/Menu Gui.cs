/// <summary>
/// Menu GU.
/// </summary>
using UnityEngine;
using System.Collections;

public class MenuGUI : MonoBehaviour {

	//Variaveis do Menu Principal-*
	float largura = 40, altura = 45, posicaoX = 50, posicaoY = 20;
	Rect MenuPrincipalRect;
	//fim Menu Principal-------------*

	// Use this for initialization
	void Start () {
		MenuPrincipalRect = new Rect (escalaDaTela (posicaoX - (largura / 2), "x"), escalaDaTela (posicaoY, "y"), escalaDaTela (largura, "x"), escalaDaTela (altura, "y"));
	}

	void Update () {
	
	}

	/// <summary>
	/// Raises the GU event.
	/// </summary>
	void OnGUI () {
		MenuPrincipal ();
	}

	/// <summary>
	/// Funçao de desenho e organizaçao do menu principal
	/// </summary>
	void MenuPrincipal () {
		//Background do menu
		GUI.Box (MenuPrincipalRect, "Menu Principal\n (MenuGUI.cs linha 34)");
		//Cria uma area especifica e centralizada de desenho na tela, para o menu principal.
		GUILayout.BeginArea (MenuPrincipalRect);
		GUILayout.Space (40);		//Adiciona um espaço entre o titulo e o inicio dos botoes
		GUILayout.Box("Botao 1");	//Desenha uma caixa dentro da area inteira
		GUILayout.Box("Botao 2");	//Desenha uma caixa dentro da area inteira
		GUILayout.Box("Botao 3");	//Desenha uma caixa dentro da area inteira
		GUILayout.Box("Botao 4");	//Desenha uma caixa dentro da area inteira
		GUILayout.EndArea ();	//Fim da chamada de desenho da area, sempre esta funcao deve existir depois de um BeginArea()
	}

	/// <summary>
	/// Esta funçao serve para ajustar o tamanho e posiçao da interface dependendo da resoluçao do dispositivo.
	/// Retorna o posicionamento pela porcentagem passada.
	/// </summary>
	/// <param name="porcentagemDeRetorno">Porcentagem desejada da tela.</param>
	/// <param name="AlturaOuLargura">Verificador de orientaçao, para saber se a porcentagem e X ou Y.</param>
	float escalaDaTela (float porcentagemDeRetorno, string AlturaOuLargura) {	
		if(AlturaOuLargura == "x" || AlturaOuLargura == "X")	//Verifica se tem que retornar Horizontal.
			return Screen.width*(porcentagemDeRetorno/100);		//Retorna a porcentagem desejada, "Screen.width" pega a largura total da tela.
		else
				return Screen.height*(porcentagemDeRetorno/100);	//Retorna a porcentagem desejada, "Screen.height" pega a altura total da tela.
	}
}
