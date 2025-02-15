import random
import time

steps = int(input())
l = steps
start = time.time()
list = []
while l > 0:
    k = random.randint(1, 1000)
    list.append(k)
    l = l - 1
move=0 
compare=0 
size = len(list)
step = 1
while step < size / 3:
    step = (step * 3 + 1)  
while step > 0:
    for i in range(step, size):  
        value = list[i]  
        j = i  
        compare = compare + 1
        while (j > step - 1 and list[j - step] >= value):  
            move = move + 1
            list[j] = list[j - step]  
            j = j - step
            move = move + 1
        list[j] = (value)
    step = (step - 1) // 3

end = time.time() - start
print(list)
print("Час роботи програми: ", end)
print("К-ть кроків:", move, "К-ть порівнянь:", compare)
