[System.Serializable]
public class MainMenuData
{
    //Daten die langfristig gespeichert werden sollen, welche dann zum binary file verschl�sselt werden (100101101)
    public int totalScore;
    public int gameScore;

    public MainMenuData(MainMenu mainMenu)
    {
        totalScore = mainMenu.totalScore;
        gameScore = mainMenu.gameScore;
    }

}
