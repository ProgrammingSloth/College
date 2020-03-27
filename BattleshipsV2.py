#=======================================================================================
#Import Library

from random import randrange
import time

#=======================================================================================
#Boards


def BoardP(boardP):
    global place
    print("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=")
    print("Players's Board")
    print("|   "  + "| A | B | C | D | E |")
    print("--------------------------") 
    print("| 1 "  + "| " + boardP[0] + "  | "  + boardP[1] + " | "  + boardP[2]+ " | "  + boardP[3] + " | "  + boardP[4]+ " | ")
    print("--------------------------")
    print("| 2 "  + "| "  + boardP[5] +" | "  + boardP[6] + " | "  + boardP[7]+ " | "  + boardP[8] + " | " + boardP[9]+ " | ")
    print("--------------------------")
    print("| 3 "  + "| "  + boardP[10] +" | "  + boardP[11] + " | "  + boardP[12]+ " | "  + boardP[13] + " | "  + boardP[14]+ " | ")
    print("--------------------------")
    print("| 4 "  + "| "  + boardP[15] +" | "  + boardP[16] + " | "  + boardP[17]+ " | "  + boardP[18] + " | "  + boardP[19]+ " | ")
    print("--------------------------")
    print("| 5 "  + "| "  + boardP[20] +" | "  + boardP[21] + " | "  + boardP[22]+ " | "  + boardP[23] + " | "  + boardP[24]+ " | ")
    print("--------------------------")

def BoardC(boardC):
    global place
    print("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=")
    print("Computer's Board")
    print("|   "  + "| A | B | C | D | E |")
    print("--------------------------")
    print("| 1 "  + "| " + boardC[0] +"  | "  + boardC[1] + " | "  + boardC[2]+ " | "  + boardC[3] + " | "  + boardC[4]+ " | ")
    print("--------------------------")
    print("| 2 "  + "| "  + boardC[5] +" | "  + boardC[6] + " | "  + boardC[7]+ " | "  + boardC[8] + " | " + boardC[9]+ " | ")
    print("--------------------------")
    print("| 3 "  + "| "  + boardC[10] +" | "  + boardC[11] + " | "  + boardC[12]+ " | "  + boardC[13] + " | "  + boardC[14]+ " | ")
    print("--------------------------")
    print("| 4 "  + "| "  + boardC[15] +" | "  + boardC[16] + " | "  + boardC[17]+ " | "  + boardC[18] + " | "  + boardC[19]+ " | ")
    print("--------------------------")
    print("| 5 "  + "| "  + boardC[20] +" | "  + boardC[21] + " | "  + boardC[22]+ " | "  + boardC[23] + " | "  + boardC[24]+ " | ")
    print("--------------------------")
    print("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=")


#=======================================================================================
#Place Human and Computer Ships 
def ComputerShips(): # A F/P that creates the variables for each of the 3 computer ships and places them on the board
    global CShips1   # It does this by using the random number generator with a range of 1 - 20
    global CShips2
    global CShips3
    CShips1 = randrange(20)
    CShips2 = randrange(20)
    CShips3 = randrange(20)
    DupShipCheck = True
    while DupShipCheck == True:
        if CShips1 == CShips2 or CShips1 == CShips3 :
                CShips1 = randrange(20)
                CShips2 = randrange(20)
                CShips3 = randrange(20)
        else:
            boardC[CShips1] = "S"
            boardC[CShips2] = "S"
            boardC[CShips3] = "S"
            break
        


#================================

def placeShips(): #Function which places a ship and uses another counter to loop
    global placingships
    BoardP(boardP)
    placingships = True
    print("\nIt's time to place your ships!")     
    repeatShips()

#================================
    
def repeatShips():
    shipcount = 0
    while shipcount != 3:
        coordsConvert()
        shipcount = shipcount + 1
        
#================================
    
def placeOnBoard():  # Places the player ship on the board
    boardP[place] = "S"
    BoardP(boardP)
    
#================================

def coordsConvert():
    global place
    global playerMove
    global PlayerShip
    columnComp = []
    rowComp = []
    while True:
        column = input("What Column?:")
        if column == "A":
            columnComp = [0,5,10,15,20]
            break

        elif column == "B":
                columnComp = [1,6,11,16,21]
                break

        elif column == "C":
                columnComp = [2,7,12,17,22]
                break
        elif column == "D":
                columnComp = [3,8,13,18,23]
                break

        elif column == "E":
                columnComp = [4,9,14,19,24]
                break

        else:
                print("That option wasn't valid")
            

    while True:
       row = input("What Row?:")
       if row == "1":
            rowComp = [0,1,2,3,4]
            break

       elif row == "2":
           rowComp = [5,6,7,8,9]
           break

       elif row == "3":
            rowComp = [10,11,12,13,14]
            break

       elif row == "4":
            rowComp = [15,16,17,18,19]
            break
       elif row == "5":
            rowComp = [20,21,22,23,24]
            break

       else:
           print("That option wasn't valid")
        #Finds the correct coordinate. But breaks because output is a list and not a variable 
    
    Coord=set(columnComp).intersection(rowComp) # Get's the coords in a number format
    place = listToString(Coord) # Converts list data to string
    
    if placingships == True: # If start ship toggle is true then just place as a move and not as a new ship
        placeOnBoard()
        PlayerShip = place

    else:
        playerMove = place
        
