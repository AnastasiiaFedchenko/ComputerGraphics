from sys import argv
script, file_name_in, file_name_out = argv

file_in = open(file_name_in, "r")
file_out = open(file_name_out, 'w')
lines = file_in.readlines()

index_x, index_y = 0, 0
for line in lines:
    for i in range(2):
        index_x = line.index("X=", 0)
        index_x += 2
        str_x = ""
        while(line[index_x].isdigit() or line[index_x] == '-'):
            str_x = str_x + line[index_x]
            index_x += 1
        #print(str_x, end=' ')
        file_out.write(str_x + " ")
        #print(str_x + " ", file_out)

        index_y = line.index("Y=", 0)
        index_y += 2
        str_y = ""
        while (line[index_y].isdigit() or line[index_y] == '-'):
            str_y = str_y + line[index_y]
            index_y += 1
        #print(str_x, end=' ')
        file_out.write(str_y + " ")
        line = line.replace("X=", " ", 1)
        line = line.replace("Y=", " ", 1)
        #print(line)
    #print()
    file_out.write("\n")

file_in.close()
file_out.close()
