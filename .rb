############################################################
# Hashes
############################################################

# -------------------------------------------------------- #

# -------------------------------------------------------- #

############################################################
# Arrays
############################################################

# -------------------------------------------------------- #

text_editor = ["vim"]
nemesis = ["vim"]
text_editor == nemesis  # true

# -------------------------------------------------------- #

first = ["cool", "busta", "odb"]
second = ["puffy", "cool", "busta"]
first - second
# => ["odb"]

# -------------------------------------------------------- #

first = ["cool", "busta", "odb"]
second = ["puffy", "cool", "busta"]
(first + second).uniq   # ["cool", "busta", "odb", "puffy"]

# -------------------------------------------------------- #

manly = ['batman', 'manbot', 'mace', 'tulip', 'nah man, nah']
manly.grep /man/
# or 
manly.select {|x| x.include?('man')}
# => ["batman", "manbot", "nah man, nah"]

# -------------------------------------------------------- #

days = ['mon', 'tues', 'wed', 'thur', 'fri']
days.values_at(0, 2)
# => ["mon", "wed"]

# -------------------------------------------------------- #

############################################################
#1 super
############################################################

# super() - No arguments
# super   - equals arguments 

############################################################
#2 and or && ||
############################################################

val1 = true and false    # true
val2 = true && false     # false


############################################################
#3 true false
############################################################

true    ? "true" : "false" # true
false   ? "true" : "false" # false
nil     ? "true" : "false" # false (but nil != false)
1       ? "true" : "false" # false
0       ? "true" : "false" # false
"false" ? "true" : "false" # true
""      ? "true" : "false" # true
[]      ? "true" : "false" # true


############################################################
#4
############################################################

sum 1, 2
sum(1, 2)
sum (1, 2) # syntax error, unexpected ',', expecting ')' sum (1, 2)


############################################################
#5 ==, ===, eql?, equal?
############################################################

str = 'yee'
label_str = str
copy_str = 'yee'

str == copy_str       # true
person1 == person2    # false (working like equal?) need to override

(1..5) === 3          # true
(1..5) === 6          # false

Integer === 42        # true
Integer === 'yee'     # false

/ell/ === 'Hello'     # => true
/ell/ === 'Foobar'    # => false

str.eql?(label_str)   # true
str.eql?(copy_str)    # true
1.eql?(1.0)           # false (Int not Float)

str.equal?(label_str) # true
str.equal?(copy_str)  # false

# Only Symbol (because singleton)
a = :test
b = :test
a.equal?(b)           # true


############################################################
#6 +=, concat()
############################################################

x = 'yee'
y = x

x.concat('BOO') # y => 'yeeBOO'
x += 'BOO' # y => 'yee'


############################################################
#7 extend ( class methods ), include ( instance methods )
############################################################


############################################################
#8 How many types of variables?
############################################################

# 1. class variables @@
# 2. instance variables @
# 3. global variables $
# 4. local variables _


############################################################
#9 each vs map
############################################################

array.each { |n| n * 2 }
# [1, 2, 3]
array.map { |n| n * 2 }
# [2, 4, 6]


############################################################
#10 kind_of? vs. instance_of? vs. is_a?
############################################################

# kind_of? and is_a? are synonymous.
"hello".is_a? Object        # true
"hello".kind_of? Object     # true
"hello".instance_of? Object # false (Only exact class, not a subclass.)