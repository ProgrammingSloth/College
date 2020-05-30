import sys
from tkinter import *
from tkinter.messagebox import showinfo
from random import randint
root = Tk()
root.configure(background="cornsilk2")
root.wm_iconbitmap("Mine.ico")
root.geometry("270x110")
root.resizable(0,0)
passcode = '%s%s%s%s' % (randint(1,9), randint(1,9), randint(1,9), randint(1,9))
print(passcode)
num_guesses = 10

def button_countdown(i, label):
    if i == 30:
        showinfo("Hurry Up..","The police have arrived you have 30 seconds left!")
        i -= 1
        label.set(i)
        root.after(1000, lambda: button_countdown(i, label))
                   
    elif i > 0 :
        i -= 1
        label.set(i)
        root.after(1000, lambda: button_countdown(i, label))
        
    else:
        showinfo("Game Over","The police caught you before you were able to loot the vault,\nBetter luck next time!")
        root.destroy()
        
def msgbox():
    showinfo("Lock Status","You got %s numbers correct: %s \n You have %d guesses left"  % (num_correct, ''.join(compare),num_guesses))
def Winner():
    showinfo("Winner", "Congrats you cracked the lock and looted the vault!")

def check_answer(passcode, guess):
    global compare
    compare = ['X','X','X',"X"]
    global num_correct
    num_correct = 0
    msg =True
    for i in range(0,4):
        if passcode[i] == guess[i]:
            compare[i] = passcode[i]
            num_correct += 1
        else:
            pass       
    
    if num_correct == 4:
        Winner()
        root.destroy()
        msg= False
        

    else:
        pass
    
    while msg == True: 
        msgbox()
        msg = False
    
    
        
def printSomething():
    answer = e.get()
    global guess
    global num_guesses
    guess=(answer)     
    if len(guess) != 4:
        showinfo("Info..","That is not a 4 digit number, you just wasted a guess")
        num_guesses -= 1
        msgbox
        
    else:
        check_answer(passcode, guess)
        num_guesses -= 1
        
    if num_guesses < -1:  
        showinfo("Game Over","You have used your 10 guesses and the vault has sealed \nThe lock's code was %s" % passcode)
        root.destroy()
        


def limitSizeDay(*args):
    value = dayValue.get()
    if len(value) > 4: dayValue.set(value[:4])

def Delete():
    e.delete(len(e.get())-1)
    
def one():
    e.insert(4,"1")
def two():
    e.insert(4,"2")
def three():
    e.insert(4,"3")
def four():
    e.insert(4,"4")
def five():
    e.insert(4,"5")
def six():
    e.insert(4,"6")
def seven():
    e.insert(4,"7")
def eight():
    e.insert(4,"8")
def nine():
    e.insert(4,"9")
def zero():
    e.insert(4,"0")


dayValue = StringVar()
dayValue.trace('w', limitSizeDay)

DelValue = StringVar()
DelValue.trace('w', Delete)

root.title("Cracking the lock")
w = Label(root, fg="black", text="Can you crack the lock?", bg="cornsilk2" ).grid(row=0, column=4, sticky=W)


e = Entry(textvariable=dayValue)
e.grid(row=1, column=4,)


w = Button(root, text="Enter", command= printSomething,fg="cornsilk2", bg="#383a39").grid(row=1, column=5,)
w = Button(root, text="Delete", command= Delete,fg="cornsilk2", bg="#383a39").grid(row=1, column=6,)



w = Button(root,text="1", command=one,fg="cornsilk2", bg="#383a39" )
w.grid(row=0, column=1)

w = Button(root,text="2", command=two,fg="cornsilk2", bg="#383a39")
w.grid(row=0, column=2)

w = Button(root,text="3", command=three,fg="cornsilk2", bg="#383a39")
w.grid(row=0, column=3)

w = Button(root,text="4", command=four,fg="cornsilk2", bg="#383a39")
w.grid(row=1, column=1)

w = Button(root,text="5", command=five,fg="cornsilk2", bg="#383a39")
w.grid(row=1, column=2)

w = Button(root,text="6", command=six,fg="cornsilk2", bg="#383a39")
w.grid(row=1, column=3)

w = Button(root,text="7", command=seven,fg="cornsilk2", bg="#383a39")
w.grid(row=2, column=1)

w = Button(root,text="8", command=eight,fg="cornsilk2", bg="#383a39")
w.grid(row=2, column=2)

w = Button(root,text="9", command=nine,fg="cornsilk2", bg="#383a39")
w.grid(row=2, column=3)

w = Button(root,text="0", command=zero,fg="cornsilk2", bg="#383a39")
w.grid(row=3, column=2)

showinfo("Begin Game.","You have 5 minutes to crack the lock before the police catch you,\nYou also have 10 attempts at guessing the code before the vault seals\nGood Luck!")

counter = 300
button_label = StringVar()
button_label.set(counter)
time = Button(root, textvariable=button_label,fg="cornsilk2", bg="#383a39")
time.grid(row=3, column=6)
button_countdown(counter, button_label) 

root.mainloop()
