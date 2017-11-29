using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterController : MonoBehaviour {
	
	// Singleton
    public static MasterController instance { get; set; }
    private List<IGameStateListener> gameStateListeners = new List<IGameStateListener>();
    private ISceneController sceneController;
    private GameState gameState = GameState.LevelSinglePlayer;
    private List<IPlayer> unregisteredPlayers = new List<IPlayer>();

	//private MasterController(){}

	//public static MasterController Instance {
	//	get {
	//		return instance;
	//	}
	//}

	// Data
	// private GameState gameState;
	// private List<IGameStateListener> gameStateListener;
	// private Settings settings;

	// Methods

	// dependencies haven't been created yet...
	// private Boolean ChangeScene(string SceneName){

	// }

    public bool registerAsSceneController(ISceneController sceneController){
		//Might need additional operations to properly dispose of the old but...
		this.sceneController = sceneController;
        getInputsController().replaceListeners(sceneController);
        List<IPlayer> addedPlayers = new List<IPlayer>();
        foreach (IPlayer player in this.unregisteredPlayers)
        {
            this.sceneController.registerPlayer(player);
            addedPlayers.Add(player);

        }
        for (int i = 0; i < addedPlayers.Count; i++) 
        {
            this.unregisteredPlayers.Remove(addedPlayers[i]);
            
        }
		return true;
	}

	public ISceneController GetSceneController(){
		return sceneController;
	}

	//public void initializeMenuSceneController()
	//{
	//	//Debug.Log ("initializing!");
	//	sceneController = new SceneControllerMainMenu ();
	//}

	// public void UpdateGameState(GameState gameState){
		
	// }

	// public void AddGameStateListener(IGameStateListener listener){

	// }

    public void registerPlayer(IPlayer player) {
        if (this.sceneController != null)
        {
            this.sceneController.registerPlayer(player);
        }
        else 
        {
            this.unregisteredPlayers.Add(player);
        }
    }

    public IInputsController getInputsController() {
        return this.gameObject.GetComponent<IInputsController>();
    }


    public void addGameStateListener(IGameStateListener gameStateListener)
    {
        this.gameStateListeners.Add(gameStateListener);
        gameStateListener.UpdateForNewGameState(this.gameState);
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
		//sceneController = new SceneControllerMainMenu();


	}
	
	// Update is called once per frame
	void Update () {
		
	}
		

}
