from sklearn.datasets import load_iris
from sklearn.model_selection import train_test_split
from sklearn import tree, metrics
from matplotlib import pyplot as plt
import statistics
from random import uniform
import numpy as np
from scipy.stats import sem


class NewIris:

    def __init__(self):
        self.data = load_iris()

    def __str__(self) -> str:
        return f"{self.data}"


class Main:
    # 2
    iris = NewIris()
    x = iris.data.data
    y = iris.data.target

    # 3
    x_train_ds, x_test_ds, \
        y_train_ds, y_test_ds = train_test_split(x, y, random_state=1)

    # 4
    clf = tree.DecisionTreeClassifier(criterion='entropy', min_samples_leaf=2)
    clf = clf.fit(x_train_ds, y_train_ds)

    # 5
    predicted_x_trained_data = clf.predict(x_train_ds)
    
    # 6
    predicted_x_tested_data = clf.predict(x_test_ds)

    # 7
    trained_accuracy_score = metrics.accuracy_score(
        predicted_x_trained_data, y_train_ds, normalize=True)
    tested_accuracy_score = metrics.accuracy_score(
        predicted_x_tested_data, y_test_ds, normalize=True)

    print(trained_accuracy_score)
    print(tested_accuracy_score)
    # 8
    """ The result obtained for the train data in this code is
    the accuracy score of the model on the data used for training.
    This accuracy score is calculated using the metrics.accuracy_score()
    function from scikit-learn library by comparing the predicted values
    of the model with the actual target values of the training data. """

    # 9 - 10 - 11
    def mean_stdev(self):
        test_iris = NewIris()
        _x = test_iris.data.data
        _y = test_iris.data.target

        data_for_calculation = []
        accuracy_scores = []
        sem_scores = []

        for i in range(1, 11):
            _x_train_ds, _, _y_train_ds, _ = train_test_split(
                _x, _y, random_state=i, test_size=0.25, train_size=uniform(0.0, 0.75))

            _clf = tree.DecisionTreeClassifier(
                criterion='entropy', min_samples_leaf=2)

            _clf = _clf.fit(_x_train_ds, _y_train_ds)

            _predicted_x_trained_data = _clf.predict(_x_train_ds)

            _trained_accuracy_score = metrics.accuracy_score(
                _predicted_x_trained_data, _y_train_ds, normalize=True)

            data_for_calculation.append(_trained_accuracy_score)
            accuracy_scores.append(np.mean(data_for_calculation))
            sem_scores.append(sem(data_for_calculation))

        print(f"Ten different value of random_state: {data_for_calculation}")
        print(f"Mean = {statistics.mean(data_for_calculation)}")
        print(f"Standart Deviation = {statistics.stdev(data_for_calculation)}")

        plt.errorbar(data_for_calculation, accuracy_scores,
                     yerr=sem_scores, fmt='o-', capsize=5)
        plt.xlabel("Ratio of training data")
        plt.ylabel("Accuracy score")
        plt.title("Accuracy vs Ratio of Training Data")
        plt.show()
    mean_stdev()

    # 12
    tree.plot_tree(clf, filled=True)
    plt.show()
