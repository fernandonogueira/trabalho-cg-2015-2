using UnityEngine;
using System.Collections;

public class CameraPadrao : MonoBehaviour {

	public float tremerIntensidade = 0.03f;
	public float tremerVelocidade = 0.007f;
	private float tremerFator;
	private Vector3 posicaoOriginal;
	private Quaternion rotacaoOriginal;

	// Movimenta a camera
	void Update ()
	{
		if (tremerFator > 0)
		{
			transform.position = posicaoOriginal + Random.insideUnitSphere * tremerFator;
			transform.rotation = new Quaternion(
				rotacaoOriginal.x + Random.Range (-tremerFator,tremerFator) * .2f,
				rotacaoOriginal.y + Random.Range (-tremerFator,tremerFator) * .2f,
				rotacaoOriginal.z + Random.Range (-tremerFator,tremerFator) * .2f,
				rotacaoOriginal.w + Random.Range (-tremerFator,tremerFator) * .2f);
			tremerFator -= tremerVelocidade;
		}
	}
	// Faz a tela tremer
	public void Tremer()
	{
		posicaoOriginal = transform.position;
		rotacaoOriginal = transform.rotation;
		tremerFator = tremerIntensidade;// .3f;
	}

}
