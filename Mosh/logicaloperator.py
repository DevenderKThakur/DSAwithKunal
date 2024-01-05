has_high_income = True 
has_good_credit = True 

if has_high_income and has_good_credit: # both true 
    print ("Eligible for loan")
elif has_good_credit or has_high_income: # one should be true 
    print ("Eligible for loan")


# not operator changes to boolean val 