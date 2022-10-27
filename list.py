# 7-1
list_a = [100,20.5,"파이썬","가을",True]

print(list_a)

list_a[0] = 2022

print(list_a)

# 7-2
a = [10,20]
b = [30,40,50]
c = a+b
d = a*2
e = len(a)

print("리스트 a와 b 연결 : ",c)
print("리스트 a를 두번 반복 : ",d)
print("리스트 a 길이 : ",e)

#7-3
a = [10,20,30]
print("1) 리스트 a : ",a)

a.append(40)
a.append(50)
print("2) 40과 50 추가 : ",a)

a.insert(1,-100)
print("3) 2번째 위치에 -100 추가 : ",a)

#7-4
num = [3,10,102,32,205,12]

for elemental in num:
    if elemental > 100:
        print("100이상인 수 :",elemental)

#7-5
a = [0,0,0,0,0]
hap,avg = 0,0.0

for i in range(0,5):
    a[i] = int(input(str(i+1) + "번째 숫자 : "))
    hap += a[i]

avg = hap / len(a)

print("평균 ==> %3.1f"%avg)

#7-6
a = [0,0,0,0,0]

for i in range(0,5):
    a[i] = int(input(str(i+1) + "번째 숫자: "))
    if a[i-1] > a[i]:
        min = a[i]
    elif a[i-1] < a[i]:
        max = a[i] 

print("최소 %d,최대 %d"%(min,max))