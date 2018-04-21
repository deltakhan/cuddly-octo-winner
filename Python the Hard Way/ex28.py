print "1. True and True  |= %r" % (True and True)              #True
print "2. False and True  |= %r" % (False and True)            #False
print "3. 1 == 1 and 2 == 1  |= %r" % (1 == 1 and 2 == 1)      #False
print "4. \"test\" == \"test\"  |= %r" % ("test" == "test")    #True
print "5. 1 == 1 or 2 == 1  |= %r" % (1 == 1 or 2 == 1)        #True
print "6. True and 1 == 1  |= %r" % (True and 1 == 1)          #True
print "7. False and 0 != 0  |= %r" % (False and 0 != 0)        #False
print "8. True or 1 == 1  |= %r" % (True or 1 == 1)            #True
print "9. \"test\" == \"testing\"  |= %r" % ("test" == "testing") #False
print "10. 1 !=0 and 2 == 1  |= %r" % (1 !=0 and 2 == 1)        #False
print "11. \"test\" != \"testing\"  |= %r" % ("test" != "testing") #True
print "12. \"testing\" == 1  |= %r" % ("test" == 1)              #False
print "13. not (True and False)  |= %r" % (not (True and False)) #True
print "14. not (1 == 1 and 0 != 1)  |= %r" % (not (1 == 1 and 0 != 1)) #False
print "15. not (10 == 1 or 1000 == 1000)  |= %r" % (not (10 == 1 and 1000 == 1000)) #True
print "16. not (1 != 10 or 3 == 4) |= %r" % (not (1 != 10 or 3 == 4)) # False
print "17. not (\"testing\" == \"testing\" and \"Zed\" == \"Cool Guy\")  |= %r" % (not ("testing" == "testing" and "Zed" == "Cool Guy")) #True
print "18. 1 == 1 and (not (\"testing\" == 1 or 1 == 0))  |= %r" % (1 == 1 and (not ("testing" == 1 or 1 == 0)) ) #True
print "19. \"chunky\" == \"bacon\" and (not (3 == 4 or 3 == 3)) |= %r" % ("chunky" == "bacon" and (not (3 == 4 or 3 == 3))) #False
print "20. 3 == 3 and (not (\"testing\" == \"testing\" or \"Python\" == \"Fun\"))   |= %r" % (3 == 3 and (not ("testing" == "testing" or "Python" == "Fun"))) #Fasle