#================================
        
def listToString(s):  # Function which converts the list data from the previous command and converts it to a string 
    
    # initialize an empty string 
    str1 = ""
    # traverse in the string   
    for ele in s:  
        return ele
    
#=======================================================================================
#Both Player and Computer Moves
    
def ComputerHitOrMiss():
    global CMove
    global CHit
    print("The computer is making a move!" , end =" ")
    #time.sleep allows you to create a small delay in the program. The number in the brackets is seconds.
    time.sleep(0.25)
    print(".", end =" ")
    time.sleep(0.25)
    print(".", end =" ")
    time.sleep(0.25)
    print(".")

    CMove = randrange(20)
    
    CHit = False
    
    if PlayerShip == CMove:
        CHit = True
        boardC[CMove] = "H"
        boardP[CMove] = "H"
        print("The computer hit your ship!")
        scoreCount()
        time.sleep(3)  

    else:
        boardP[CMove] = "M"
        print("The computer missed!")
        time.sleep(2)

#================================

def PlayerHitOrMiss():
    global placingships
    global PHit
    global CHit
    
    placingships = False
    PHit = False
    
    print("\nWhere do you want to hit your opponent? \n")
    BoardP(boardP)
    BoardC(boardC)
    coordsConvert()
    if playerMove == CShips1:
        PHit = True
        boardC[CShips1] = "H"
        BoardP(boardP)
        BoardC(boardC)
        print("You hit a computer ship!")
        scoreCount()
        

    elif playerMove == CShips2:
        PHit = True
        boardC[CShips2] = "H"
        BoardP(boardP)
        BoardC(boardC)
        print("You hit a computer ship!")
        scoreCount()
        
        
    elif playerMove == CShips3:
        PHit = True
        boardC[CShips3] = "H"
        BoardP(boardP)
        BoardC(boardC)
        print("You hit a computer ship!")
        scoreCount()
        

    else:
        boardC[playerMove] = "M"
        BoardP(boardP)
        BoardC(boardC)
        print("You missed!")
        scoreCount()
        time.sleep(1)

#=======================================================================================      
#Calculate Score
            
def scoreCount():
    global PScore
    global CScore

    global PHit
    global CHit
    
    if PHit == True:
        PScore = PScore +1
        PHit = False
    elif CHit == True:
        CScore = CScore +1
        CHit = False

#=======================================================================================    
#Store the score in a text file

def StoreScore():
    if PScore == 3:
        
        TempStore = "Player's Score = 3\nComputer's Score " + str(CScore)
        file = open("Scores\\Scores.txt", "a")
        file.write("Game Number: ")
        file.write(str(GameCount))
        file.write("\n")
        file.write(TempStore)
        file.write("\n")
        file.close()
#=======================================================================================
#Clear the Board

def ClearBoard():
    global boardP
    global boardC
    boardP = ["", " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", ]
    boardC = ["", " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", ]


        
#=======================================================================================
#Play the Game Again
        
def PlayAgain():
    global GameCount
    print("\n")
    print("Welcome to battleships by Sloth!")
    print("=- Play -=- Exit -= ")
    while True:
        option = input("> ").lower()
        
        if option == "play":
            GameCount = GameCount + 1
            ClearBoard()
            MainRun()
            
        elif option == "exit":
            file = open("Scores\\Scores.txt", "a")
            file.write("Session End")
            file.write("==============================================")
            file.write("\n")
            file.close()
            print("Thank you for playing", end=" ")
            time.sleep(0.25)
            print(".", end =" ")
            time.sleep(0.25)
            print(".", end =" ")
            time.sleep(0.25)
            print(".")
            raise SystemExit()
            
           
        else:
            print(option +" is not valid.")
            
#=======================================================================================
#Main Program Loop
            
def MainRun():
    global PScore
    global CScore
    PScore = 0
    CScore = 0
    time.sleep(0.5)
    placeShips()
    ComputerShips()
    while True:
        if PScore == 3 or CScore == 3:
            StoreScore()
            PlayAgain()
                        
        else:
            PlayerHitOrMiss()
            if PScore == 3 or CScore == 3:
                StoreScore()
                PlayAgain()
            else:
                ComputerHitOrMiss()
#=======================================================================================
#Beginning Code
GameCount = 0
PlayAgain()

#================================

