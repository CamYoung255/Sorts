# function for the bubble sort algorithm

def BubbleSort(list_temp):
    index_length = len(list_temp) - 1
    is_sorted = False

    # loops until the list is sorted, this is done by counting how many times a number is succeeded by a larger
    # number, if this is the same as the length of the list then the list must have been sorted

    while not is_sorted:

        sorted_count = 0

        # loops through the whole array

        for i in range(index_length):

            # if the number after the current number is less than current number than they are swapped, if not one is
            # added to the sorted counter

            if list_temp[i] > list_temp[i + 1]:
                list_temp[i], list_temp[i + 1] = list_temp[i + 1], list_temp[i]

            else:
                sorted_count += 1

        # if the sorted count is equal to the length then the list must be sorted and then the loop will end,
        # if not then the loop will continue

        if sorted_count == index_length:
            is_sorted = True

# function for the insertion sort algorithm

def InsertionSort(list_temp):

    # this loops though the whole array from one to the end

    for i in range(1, len(list_temp)):
        key = list_temp[i]
        position = i-1

        # loops while the position is greater than 0 and while the original value (key) is greater than the value
        # before it (position)

        while position >= 0 and key < list_temp[position]:

            # while this loop is happening the value is moved up the list

            list_temp[position + 1] = list_temp[position]
            position -= 1

        # once this is done it sets the key to the next value

        list_temp[position + 1] = key

# procedure for performing a binary search

def BinarySearch(list_temp, item):
    begin_index = 0
    end_index = len(list_temp) - 1

    # loops between the start and end of the section

    while begin_index <= end_index:

        # assigns midpoint, // 2 ensures there is no remainder

        midpoint = begin_index + (end_index - begin_index) // 2
        midpoint_value = list_temp[midpoint]

        # returns where the number that was specified is in the array, if ti si not found then the end index or begin
        # index will be changed accordingly.
        # if the number is lower than the midpoint then the start index is changed
        # and the the opposite is true the start index is changed

        if midpoint_value == item:
            return midpoint

        elif midpoint_value > item:
            end_index = midpoint - 1

        else:
            begin_index = midpoint + 1


List = [3, 6, 2, 5, 7, 4, 8, 1, 9, 0]

print(List, " is the whole list of numbers used in this demonstration\n")
BubbleSort(List)
print("Using the bubble sort function the results are:", List, "\n")

List = [3, 6, 2, 5, 7, 4, 8, 1, 9, 0]

InsertionSort(List)
print("Using the insertion sort function the results are:", List, "\n")

value1 = BinarySearch(List, 9)
value2 = BinarySearch(List, 3)
value3 = BinarySearch(List, 6)

print("Using a binary search for the values 9, 3 and 6 the results are:", str(value1) + ",", value2, "and", value3)
