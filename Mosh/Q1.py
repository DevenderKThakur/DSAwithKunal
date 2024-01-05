name = input ("Enter the name ")

length_of_name = len(name)

if length_of_name < 3  :
    print ("name must be at least 3 character long ")
elif length_of_name > 50 :
    print ("name can be maximum of 50 character ")
else :
    print ("name looks good")    