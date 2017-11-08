using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterController : MonoBehaviour {
	
	// Singleton
	private static MasterController instance;
	private static int setI;
    private List<IGameStateListener> gameStateListeners = new List<IGameStateListener>();

	private MasterController(){}

	public static MasterController Instance {
		get {
			if (instance == null && setI == 0) {
				setI = 1;
				//Debug.Log ("creating new Master");
				instance = new MasterController ();
			}
			return instance;
		}

	}

	// Data
	private ISceneController sceneController;
	// private GameState gameState;
	// private List<IGameStateListener> gameStateListener;
	// private Settings settings;

	// Methods

	// dependencies haven't been created yet...
	// private Boolean ChangeScene(string SceneName){

	// }

	private bool registerAsSceneController(ISceneController sceneController){
		//Might need additional operations to properly dispose of the old but...
		this.sceneController=sceneController;
		return true;
	}

	public ISceneController GetSceneController(){
		return sceneController;
	}

	public void initializeMenuSceneController()
	{
		//Debug.Log ("initializing!");
		sceneController = new SceneControllerMainMenu ();
	}

	// public void UpdateGameState(GameState gameState){
		
	// }

	// public void AddGameStateListener(IGameStateListener listener){

	// }

    public void addGameStateListener(IGameStateListener gameStateListener)
    {
        this.gameStateListeners.Add(gameStateListener);
    }

	private void Awake() {
		if(instance == null){
			DontDestroyOnLoad(gameObject);
			instance = this;
		} else if(instance != this){
			Destroy(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		sceneController = new SceneControllerMainMenu();


	}
	
	// Update is called once per frame
	void Update () {
		
	}
		

}
