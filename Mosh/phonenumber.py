phone_number = {
    "1":"one",
    "2":"two",
    "3":"three",
    "4":"four",
    "5":"five",
    "6":"six",
    "7":"seven",
    "8":"eight",
    "9":"nine",
    "0":"zero"
}

value = input ("Enter the phone number : ")
output = ""
for ch in value :
    output+=phone_number[ch]+" "
print(output)
