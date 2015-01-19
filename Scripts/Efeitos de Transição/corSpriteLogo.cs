using UnityEngine;
using System.Collections;

public class corSpriteLogo : MonoBehaviour {
	bool MaisAlpha;						//Chave para saber se é fadeIn ou fadeOut
	public float A, R,G,B;				//Escala de cores da imagem que terá o efeito de Fade
	public float  velocidade = 0.2f;	//velocidade da animação
	public Color cor;					//cor Inicial da imagem
	public SpriteRenderer ImagemDeExibicao;		//imagem a ser aplicado o efeito de fade
	// Use this for initialization
	void Start () {
		ImagemDeExibicao = GetComponent<SpriteRenderer>();		//Obtem o componente de textura2D(sprite) do próprio objeto em que este script está inserido
		A = ImagemDeExibicao.color.a;							//Obtem o Alpha da imagem
		R = ImagemDeExibicao.color.r;							//Obtem o canal Vermelho da imagem
		G = ImagemDeExibicao.color.g;							//Obtem o canal Verde da imagem
		B = ImagemDeExibicao.color.b;							//Obtem o canal Azul da imagem
		
		MaisAlpha = true;										//Libera o efeito de fade
	}
	
	// Update is called once per frame
	void Update () {
		efeitoSimples();				//Chama a função de efeito de Fade Simples
		
		ImagemDeExibicao.color = cor;	//Atribui a cor desejada, a imagem
	}
	
	void efeitoSimples () {		
		if(A < 1 && MaisAlpha)					
			A += velocidade * Time.deltaTime;	//Adiciona alpha na imagem isso causa um efeito de clareamento (fadeIn)
		else if(A > 1 && (R+G+B) < 5) {			//2 segundos de espera para começar a transição para a cena de menu
			MaisAlpha = false;					//Durante esse processo uma animação de mistura de cor é feita até que a cor original apareça
			R += velocidade * Time.deltaTime;	
			G += velocidade * Time.deltaTime;
			B += velocidade * Time.deltaTime;
		}else if(A > 0 && !MaisAlpha)
			A -= velocidade * Time.deltaTime;	//Tira a cor do canal Alpha causando um efeito de FadeOut
		else
			Application.LoadLevel(Application.loadedLevel+1);	//Carrega a primeira cena, sempre uma cena depois da abertura
			
		cor.a = A;
		cor.r = R;
		cor.g = G;
		cor.b = B;
	}
}
