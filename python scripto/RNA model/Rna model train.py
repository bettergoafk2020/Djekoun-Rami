import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns
from sklearn import metrics
from sklearn.neural_network import MLPRegressor
from sklearn.model_selection import train_test_split
import sys
import json
from keras.models import model_from_json, load_model


'''train_file=sys.argv[1]
test_file= sys.argv[2]
save_file = sys.argv[3]'''

data = pd.read_excel('C:/Users/MSI MODERN/Desktop/Données metéo (1)1.xlsx', 'Feuil1')

dataset_X = data[['Température Max (°c)',    'Température Min (°c)',    'température Moy (°c)',    'Humidité Moy (%)',    'Vent Max (Km/h)',    'Vent Moy(Km/h)',    'Visibilité moy (km)',    'Precipitation (mm)']].values
dataset_Y = data[['Température Max (°c)',    'Température Min (°c)',    'température Moy (°c)',    'Humidité Moy (%)',    'Vent Max (Km/h)',    'Vent Moy(Km/h)',    'Visibilité moy (km)',    'Precipitation (mm)']].values

dataset_X_train, dataset_X_test, dataset_Y_train, dataset_Y_test = train_test_split(dataset_X, dataset_Y, test_size=0.20)

from sklearn.preprocessing import StandardScaler

scaler = StandardScaler()
scaler.fit(dataset_X_train)
StandardScaler(copy=True, with_mean=True, with_std=True)
dataset_X_train = scaler.transform(dataset_X_train)
dataset_X_test = scaler.transform(dataset_X_test)



model = MLPRegressor(hidden_layer_sizes=(8,32,8), activation='relu',max_iter=500).fit(dataset_X_train, dataset_Y_train)

print('train score:',model.score(dataset_X_train,dataset_Y_train)) 
print('test score:',model.score(dataset_X_test,dataset_Y_test))



import pickle

path = 'C:\\Users\\MSI MODERN\\Desktop\\python folder\\modelmlp.sav'
pickle.dump(model, open(path, 'wb'))



predicted_classes =model.predict(dataset_X_test)