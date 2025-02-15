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
# list = [3, -2, 1]
n = len(list)
move = 0
compare = 0
step = n//2
while step > 0:
    for i in range(step, n):
        compare = compare + 1
        l = i
        while i>=step and list[i]<list[i-step]:
            list[i], list[i-step] = list[i-step], list[i]
            move = move +1
            compare = compare + 1
            i=i-step
    step = step//2


end = time.time() - start
print(list)
print("Час роботи програми: ", end)
print("К-ть кроків:", move, "К-ть порівнянь:", compare)
