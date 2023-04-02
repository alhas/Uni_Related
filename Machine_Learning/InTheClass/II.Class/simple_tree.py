import sklearn
import matplotlib.pyplot as plt
from sklearn import tree

# [Temp, Humidity]
X = [[20, 100], [30, 80], [15, 50], [20, 60], [100, 20], [80, 80], [70, 0], [130, 0]]
# 0 - 'no'
# 1 - 'yes'
y = ['no', 'no', 1, 1, 'no', 'no', 'no', 1]

clf = tree.DecisionTreeClassifier(criterion='entropy', min_samples_leaf=2)
clf = clf.fit(X, y)
tree.plot_tree(clf, filled=True)
plt.show()

print(clf.predict([[25, 70], [40, 100], [0,0]]))