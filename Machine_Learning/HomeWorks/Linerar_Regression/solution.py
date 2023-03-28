import numpy as np
import pandas as pd
import statistics
import matplotlib.pyplot as plt
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


def split_test_data(type):
    a = randomYearsFromDF()
    b = randomYearsFromDF()
    c = randomYearsFromDF()

    a_train_ds, a_test_ds, \
        b_train_ds, b_test_ds, \
        c_train_ds, c_test_ds = train_test_split(a, b, c)

    if type == "train":
        return a_train_ds, b_train_ds, c_train_ds
    elif type == "test":
        return a_test_ds, b_test_ds, c_test_ds


def two_a():

    a, b, c = split_test_data('test')
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
        standard_deviation = statistics.stdev(data)
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


def three(type):
    a, b, _ = split_test_data("train")
    regression_gdp = linear_model.LinearRegression(fit_intercept=True)
    regression_total_exp = linear_model.LinearRegression(fit_intercept=True)
    regression_alcohol = linear_model.LinearRegression(fit_intercept=True)
    totexpen = 'Total expenditure'
    gdp = regression_gdp.fit(a[['GDP']], b[['GDP']])
    total_exp = regression_total_exp.fit(a[[totexpen]], b[[totexpen]])
    alcohol = regression_alcohol.fit(a[['Alcohol']], b[['Alcohol']])

    if type == 'model':
        return gdp, total_exp, alcohol
    elif type == 'data':
        return a, b


def four():

    gdp, total_exp, alchol = three('model')

    print(gdp.coef_, gdp.intercept_)
    print(total_exp.coef_, total_exp.intercept_)
    print(alchol.coef_, alchol.intercept_)

    x, y = three('data')

    plt.style.use('default')
    plt.style.use('ggplot')

    x_data_pred = np.linspace(0, x[['GDP']])

    x_data_pred = x_data_pred.reshape(-1, 1)
    y_data_pred = gdp.predict(x_data_pred)

    plt.style.use('ggplot')

    figure, ax = plt.subplots(figsize=(7, 3.5))
    ax.plot(x_data_pred, y_data_pred, color='r',
            label='Regression line', linewidth=4, alpha=0.5)
    ax.scatter(x[['GDP']], y[['GDP']], edgecolor='k',
               facecolor='Turquoise', alpha=0.7, label='data')
    ax.set_ylabel('GDP/y', fontsize=16)
    ax.set_xlabel('GDP/x', fontsize=16)
    ax.legend(facecolor='white', fontsize=11)
    ax.text(
        0.55, 0.15, f'$GDP/y = {round(gdp.coef_[0][0],4)} - GDP/x {round(abs(gdp.intercept_[0]),2)} $', fontsize=17, transform=ax.transAxes)
    figure.tight_layout()
    plt.show()


def five():
    pass


def main():
    # two_c()
    # three()
    # three()
    four()


if __name__ == '__main__':
    main()
