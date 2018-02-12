name = 'Zed A. Shaw'
age = 35
height = 74.0
weight = 180.0
eyes = 'Blue'
teeth = 'White'
hair = 'Brown'

height_cm = height * 2.54
weight_kg = weight * 0.453592

print "Let's talk about %s." % name
print "He's %r centimeters tall." % height_cm
print "He's %r Kilograms heavy." % weight_kg
print "Actually that's not too heavy"
print "He's got %s eyes and %s hair." % (eyes, hair)
print "His teeth ares usually %s dependung on the coffee." % teeth

#tricky line
print "If I add %d, %r, and %r I get %r." % (age, height_cm, weight_kg, age + height_cm + weight_kg)
