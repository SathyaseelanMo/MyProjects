
import random
import math

class Player():
    def __init__(self,letter):
        self.letter=letter
    def get_move(self,game):
        pass    

class HumanPlayer(Player):
    def __init(self,letter):
        super().__init__(letter)
    def get_move(self,game):
        valid_number=False
        val=None
        while not valid_number:
            square=input(self.letter +"\'s turn Enter valid num 0-8:") 
            '''try:
                val=int(square)
            except ValueError:
                print("enter a valid number!") '''   
            try:
               
               val=int(square)
               if val not in game.available_nums():
                   raise ValueError
               else:
                   valid_number=True
            except ValueError as e:
                print("enter a valid number!")

        return val  

class RandomComputerPlayer(Player):
    def __init__(self, letter):
        super().__init__(letter)
    def get_move(self, game):
        print(self.letter+"\'s turn...")
        val=random.choice(game.available_nums())
        return val      


class SuperComputerPlayer(Player):
    def __init__(self, letter):
        super().__init__(letter)

    def get_move(self, game):
        print(self.letter+"\'s turn...")
        if len(game.available_nums())==9:
            val=random.choice(game.available_nums())
            
        else:
            val=self.minimax(game,self.letter)["position"]
        return val   
       
    def minimax(self,state,player):
        Me=self.letter
        other_player= "X" if player=="O" else "O"
        if state.current_winner==other_player:
            if(other_player==Me):
                return{"position":None,"score":(state.no_of_available()+1)*1}
            else:
                return{"position":None,"score":(state.no_of_available()+1)*-1}
        elif not state.is_available():
            return {"position":None,"score":0}
        

        if Me==player:
            best={"position":None,"score":-math.inf}
        else:
            best={"position":None,"score":math.inf}
        for position in state.available_nums():
            state.make_move(position,player)
            sim = self.minimax(state,other_player)
            state.board[position]=" "
            state.current_winner=None
            sim["position"]=position
            if(Me==player):
                if(sim["score"]>best["score"]):
                    best=sim

            else:
                if(sim["score"]<best["score"]):
                    best=sim

        return best                
                            

            