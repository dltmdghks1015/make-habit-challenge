# 4-1 : 함수(calc_kmTom) 이용하여 km -> m 로 변환하기

## 함수 정의

def calc_kmTom(km):
    m = km * 1000
    print("%.2fkm를 m로 변환 하면 %dm"%(km,m))
    
calc_kmTom(2.5)

# 4-2 : 함수(calc_circle) 이용하여 원 넓이와 둘레 구하기

## 함수 정의

def calc_circle(r):
    PI = 3.14
    radius = (2 * PI * r)
    area = (PI * r * r)
    print("반지름이 %d 인 원의 면적은 %f,둘레는 %f"%(r,area,radius))
    
calc_circle(5)    

# 4-3 : 함수(calc_rectangle) 이용하여 사각형 넓이 구하기

## 함수 정의

def calc_rectangle(base,height):
    area = base * height
    print("가로 %d, 세로 %d인 사각형의 넓이 %d"%(base,height,area))
    
calc_rectangle(10, 20)

# 4-4 : 함수(calc_seconds) 이용하여 시간을 초로 환산하기

## 함수 정의

def calc_seconds(h,m,s):
    hts = h * 3600
    mts = m * 60
    sum = hts + mts + s
    print("%d시간 , %d분 , %d초 -> %d초"%(h,m,s,sum))
    
calc_seconds(2, 6, 30)

# 4-5 : 함수(calc_triangle) 이용하여 삼각형 넓이 구하기

## 함수 정의

def calc_triangle(val1,val2):
    area = (val1 * val2) / 2
    return area

val1 = 5
val2 = 10

result = calc_triangle(val1, val2)

print("밑변 %d, 높이 %d 인 삼각형의 넓이 %f"%(val1,val2,result))

# 4-6 : 함수 (calc_snack) 이용하여
# 새우깡 1개 가격과 구입 갯수 입력받아 총 구입 금액 계산

money = int(input("새우깡 가격은?"))
num = int(input("몇개 구입?"))

## 함수 정의

def calc_snack():
    result = money * num    
    print("새우깡 1개 가격은 %d, %d 개 구입, 총 구입금액은 %d"%(money,num,result))

calc_snack()

# 4-7 : 함수(calc_time) 이용하여 초 -> 시,분,초 로 계산하기

tot_sec = int(input("초를 입력해주세요"))

## 함수 정의

def calc_time(sec):
    resList = []
    hour = sec // 3600
    minute = (sec - (hour*3600)) // 60
    second = (sec - ((hour*3600)+(minute*60)))
    resList.append(hour)
    resList.append(minute)
    resList.append(second)
    return resList
        
## 메인 코드

myList = []

myList = calc_time(tot_sec)

hour = myList[0]
minute = myList[1]
second = myList[2]

print("%d 초 -> %d시간,%d분,%d초"%(tot_sec,hour,minute,second))