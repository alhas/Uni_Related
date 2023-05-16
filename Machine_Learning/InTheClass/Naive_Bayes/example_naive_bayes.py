import pandas as pd
import matplotlib.pyplot as plt

from sklearn.model_selection import train_test_split
from sklearn.naive_bayes import BernoulliNB
from sklearn.naive_bayes import GaussianNB

colnames = ['preg', 'plas', 'pres', 'skin', 'test', 'mass', 'pedi', 'age', 'class']
pima_df = pd.read_csv("diabetes.csv", names= colnames, header=1)

X = pima_df.drop("class", axis = 1)
X = pima_df[['preg', 'plas', 'pres', 'skin', 'test', 'mass', 'pedi', 'age']]
Y = pima_df[['class']]
X_train, X_test, Y_train, Y_test = train_test_split(X,Y, test_size= 0.2, random_state = 2)

from sklearn.preprocessing import StandardScaler
sc = StandardScaler()
X_train = sc.fit_transform(X_train)
X_test = sc.transform(X_test)

model = BernoulliNB()
model.fit(X_train, Y_train)
Y_pred = model.predict(X_test)

# make predictions
predicted = model.predict(X_test)
from sklearn.metrics import accuracy_score, confusion_matrix
print(confusion_matrix(predicted, Y_test))
print(accuracy_score(predicted, Y_test))


y_predictProb = model.predict_proba(X_test)
from sklearn.metrics import auc, roc_curve
fpr, tpr, thresholds = roc_curve(Y_test, y_predictProb[::,1])
roc_auc = auc(fpr, tpr)
roc_auc
plt.plot(fpr, tpr, color='darkorange', label='ROC curve - Beroulli (area = %0.2f)' % roc_auc)
plt.plot([0, 1], [0, 1], linestyle='--')
plt.xlabel('False Positive Rate')
plt.ylabel('True Positive Rate')
plt.title('Receiver operating characteristic')
plt.legend(loc="lower right")
#plt.show()



model = GaussianNB()
model.fit(X_train, Y_train)
Y_pred = model.predict(X_test)

# make predictions
predicted = model.predict(X_test)
from sklearn.metrics import accuracy_score, confusion_matrix
print(confusion_matrix(predicted, Y_test))
print(accuracy_score(predicted, Y_test))


y_predictProb = model.predict_proba(X_test)
from sklearn.metrics import auc, roc_curve
fpr, tpr, thresholds = roc_curve(Y_test, y_predictProb[::,1])
roc_auc = auc(fpr, tpr)
roc_auc
plt.plot(fpr, tpr, color='darkred', label='ROC curve - Gaussian (area = %0.2f)' % roc_auc)
plt.plot([0, 1], [0, 1], linestyle='--')
plt.xlabel('False Positive Rate')
plt.ylabel('True Positive Rate')
plt.title('Receiver operating characteristic - gaussian')
plt.legend(loc="lower right")
plt.show()
