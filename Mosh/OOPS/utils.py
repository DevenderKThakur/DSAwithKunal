def find_max_num(number):
    max = number[0]
    for item in number:
        if max < item :
            max = item 
    return max 