#Generate Sound waves in volts
import csv
from random import randint

#Change these!
rvMax = 400
rvMin = 100
rN = 1
numWaves = 100

#Global Varriables
megaCount = 0
wave = []
neg1 = 0
neg2 = 0
pos1 = 0


print("Creating",numWaves,"wave(s) with max range of",rvMax/100, "and a min of",rvMin/100)

for i in range(0,numWaves+1):
    #variables
    tmp = []
    
    #Generate Random Numbers
    rM = randint(rvMin,rvMax)
    if i < 1:
        neg1 = -randint(rN, rM)
    else:
        neg1 = neg2
        
    pos1 = randint(100, rM)
    neg2 = -randint(rN, rM)

    #print(neg1,pos1,neg2)

    #Step up from first negative value to positive value
    count = 0
    for n in range(neg1, pos1+1):
        tmp=[megaCount,(neg1+count)/100]
        wave.append(tmp)
        count += 1
        megaCount+=1

    #Step down from positive number to second negative finishing wave
    count = pos1
    for t in range(neg2, pos1):
        tmp=[megaCount,(count-1)/100]
        wave.append(tmp)
        count -= 1
        megaCount+=1

#print(wave)

with open('wave.csv', 'w', newline='') as fp:
    a = csv.writer(fp, delimiter=',')
    a.writerows(wave)

print("Sucess! Output to wave.csv")
    

