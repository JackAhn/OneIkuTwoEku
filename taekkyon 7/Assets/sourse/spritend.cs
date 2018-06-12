using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class spritend : MonoBehaviour {
	public Sprite[] sprites;
	private SpriteRenderer spriterenderer;


	void Start () {
		spriterenderer = GetComponent<SpriteRenderer>();
		spriterenderer.sprite = sprites[0];
	}
	

	void Update () {
		
	}

	public void c1()
	{
		spriterenderer = GetComponent<SpriteRenderer>();
		spriterenderer.sprite = sprites[0];
	}
	public void c2()
	{
		spriterenderer = GetComponent<SpriteRenderer>();
		spriterenderer.sprite = sprites[1];
	}
	public void c3()
	{
		spriterenderer = GetComponent<SpriteRenderer>();
		spriterenderer.sprite = sprites[2];
	}


}
