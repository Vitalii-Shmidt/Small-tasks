import random


def get_random_values(rand_list):
    for i in range(100):
        rand_list.insert(i, random.randint(0, 99))
    return rand_list


def print_whole_list(print_list):
    print('List items:')
    for kek in print_list:
        print(kek)


def get_indexes(our_list, lower_bound, upper_bound):
    index = 0
    print('Indexes of elements that satisfy the conditions:')
    for item in our_list:
        if lower_bound < item < upper_bound:
            print(index)
        index += 1


def main():
    lower_bound = int(input('Enter lower bound, please:'))
    upper_bound = int(input('Enter upper bound, please:'))
    random_values_list = []
    get_random_values(random_values_list)
    print_whole_list(random_values_list)
    get_indexes(random_values_list, lower_bound, upper_bound)


if __name__ == '__main__':
    main()