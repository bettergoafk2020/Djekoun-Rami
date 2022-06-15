import pandas as pd
import numpy as np
import datetime as dt
from sklearn import preprocessing
import sys
import pickle


test_file= sys.argv[1]
model_path=sys.argv[2]

#Load test data
data = pd.read_excel('C:\Users\MSI MODERN\Desktop\python folder\Tests.xlsx')
data['Date'] = pd.to_datetime(data['Date'])
data.drop(['Date'], axis=1, inplace=True)
data['Date']=data['Date'].map(dt.datetime.toordinal)

from sklearn import preprocessing
scaler = preprocessing.MinMaxScaler()
names = data.columns
d = scaler.fit_transform(data)
scaled_data = pd.DataFrame(d, columns=names)
scaled_data.head()


from sklearn.model_selection import train_test_split
X = scaled_data[['Température Max (°c)',    'Température Min (°c)',    'température Moy (°c)',    'Humidité Moy (%)',    'Vent Max (Km/h)',    'Vent Moy(Km/h)',    'Visibilité moy (km)',    'Precipitation (mm)']].values
y = scaled_data[['Température Max (°c)']].values



new_SVC_model = pickle.load(open(path, 'rb')) 
result = new_SVC_model.predict(X_test)

ap=np.array





