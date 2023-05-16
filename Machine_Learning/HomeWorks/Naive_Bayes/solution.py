import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns
from sklearn.datasets import *
from sklearn.naive_bayes import BernoulliNB
from sklearn.metrics import confusion_matrix
from sklearn.preprocessing import StandardScaler
from sklearn.model_selection import train_test_split
import logging


class NaiveBayes:
    def __init__(self, mnist: str, version=1):
        self.cm = None
        self.mnist = mnist
        self.version = version
        self._mnist = self._download_mnist_save_log()
        self.mnist_data_train, \
            self.mnist_data_test, \
            self.mnist_target_train, \
            self.mnist_target_test = self._split_the_data()

    def _download_mnist_save_log(self):
        logging.warning("Mnist Download Started")
        fetched_mnist = fetch_openml(f'{self.mnist}', version=self.version, parser='auto')
        logging.info("Finished")
        with open('./mnist.log', 'w') as _file:
            _file.write(f"\nData {fetched_mnist.DESCR}")
            _file.write(f"Data shape {fetched_mnist.data.shape}")
        return fetched_mnist

    def _split_the_data(self):

        _mnist_data_train, \
            _mnist_data_test, \
            _mnist_target_train, \
            _mnist_target_test = train_test_split(self._mnist.data, self._mnist.target, test_size=0.5, random_state=30)

        return _mnist_data_train, _mnist_data_test, _mnist_target_train, _mnist_target_test

    def show_some_images(self):
        for i in range(9):
            plt.subplot(431 + i)
            plt.imshow(self._mnist.data.iloc[i].to_numpy().reshape(28, 28), cmap='gray')
            plt.title(f'Label: {self._mnist.target.iloc[i]}')
        plt.tight_layout(h_pad=0.5)
        plt.show()

    def preprocess_data(self):
        scaler = StandardScaler()
        data_train = scaler.fit_transform(self.mnist_data_train)
        data_test = scaler.transform(self.mnist_data_test)
        return data_train, data_test

    def bernoulli_naive_bayes(self):
        model = BernoulliNB()
        model.fit(self.mnist_data_train, self.mnist_target_train)
        target_prediction = model.predict(self.mnist_data_test)
        return target_prediction

    def confusion_matrix(self):

        target_prediction = self.bernoulli_naive_bayes()
        self.cm = confusion_matrix(self.mnist_target_test, target_prediction)
        plt.figure(figsize=(10, 10))
        sns.heatmap(self.cm, annot=True, fmt=".0f", square=True, cmap='Blues')
        plt.ylabel('True label')
        plt.xlabel('Predicted label')
        plt.title('Confusion Matrix')
        plt.show()

    def calculate_error_rate(self):
        errors = []
        for i in range(10):
            errors.append((self.cm[i, :].sum() - self.cm[i, i]) / self.cm[i, :].sum())
        error_df = pd.DataFrame(errors, columns=['Error rate'])
        print(error_df)


class Main:
    first_naive_bayes = NaiveBayes('mnist_784')
    first_naive_bayes.show_some_images()
    first_naive_bayes.confusion_matrix()
    first_naive_bayes.calculate_error_rate()
