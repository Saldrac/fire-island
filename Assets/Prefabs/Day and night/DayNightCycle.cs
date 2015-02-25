using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour {

	public Light sun;
	public float base_intensity;
	public float cos_intensity;
	public float duration;
	public Material day_skybox;
	public Material night_skybox;
	public Color day_color;
	public Color dusk_color;
	private bool changed_skybox;
	public GameData gamedata;

	public void Start(){
		gamedata = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameData>();
	}


	// Update is called once per fixed frame
	void FixedUpdate () {
		float phi = Time.time / duration * 2 * Mathf.PI;
		float amplitude  = (Mathf.Cos( phi ) * cos_intensity) + base_intensity;
		sun.intensity = amplitude;
		changeCicle(amplitude);

	}

	void changeCicle(float amplitude){
		if(amplitude>0.3){
			RenderSettings.skybox = day_skybox;
			RenderSettings.fogColor = Color.grey;
			sun.color = day_color;
			gamedata.setDay(true);
		}
		else if( amplitude>0.1 && amplitude<0.45){
			sun.color = dusk_color;
		}
		else{
			RenderSettings.skybox = night_skybox;
			RenderSettings.fogColor = Color.black;
			gamedata.setDay(false);
		}
		}
}
