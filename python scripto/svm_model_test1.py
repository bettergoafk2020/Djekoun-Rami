import numpy as np
import pandas as pd
import matplotlib.pyplot as plt 
import datetime as dt
from sklearn.metrics import mean_squared_error
from sklearn.model_selection import train_test_split

data = pd.read_excel('C:/Users/MSI MODERN/Desktop/Données metéo (1)1.xlsx', 'Feuil1')
data['Date'] = pd.to_datetime(data['Date'])
data['Date']=data['Date'].map(dt.datetime.toordinal)

from sklearn import preprocessing
scaler = preprocessing.MinMaxScaler()
names = data.columns
d = scaler.fit_transform(data)
scaled_data = pd.DataFrame(d, columns=names)
scaled_data.head()