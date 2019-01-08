
numbers = []


def ex33while(end_of_while, incrument):
    i = 0
    while i < end_of_while:
        print "At the top i is %d" % i
        numbers.append(i)

        i = i + incrument
        print "Numbers now: ", numbers
        print "At the bottom i is %d" % i


def ex33for(end_of_while):
        for i in range(0, end_of_while):
            print "At the top i is %d" % i
            numbers.append(i)
            print "Numbers now: ", numbers
            print "At the bottom i is %d" % i


# ex33while(7, 4)
ex33for(7)
print "The numbers: "

for num in numbers:
    print num
