using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignParticleColor : MonoBehaviour {
	public ParticleSystem childParticle;


	public void assignColor(Color color){
		childParticle.startColor = color;
	}
}
