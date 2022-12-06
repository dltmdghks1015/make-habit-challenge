# 6-16 사람수와 나이를 입력받아 평균 나이 출력
i,num = 0,0
age,tot,avg = 0,0,0.0

	num = int(input("사람수 : "))

while i < num:
    age = int(input("나이 : "))
    tot += age
    i = i + 1

avg = tot / num

print("%d명의 평균 나이 %3.1f"%(num,avg),end = '')

# 6-17 사람수와 나이를 입력받아 평균 나이와 최고령 출력
i,num = 0,0
age,tot,avg = 0,0,0.0
max = 0

num = int(input("사람수 : "))

while i < num:
    age = int(input("나이 : "))
    tot += age
    if max < age:
        max = age
    i = i + 1

print("%d명의 평균 나이 %3.1f,최고령 %d"%(num,avg,max),end = '')

# 6-18 사람수와 나이(1~99)를 입력받아 평균 나이와 최고령, 최연소 출력
i,num = 0,0
age,tot,avg =0,0,0.0
max,min = 0,100

num = int(input("사람수 : "))

while i < num:
    age = int(input("나이(1~99) : "))
    if age < 1 or age > 99:
        print("범위에 맞지 않는 나이입니다")
    else:
        tot += age
        if max < age:
            max = age
        if min > age:
            min = age
    i = i + 1

avg = tot / num

print("%d명의 평균나이 %3.1f,최고령 %d,최연소 %d"%(num,avg,max,min),end='')
# 6-19 0을 입력할 때까지 반복 입력받아 출력
num = 0

while(True):
    num = int(input("정수(0:입력종료): "))
    if num == 0:
        break
    else:
        print("입력한 수 : %d"%(num))

