from collections import deque
import time

array = []


def unpaired(array):
    start = time.time()
    array = deque(array)
    new_array = []
    for l in range(len(array)):
        word_before = None
        word_next = None
        if l > 0:
            word_before = array[l - 1]

        if l < len(array) - 1:
            word_next = array[l + 1]

        new_array.append((word_before, array[l], word_next))
    # return new_array
    # a = new_array[len(array)-1][1]
    # return a
    length = []
    k = 1
    for k in range(len(new_array)):
        if k < len(new_array) and k % 2 != 0:
            length.append(k)
        k += 2

    # return length
    length_k = len(length)
    i = 0
    array2 = []
    array3 = []
    while i < length_k:
        array2.append(new_array[length[i]])
        i += 1
    # return array2

    len_array2 = len(array2)
    j = 0
    # for i in range(array2):
    #    if len[i] % 2 != 0:
    #        array3.append(i)
    #    i = i + 1
    while j < len_array2:
        g = 0
        while g < 3:
            if array2[j][g]!=None and len(array2[j][g]) % 2 != 0:
                array3.append(array2[j][g])
            g += 1
        j+= 1
    # return array3

    len_array3 = len(array3)
    array_final = []
    d = 0
    while d < len_array3:
        array_final.append(array3[d][1:-1]+",") 
        d+=1
    end = time.time() - start
    print("Час роботи програми: ", end)
    #return array_final
    #додаткове
    reverse = []
    #c=0
    reverse = [c[::-1] for c in array_final]
    return reverse
        

array = ["яблоко", "ананас", "апельсин", "груша", "картошк", "мандари"]
print(unpaired(array))
