# 전역 변수 선언

# 함수 선언

def coffee_machine(button):
    print()
    print("#1. (자동으로) 뜨거운 물 준비.")
    print("#2. (자동으로) 종이컵 준비")
    
    if button == 1:
        print("#3. (자동으로) 보통커피.")
    elif button == 2:
        print("#3. (자동으로) 설탕커피.")
    elif button == 3:
        print("#3. (자동으로) 블랙커피.")
    else:
        print("#3. (자동으로) 아무거나. \n")
        
    print("#4. (자동으로) 물 붓기")
    print("#5. (자동으로) 스푼으로 젓기.")
    print()
    
coffee = int(input("어떤 커피?(1:보통,2:설탕,3:블랙)"))
coffee_machine(coffee)
print("손님~ 커피 여기요.")