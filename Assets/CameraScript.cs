using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	//The material with the shader we want to apply as a postprocess
	public Material mat;

	
	//See https://docs.unity3d.com/Manual/PostProcessingWritingEffects.html
	//See https://www.alanzucconi.com/2015/07/08/screen-shaders-and-postprocessing-effects-in-unity3d/
	//See https://docs.unity3d.com/ScriptReference/Camera.OnRenderImage.html
	
	private void OnRenderImage(RenderTexture src, RenderTexture dest) {
		 
		 //Change the value on the material
		 mat.SetFloat("_bwBlend", (Mathf.Sin(Time.time)*.5f + .5f));
		 
		 //Copy the src to the dest after applying material mat
		 Graphics.Blit(src, dest, mat);
	}
}
