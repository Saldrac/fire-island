using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameData : MonoBehaviour {
	public Transform player;
	public Camera player_camera;
	public Camera plane_camera;
	public int current_player_hp;
	public int max_player_hp;
	public bool day;
	public AudioSource camera_audiosource;
	public AudioClip day_music;
	public AudioClip night_music;
	public Transform waypoint;
	public int coins;
	public Canvas victorycanvas;
	public Canvas diecanvas;



	// Use this for initialization
	void Start () {
		current_player_hp = max_player_hp;
		setCameraAudioClip(day_music);
		player = GameObject.FindGameObjectWithTag("Player").transform;
		coins = 0;
	}
	
	// Update is called once per frame

	public void ApplyDamage(int damage){
		current_player_hp = current_player_hp - damage;
		//We clamp the new health so we ensure it's in valid range
		ClampHP();
		if(current_player_hp == 0)
			respawn();
	}

	public void Heal(int healed_amount){
		current_player_hp = current_player_hp + healed_amount;
		//We clamp the new health so we ensure it's in valid range
		ClampHP();
	}

	public void ClampHP(){
		current_player_hp = Mathf.Clamp(current_player_hp, 0, max_player_hp);
	}

	public void Victory(){
		plane_camera.gameObject.SetActive(true);
		player_camera.gameObject.SetActive(false);
		victorycanvas.gameObject.SetActive(true);

	}

	public void setDay(bool is_day){
		day = is_day;
		checkAmbientalMusic();
	}

	public void checkAmbientalMusic(){
		if(day && camera_audiosource.clip == night_music){
			setCameraAudioClip(day_music);
		}
		if(!day && camera_audiosource.clip == day_music){
			setCameraAudioClip(night_music);
		}
	}

	public void setCameraAudioClip(AudioClip audioclip){
		camera_audiosource.clip = audioclip;
		camera_audiosource.loop = true;
		camera_audiosource.Play();
	}

	public void setWayPoint(Transform new_waypoint){
		waypoint = new_waypoint;
	}

	public void respawn(){
		if(waypoint != null){
			player.position = waypoint.position;
			current_player_hp = max_player_hp;
			diecanvas.gameObject.SetActive(true);
			Invoke("Deactivate_dead_canvas",3);
		}
		else
			Application.LoadLevel(Application.loadedLevel);
	}

	public void incrementCoins(int value){
		coins = coins + value;
	}

	public void Deactivate_dead_canvas(){
		diecanvas.gameObject.SetActive(false);
	}
}
