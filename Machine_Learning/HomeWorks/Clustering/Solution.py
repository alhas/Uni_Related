import pandas as pd
from sklearn.cluster import KMeans
import matplotlib.pyplot as plt


class Clustering:

    def __init__(self, data: str, fig_name: str, color: str):
        self.data = data
        self.fig_name = fig_name
        self.color = color

    def read_data(self):
        data = pd.read_csv(self.data, header=None, delim_whitespace=True)
        return pd.DataFrame(data)

    def k_means_centroid_init(self):
        _data = self.read_data()
        _kmeans = KMeans(n_init='auto')
        _kmeans.fit(_data)
        return _kmeans.labels_, _kmeans.cluster_centers_

    def show_effect(self) -> plt:
        _labels, _cluster_centers = self.k_means_centroid_init()
        plt.scatter(_cluster_centers[:, 0], _cluster_centers[:, 1], color=self.color, linewidths=5)
        plt.xlabel('X')
        plt.ylabel('Y')
        plt.title('KMeans Clustering')
        plt.savefig(f'figures/{self.fig_name}')
        return plt.show


class Main:
    s1_cluster = Clustering('s1.txt', 's1', 'blue')
    s1_cluster.show_effect()

    s2_cluster = Clustering('s2.txt', 's2', 'black')
    s2_cluster.show_effect()

    s3_cluster = Clustering('s3.txt', 's3', 'purple')
    s3_cluster.show_effect()

    s4_cluster = Clustering('s4.txt', 's4', 'red')
    s4_cluster.show_effect()

    spiral_cluster = Clustering('spiral.txt', 'spiral', 'green')
    spiral_cluster.show_effect()


'''
Second and Fifth Questions Answer

Comparing the clustering quality between the four cases, 
it appears that the s1 and s2 files contain data points 
that are relatively close together, and the clustering 
algorithm has identified the main clusters well. However, 
the s3 and s4 files contain data points that are more spread out, 
and the clustering algorithm has identified fewer clusters

'''
