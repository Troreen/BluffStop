namespace VanillaCFR {
    public class BluffStoppersWrapper{

        Game game = new Game();
        public string history;
        
        public BluffStoppersWrapper(string history=""){
            this.history = history;
        }

        public void shuffleCards(){
            // shuffle cards
        }

        public int currentPlayer(){
            // return current player
            return 0;
        }

        public bool isTerminal(){
            // return true if game is over
            return false;
        }

        public string getInfoState(int player = -1){
            // return info state of player
            if (player == -1){
                player = currentPlayer();
            }
            return "";
            // ...
        }

        public int getUtility(int player = -1) {
            // return utility of player
            if (player == -1){
                player = currentPlayer();
            }
            // ...
            return 0;
        }

        public int getNumActions(){
            // return number of actions
            return 0;
        }

        public void applyAction(int action){
            // apply action to current player
        }

        public BluffStoppersWrapper clone(){
            // clone the current game

        }
    }
}