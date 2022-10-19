# 연산자 
# 1. 총 구매 금액 계산하기
unit = 500
count = 5

total = unit * count

print("%d원짜리 %d개 구입해서 총금액 : %d"%(unit,count,total))

# 2. 원의 면적과 둘레 구하기
PI = 3.14
r = 5

area = (r*r)*PI

circ = 2*PI*r

print("반지름이 %d인 원의 면적은 %d, 둘레는 %d"%(r,area,circ))

# 3. m를 km로 변환하기

m = 1250
km = m // 1000
km_m = m % 1000

print("%dm를 km로 변환하면 %dkm%dm"%(m,km,km_m))

# 4. 삼각형 넓이 구하기

base = 5
height = 3
area = (base*height)/2

print("밑변 %d,높이 %d인 삼각형 넓이 %d"%(base,height,area))

# 5. 사각형 둘레와 넓이 구하기

garo = 5
sero = 3
area = garo*sero
circ = (garo + sero)*2

print("가로 %d,세로 %d인 사각형 둘레 %d,넓이 %d"%(garo,sero,circ,area))

# 6. 시간을 초로 환산하기
h = 1
m = 1
s = 1
tot = (h*3600)+(m*60)+s

print("%d시간,%d분,%d초 -> %d초"%(h,m,s,tot))

# 7. 초 -> 시,분,초로 환산하기

tot_sec = 3661
h = tot_sec // 3600
m = (tot_sec-3600) // 60
s = tot_sec % 3660

print("%d초 -> %d시간,%d분,%d초"%(tot_sec,h,m,s))

# 8. 학년 입력받아 출력
year = int(input("몇 학년 : "))
print("%d학년"%(year))

# 9. 새우깡 1개 가격과 구입 갯수 입력받아 총 구입금액 계산

unit = int(input("새우깡 가격은?"))
count = int(input("몇개 구입?"))

total = unit * count

print("새우깡 1개 가격은 %d,%d개 구입,총 구입금액은 %d"%(unit,count,total))

# 10. 새우깡 가격과 개수 입력받아 총 금액, 거스름돈 계산하기

money = int(input("얼마있어요?"))
unit = int(input("새우깡 가격은?"))
count = int(input("몇개 구입?"))

total = unit * count

change = money - total

print("가지고 있는 돈은 %d원 구매금액은 %d원 거스름돈은 %d원"%(money,total,change))

# 11. m를 입력받아 km로 변환하여 출력하기

m = int(input("몇 미터?"))

km = m // 1000
km_m = m % 1000

print("%dm => %dkm %dm"%(m,km,km_m))

# 12. 10% 할인해주는 새우깡을 구입했을때의 구입 금액 계산

unit = int(input("새우깡 가격은?"))
count = int(input("몇개 구입?"))

total = unit * count

print("새우깡 1개 가격은 %d, %d개 구입, 할인받은 총 구입 금액은 %d"%(unit,count,total-(total//10)))
