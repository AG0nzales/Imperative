# we declare an array with elements and write an inbuilt function of ruby 
a = [1, 2, 5, 10, 12, 15, 99]

puts
# we create a loop which will iterate through the array
a.each do |item|
    # we then insert a conditional statement if
    if item < 10
        # then we print if ever the condition is true
        puts item
    end
end