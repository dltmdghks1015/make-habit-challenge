# 6-1
i, sum = 0,0
num = 0

num = int(input("값 :"))

for i in range(1,num+1,2):
    sum += i

print("1 ~ %d 합계 : %d"%(num,sum))

# 6-2
i, sum = 0,0
num = 0
count = 0

num = int(input("값 : "))

for i in range(1,num+1,2):
    sum += i
    count += 1

print("1 ~ %d 홀수 합계 : %d, 갯수 %d"%(num,sum,count))

# 6-3

i,sum = 0,0
num1,num2 = 0,0
count = 0

num1 = int(input("시작값 : "))
num2 = int(input("종료값 : "))

for i in range(num1,num2+1,1):
    if (i % 2) == 1:
        sum += i
        count += 1

print("%d ~ %d 홀수 합계 : %d, 갯수 %d"%(num1,num2,sum,count))

# 6-4

i = 0
num1,num2 = 0,0

num1 = int(input("시작값 : "))
num2 = int(input("종료값 : "))

for i in range(num1,num2,1):
    if (i % 2) == 1:
        print(i)

# 6-5

i = 0
num1,num2 = 0,0
count = 0

num1 = int(input("시작값 : "))
num2 = int(input("종료값 : "))

for i in range(num1,num2,1):
    if (i % 2) == 1:
        count += 1
    
print("%d ~ %d 홀수 갯수 : %d"%(num1,num2,count))

for i in range(0,count,1):
    print("* ")

# 6-6

i = 0
age,total,avg = 0,0,0.0

for i in range(0,3,1):
    age = int(input("나이 : "))
    total += age

avg = total / 3

print("3명의 평균 나이 %3.1f"%(avg),end = '')

# 6-7

i,num = 0,0
age,total,avg = 0,0,0.0

num = int(input("사람수 : "))

for i in range(0,num,1):
    age = int(input("나이 : "))
    total += age

avg = total / num

print("%d명의 평균 나이 %3.1f"%(num,avg),end='')

# 6-8

i,num = 0,0
age,total,avg = 0,0,0.0
max = 0

num = int(input("사람수 : "))

for i in range(0,num,1):
    age = int(input("나이 : "))
    total += age
    if max < age:
        max = age
    
avg = total / num

print("%d명의 평균 나이 %3.1d,최고령 %d"%(num,avg,max),end = '')

# 6-9

i,num = 0,0
age,total,avg = 0,0,0.0
max,min = 0,100

num = int(input("사람수 : "))

for i in range(0,num,1):
    age = int(input("나이(1~99) : "))
    if age > 99 or age < 1:
        print("범위에 맞지 않은 나이가 입력 됐습니다.\n 다시 입력해주세요")
        i -= 1
    else:
        total += age
        if max < age:
            max = age
        elif min > age:
            min = age

avg = total / num

print("%d명의 평균 나이 %3.1f,최고령 %d,최연소 %d"%(num,avg,max,min),end='')
