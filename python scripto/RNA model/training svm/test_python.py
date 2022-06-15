from ast import Import
from os import execl
import sys
import numpy as np 
import pandas as pd
import sys
from sklearn.model_selection import train_test_split
from sklearn.svm import SVR
from sklearn.multioutput import MultiOutputRegressor
from sklearn import svm
from sklearn.svm import SVC

train_file=sys.argv[1]
test_file= sys.argv[2]


#Loading train data

data = pd.read_excel('C:/Users/MSI MODERN/Desktop/Données metéo (1)1.xlsx', 'Feuil1')

#Delete the date column
DA_TE = data['Date']
data.drop(['Date'], axis=1, inplace=True)

#Load test data
dfTest = pd.read_excel('C:/Users/MSI MODERN/Desktop/Données metéo (1)1.xlsx', 'Feuil1')
dfTest.drop(['Date'], axis=1, inplace=True)

import numpy as np
from sklearn import preprocessing

label_encoder = preprocessing.LabelEncoder() 
data['Température Max (°c)']= label_encoder.fit_transform(data['Température Max (°c)'])
dfTest['Température Max (°c)']= label_encoder.fit_transform(dfTest['Température Max (°c)']) 


#Separe the input & the output data
Y = data['Température Max (°c)']
X = data.drop(['Température Max (°c)'], 1)


YTest = dfTest['Température Max (°c)']
XTest = dfTest.drop(['Température Max (°c)'], 1)


X=X.values

X1=X #for the knn svm
XTest=XTest.values
Xpred = XTest[5,:]
X1test=XTest#for the knn svm
Xpred = Xpred.reshape(1,62)
#clf = svm.SVC()
#clf.fit(dfTest,DA_TE) 


mdlsg= SVC(kernel='poly',degree=1,C=727)
mdlsg.fit(X1,Y)
score3=mdlsg.score(X1test,YTest)
#prediction3= mdlsg.predict(Xpred)
print(score3)



import pickle
filename = '{}\\SVC_save{}.sav'.format(execl,score3)
pickle.dump(mdlsg, open(filename, 'wb'))




"""scaler = preprocessing.MinMaxScaler()
names = data.columns
d = scaler.fit_transform(data)
scaled_data = pd.DataFrame(d, columns=names)
scaled_data.head()

X = scaled_data[['Température Max (°c)',    'Température Min (°c)',    'température Moy (°c)',    'Humidité Moy (%)',    'Vent Max (Km/h)',    'Vent Moy(Km/h)',    'Visibilité moy (km)',    'Precipitation (mm)']].values
y = scaled_data[['température Moy (°c)']].values
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.20)



mdl= SVR(kernel='rbf')
mdl.fit(X_train,y_train)
mdl.score(X_test,y_test)

mdl.score (X_test ,y_test)

mdl.predict(X_test)"""