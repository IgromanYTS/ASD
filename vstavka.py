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
print(list)
#list = [5, -3, -5]
move = 0
compare = 0
for i in range(1, len(list)):
    last_el = list[i]

    while i > 0 and list[i - 1] > last_el:
        list[i] = list[i - 1]
        i = i - 1
        move = move + 1
        compare = compare + 1
    list[i] = last_el
    compare = compare + 1

end = time.time() - start

print(list)
print("К-ть кроків:", move, "К-ть порівнянь:", compare)
print("Час роботи програми: ", end)
