import time
import math 
from Player import HumanPlayer,RandomComputerPlayer,SuperComputerPlayer
class TicTacToe():
    def __init__(self):
        self.board=[" " for _ in range(9)]
        self.current_winner=None

    def print_board(self):
        for row in (self.board[i*3:(i+1)*3] for i in range(3)):
            print("|".join(row))

    def make_move(self,number,letter):
        if self.board[number]==" ":
            self.board[number]=letter
            if (self.winner(number,letter)):
                self.current_winner=letter
            return True    
        return False

    def is_available(self):
        if " " in self.board:
            return True
        else:
           return False
        

    def available_nums(self):
        available=[]
        for (i,e) in enumerate(self.board):
            if (self.board[i]==" "):
                available.append(i)
        return available
    
    def no_of_available(self):
        a=self.available_nums()
        return len(a)
    
    def print_number_board(self):
        number_board=[ [str(j) for j in range(i*3,(i+1)*3)] for i in range(3)]
        for row in number_board:
            print("|".join(row))


    def winner(self,number,letter):
        row_index=number//3
        row=self.board[row_index*3:(row_index+1)*3]
        if all([s==letter for s in row]):
            return True
        col_index=number%3
        col=[self.board[col_index+(i*3)] for i in range(3)]
        if all([s==letter for s in col]):
            return True
        if number%2==0:
            dia1=[self.board[i] for i in [0,4,8]]
            if all([s==letter for s in dia1]):
                return True
            dia2=[self.board[i] for i in [2,4,6]]
            if all([s==letter for s in dia2]):
                return True
        return False 
    

def play(game,X_player,O_Player):
    letter="X"
    game.print_number_board()
    while(game.is_available()):
        if (letter=="X"):
            inp=X_player.get_move(game)
        else:
            inp=O_Player.get_move(game)
        if (game.make_move(inp,letter)):
            game.print_board()
            print(" ")
            if(game.current_winner):
                print("Winner is: "+game.current_winner)
                time.sleep(10)
                return True
            
            letter="X" if letter=="O" else "O"
        time.sleep(1)


   
    print("It's a tie!") 
    time.sleep(10)           
                

if __name__=='__main__': 
  
  t=TicTacToe()
  x=True
  o=True
  while(x):
    print("Whom do you want as \"X\": 1.HumanPlayer 2.RandomComputerPlayer 3.SuperComputerPLayer")
    x_inp=int(input("X :"))
    match x_inp:
      case 1:
        X_player=HumanPlayer("X")
        x_inp="HumanPlayer"
        x=False
      case 2:
        X_player=RandomComputerPlayer("X")
        x_inp="RandomComputerPlayer"
        x=False
      case 3:
        X_player=SuperComputerPlayer("X")
        x_inp="SuperComputerPlayer"
        x=False
      case _:
        print("Enter valid X") 

  while(o):
    print("Whom do you want as \"O\": 1.HumanPlayer 2.RandomComputerPlayer 3.SuperComputerPLayer")
    y_inp=int(input("O :"))
    match y_inp:
      case 1:
        O_player=HumanPlayer("O")
        o_inp="HumanPlayer"
        o=False
      case 2:
        O_player=RandomComputerPlayer("O")
        o_inp="RandomComputerPlayer"
        o=False
      case 3:
        O_player=SuperComputerPlayer("O")
        o_inp="SuperComputerPlayer"
        o=False
      case _:
        print("Enter valid O")         
  
   
  print(x_inp +" "+"vs"+" "+ o_inp)
  

  play(t,X_player,O_player)
#print(ans) 
      



