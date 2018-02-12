print "Type the filename:"
file = raw_input("> ")

txt = open(file)

print txt.read()
txt.close()
