input_weight = float (input ("Enter the Weight "))

check = input ("(L) for lbs and (K) for Kg ").lower()

if check == 'l':
    print (f"You are  {input_weight * 0.45}")
elif check == 'k':
    print (f"You are {input_weight  * 2.204}")
else:
    print ("Invalid input")