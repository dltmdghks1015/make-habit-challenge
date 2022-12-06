money = int(input("돈을 넣어주세요"))
while True:
    juice = input("음료를 골라주세요")
    temp = money
    if juice == "포도주스":
        #포도주스 100원
        print("포도주스를 선택하셨습니다. 남은 거스름돈은",money-100,"원 입니다")
        money = temp-100
        if money <= 0:
            break
    elif juice == "오렌지주스":
        #오렌지주스 200원
        print("오렌지주스를 선택하셨습니다. 남은 거스름돈은",money-200,"원 입니다")
        money = temp-200
        if money <= 0:
            break
    elif juice == "환타":
        #환타 300원
        print("환타를 선택하셨습니다. 남은 거스름돈은",money-300,"원 입니다")
        money = temp-300
        if money <= 0:
            break
    else:
        #없는 번호
        print("없는 음료입니다. 다시 입력해주세요")