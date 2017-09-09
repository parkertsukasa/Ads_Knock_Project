using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class TitleButtonManager : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		//UnityAdsの初期化
		if(Advertisement.isSupported)
		{
			Advertisement.Initialize ("1538243");
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void MovieButton()
	{
		AdsPlay ();
	}

	//広告の表示を行う関数
	void AdsPlay()
	{
		if(Advertisement.IsReady())
		{
			Advertisement.Show ();
		}
	}
}
