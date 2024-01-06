def greet_user(name):
    print (f"Hi , {name} ")
    print ("Welcome Aboard")

# print ("start")
# greet_user("Devender")
# greet_user("Rohan")
# print("End!")
    
def square(number):
    return number * number 
# print (square(12))

def convert_emoji(message):
    words = message.split(" ")
    emoji = {
    ":)" : "😀",
    ":(" : "😀"
    }
    output = ""
    for word in words:
        output += emoji.get(word,word) + " "
    return output     
print(convert_emoji("Good Morning :)"))
