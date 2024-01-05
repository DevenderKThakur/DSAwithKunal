first_commnad = input("> Enter HELP to find the instruction")
if first_commnad.lower() == "help":
    message = '''start - to start the car \nstop - to stop the car \nquit to exit '''
    print (message)
else:
    print ("Invalid Instruction")

new_command = input ("> ").lower()
while new_command != 'quit' :
    if new_command == 'start':
        print ("Car Started .... Ready to go")
    elif new_command == 'stop':
        print ("Car stopped ...") 
    else:
        print ("I don't understand that ...")   
    new_command = input ("> ").lower()       
    

