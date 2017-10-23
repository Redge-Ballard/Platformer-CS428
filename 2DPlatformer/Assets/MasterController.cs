using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterController : MonoBehaviour {
	
	// Singleton
	private static MasterController Instance;

	// Data
	// private ISceneController sceneController;
	// private GameState gameState;
	// private List<IGameStateListener> gameStateListener;
	// private Settings settings;

	// Methods

	// dependencies haven't been created yet...
	// private Boolean ChangeScene(string SceneName){

	// }

	// private Boolean RegisterAsSceneController(ISceneController sceneController){

	// }

	// public ISceneController GetSceneController(){

	// }

	// public void UpdateGameState(GameState gameState){
		
	// }

	// public void AddGameStateListener(IGameStateListener listener){

	// }

	private void Awake() {
		if(Instance == null){
			DontDestroyOnLoad(gameObject);
			Instance = this;
		} else if(Instance != this){
			Destroy(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
