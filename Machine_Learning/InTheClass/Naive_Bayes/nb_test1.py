from sklearn.naive_bayes import BernoulliNB # or any other NB model
from sklearn.metrics import accuracy_score
from sklearn.metrics import confusion_matrix

X_train = [[0], [1], [0], [1], [0], [0]]
y_train = ["no", "yes", "no", "yes", "no", "yes"]
X_test = [[0], [1], [0], [0]]
y_test = ["no", "yes", "no", "yes"]


nb_classifier = BernoulliNB()
nb_classifier.fit(X_train, y_train)
y_pred = nb_classifier.predict(X_test)
acc_score = accuracy_score(y_test, y_pred)
conf_mat = confusion_matrix(
    y_test, y_pred, labels = ['no', 'yes'])

print(acc_score)
print(conf_mat)