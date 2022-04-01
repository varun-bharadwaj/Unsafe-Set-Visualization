import scipy.io
import numpy
import csv

mat = scipy.io.loadmat("small-4d-unsafe-set.mat")
matGrid = mat["data"][:,:,:,:,-1]
output = matGrid[:,:,0,:]


f = open('output.csv', 'w', newline = '')
f.truncate()
writer = csv.writer(f)

for x in range (output.shape[0]):
    for y in range(output[x].shape[0]):
        for z in range(output[x][y].shape[0]):
            if(output[x,y,z] <= 0):
                row = [x,y,z,output[x,y,z]]
                writer.writerow(row)


