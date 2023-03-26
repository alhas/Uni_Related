import numpy as np
import pandas as pd
import math
import statistics
from random import randint
from sklearn import linear_model
from sklearn.model_selection import train_test_split


def dataFrame():
    dataF = pd.read_csv("LifeExpectancy.csv", header=0)
    return dataF


def randomYearsFromDF():
    dataF = dataFrame()
    random_year = dataF.loc[dataF['Year'] == randint(2000, 2015)]
    return random_year


def split_test_data():
    a = randomYearsFromDF()
    b = randomYearsFromDF()
    c = randomYearsFromDF()

    a_train_ds, a_test_ds, \
        b_train_ds, b_test_ds, \
        c_train_ds, c_test_ds = train_test_split(a, b, c)

    return a_test_ds, b_test_ds, c_test_ds


def two_a():
    a, b, c = split_test_data()
    list_of_data_sets = [a, b, c]

    for i, df in zip(['a', 'b', 'c'], list_of_data_sets):
        print(f'Size of the Data Frame {i}: {df.shape}')
    return list_of_data_sets


def two_b():

    data_sets = two_a()

    for i, df in zip(['A', 'B', 'C'], data_sets):
        data = df["Life expectancy"]
        mean = statistics.mean(data)
        median = statistics.median(data)
        standard_deviation = statistics.stdev(df["Life expectancy"])
        print(f"Mean of DataFrame is {i} = {mean} \n"
              f"Median of DataFrame is {i} = {median} \n"
              f"Standart Deviation of DataFrame is {i} = {standard_deviation} \n")
    return data_sets


def two_c():
    data_sets = two_b()
    for i, df in zip(['A', 'B', 'C'], data_sets):
        le = df["Life expectancy"]
        country = df['Country']
        year = df['Year']
        max_three = sorted(zip(year, country, le), reverse=True)[:3]
        print(
            f"Maximum Life Expectancy country in {i} are {max_three}")


def three_a():
    pass

def main():
    # one_a()
    # one_b()
    two_c()


if __name__ == '__main__':
    main()
