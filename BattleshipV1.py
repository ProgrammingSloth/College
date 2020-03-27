from random import randrange
import time


boardP = ["", " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", ]
boardC = ["", " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ", ]
def BoardP(boardP):
    global place
    print("Players's Board")
    print("|   "  + "| A | B | C | D | E |")
    print("--------------------------") 
    print("| 1 "  + "| " + boardP[0] +"  | "  + boardP[1] + " | "  + boardP[2]+ " | "  + boardP[3] + " | "  + boardP[4]+ " | ")
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
    print("Computer's Board")
    print("|   "  + "| A | B | C | D | E |")
    print("--------------------------")
    print("| 1 "  + "| "  + boardC[0] +"  | "  + boardC[1] + " | "  + boardC[2]+ " | "  + boardC[3] + " | "  + boardC[4]+ " | ")
    print("--------------------------")
    print("| 2 "  + "| "  + boardC[5] +" | "  + boardC[6] + " | "  + boardC[7]+ " | "  + boardC[8] + " | " + boardC[9]+ " | ")
    print("--------------------------")
    print("| 3 "  + "| "  + boardC[10] +" | "  + boardC[11] + " | "  + boardC[12]+ " | "  + boardC[13] + " | "  + boardC[14]+ " | ")
    print("--------------------------")
    print("| 4 "  + "| "  + boardC[15] +" | "  + boardC[16] + " | "  + boardC[17]+ " | "  + boardC[18] + " | "  + boardC[19]+ " | ")
    print("--------------------------")
    print("| 5 "  + "| "  + boardC[20] +" | "  + boardC[21] + " | "  + boardC[22]+ " | "  + boardC[23] + " | "  + boardC[24]+ " | ")
    print("--------------------------")

def ComputerShips():
    global CShips
    CshipCount = 0
    while CshipCount < 4:
        CShips = randrange(20)
        boardC[CShips] = "S"
        CshipCount = CshipCount + 1


def placeOnBoard():
    boardP[place] = "S"
    BoardP(boardP)

def repeatShips():
    shipcount = 0
    while shipcount != 3:
        coordsConvert()
        shipcount = shipcount + 1

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
    
    Coord=set(columnComp).intersection(rowComp)
    place = listToString(Coord)
    if placingships == True:
        placeOnBoard()
        PlayerShip = place

    else:
        playerMove = place

def listToString(s):  
    
    # initialize an empty string 
    str1 = ""
    # traverse in the string   
    for ele in s:  
        return ele   



def placeShips():
    global placingships
    print(BoardP(boardP))
    placingships = True
    print("It's time to place your ships! \n")     
    repeatShips()

def ComputerMove():
    global CMove
    CMove = randrange(20)

def ChangeMove():
    print("The computer is making a move!" , end =" ")
    #time.sleep allows you to create a small delay in the program. The number in the brackets is seconds.
    time.sleep(0.25)
    print(".", end =" ")
    time.sleep(0.25)
    print(".", end =" ")
    time.sleep(0.25)
    print(".")
    time.sleep(5)

def scoreCount():
    global Hit
    score = 0
    if Hit == True:
        score = score +1


def hitShips():
    global placingships
    global Hit
    placingships = False
    print("Where do you want to hit your opponent! \n")
    Hit = False
    while Hit == False:
        coordsConvert()
        ComputerMove()
        if playerMove == CShips:
            print("Hit")
            Hit = True
            boardC[CShips] = "H"
            boardP[CShips] = "H"
            BoardC(boardC)
            print("You hit a computer ship!")
            scoreCount()
            time.sleep(1)
            break
        else:
            boardC[playerMove] = "M"
            boardP[playerMove] = "M"
            BoardP(boardP)
            BoardC(boardC)
            print("You missed!")
            time.sleep(1)

        ChangeMove()

        if PlayerShip == CMove:
            Hit = True
            boardC[CMove] = "H"
            boardP[CMove] = "H"
            BoardC(boardC)
            print("The computer hit your ship!")
            scoreCount()
            time.sleep(1)
            break

        else:
            boardC[CMove] = "M"
            boardP[CMove] = "M"
            BoardP(boardP)
            BoardC(boardC)
            print("The computer missed!")
            time.sleep(1)
        
            
            


print("Welcome to battleships by Sloth!")
time.sleep(2)
placeShips()
ComputerShips()
print(BoardC(boardC))
hitShips()
