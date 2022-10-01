weight = int(input("몸무게 입력 : "))
height = int(input("키 입력 : "))

height = height / 100
bmi = weight / (height*height)

if bmi <= 18.5:
    print("저체중")
elif bmi >= 25:
    print("비만")
elif 18.5 < bmi <= 22.9:
    print("정상")
elif 23 <= bmi <= 24.9:
    print("과체중")