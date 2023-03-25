import numpy as np
import pandas as pd
import random
from sklearn import linear_model


def dataFrame():
    data = pd.read_csv("LifeExpectancy.csv", header=0)
    return data


def randomYearsFromDF():
    data = dataFrame()
    year = random.randint(2000, 2015)
    random_year = data.loc[data['Year'] == year]
    print(random_year)
    #randomYears = year[randrange(min(year), max(year))]
   


def main():
    randomYearsFromDF()


if __name__ == '__main__':
    main()
