
import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt
import numpy as np
from sklearn.neighbors import KNeighborsClassifier
from sklearn.linear_model import LinearRegression
from sklearn.svm import SVR
import sys

train_file=sys.argv[1]
save_file = sys.argv[2]
to_pred= sys.argv[3]




data= train_file
data.drop(['Date'], axis=1, inplace=True)




from sklearn import preprocessing
scaler = preprocessing.MinMaxScaler()
names = data.columns
d = scaler.fit_transform(data)
scaled_data = pd.DataFrame(d, columns=names)
scaled_data.head()

from sklearn.model_selection import train_test_split
X = scaled_data[['Température Max (°c)',    'Température Min (°c)',    'température Moy (°c)',    'Humidité Moy (%)',    'Vent Max (Km/h)',    'Vent Moy(Km/h)',    'Visibilité moy (km)',    'Precipitation (mm)']].values
y = scaled_data[[to_pred]].values
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.20)


from sklearn.svm import SVR
from sklearn.multioutput import MultiOutputRegressor
mdl= SVR(kernel='poly')
mdl.fit(X_train,y_train)
score3=mdl.score(X_test,y_test)
print(score3)



import pickle
filename = '{}\\SVC_save{}.sav'.format(save_file)
pickle.dump(mdl, open(filename, 'wb'))