import pandas as pd
from sklearn.cluster import KMeans
from sklearn.preprocessing import StandardScaler

class Clustering:

    def __init__(self, data):
        self.data = data

    def read_data(self):
        return pd.read_csv(self.data,sep='    ')

    def k_means_centroid_init(self):
        _data = self.read_data()
        kmeans = KMeans()
        kmeans.fit(_data)


class Main:

    s1_cluster = Clustering('s1.txt')

    print(type(s1_cluster.k_means_centroid_init()))

    # s2_cluster = Clustering('s2.txt')
    # s3_cluster = Clustering('s3.txt')
    # s4_cluster = Clustering('s4.txt')
