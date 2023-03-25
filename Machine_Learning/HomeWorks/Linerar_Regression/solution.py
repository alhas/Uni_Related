import numpy as np
import pandas as pd
import random
from sklearn import linear_model
from sklearn.model_selection import train_test_split


def dataFrame():
    dataF = pd.read_csv("LifeExpectancy.csv", header=0)
    return dataF


def randomYearsFromDF():
    dataF = dataFrame()
    year = random.randint(2000, 2015)
    random_year = dataF.loc[dataF['Year'] == year]
    return random_year


def split_test_data():
    a = randomYearsFromDF()
    b = randomYearsFromDF()
    c = randomYearsFromDF()

    a_train_ds, a_test_ds, \
        b_train_ds, b_test_ds, \
        c_train_ds, c_test_ds = train_test_split(a, b, c)

    return a_test_ds, b_test_ds, c_test_ds


def one_a():
    a, b, c = split_test_data()
    list_of_data_sets = [a, b, c]

    for i, df in zip(['a', 'b', 'c'], list_of_data_sets):
        print(f'Size of the Data Frame {i}: {df.shape}')

def oen_b():
    

def main():
    one_a()


if __name__ == '__main__':
    main()
