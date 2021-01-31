# (2 * r * pi) / speed
import math


def main():
    r1 = float(input('Enter radius of first planet: '))
    speed1 = float(input('Enter speed of first planet: '))

    r2 = float(input('Enter radius of first planet: '))
    speed2 = float(input('Enter speed of first planet: '))

    year1 = (2 * r1 * math.pi) / speed1
    year2 = (2 * r2 * math.pi) / speed2

    if year1 > year2:
        print('Year on first planet longer')
    elif year1 == year2:
        print('Year on first and second planets are equals')
    else:
        print('Year on second planet longer')


if __name__ == '__main__':
    main()