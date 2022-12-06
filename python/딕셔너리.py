#7-7. 딕셔너리 생성, 길이, 추가, 수정, 삭제
# cafe 딕셔너리 생성 : (아메리카노,2000),(카푸치노,3000)

# cafe 딕셔너리 초기화하면서 생성
cafe = {'아메리카노':2000,'카푸치노':3000}
# cafe 출력
print(cafe)
# cafe 길이 출력
print(len(cafe))
# cafe에 메뉴 (스무디,3500) 추가 후 출력
cafe['스무디'] = 3500
print(cafe)
# 아메리카노 가격을 2500으로 수정 후 출력
cafe['아메리카노'] = 2500
print(cafe)
# 카푸치노 삭제 후 출력
del cafe['카푸치노']
print(cafe)
# 키에 해당하는 값 출력(반복문 사용)
for i in cafe.keys():
    print(i,"-->",cafe[i])

# 7-8. get() 함수 예제

# 딕셔너리 선언
dictionary = {"name":"건조 망고","type":"당절임","origin":"필리핀"}

# 키(name)에 접근 후 출력

value1 = dictionary.get("name")
print("값:",value1)

# 키(year)에 접근 후 출력
value2 = dictionary.get("키")
print("값:",value2)

# None 확인 방법

if (value1 == None or value2 == None):
    print("존재하지 않는 키에 접근했었음.")

# 7-9. in 키워드 예제

# 딕셔너리 선언
dictionary = {"name":"건조 망고","type":"당절임","origin":"필리핀"}

# 사용자로부터 키 입력 받기

key = input("> 접근하고자 하는 키:")

# 입력한 키에 해당하는 값 출력하고
# 없으면 '존재하지 않는 키에 접근'이라고 출력
if((key in dictionary) == False ):
    print("존재하지 않는 키에 접근.") 
else:
    print(dictionary[key])

# 7-10. 딕셔너리를 이용하여 친구들 이름과 핸드폰 번호 저장

contacts = {}

# 사용자로부터 이름과 핸드폰 번호 입력받아 딕셔너리에 저장
# 이름을 입력하지 않으면 그동안 저장한 연락처 출력
while(True):
    key = input("이름:")
    if (key == ""):
        break
    value = input("핸드폰 번호:")
    contacts[key]=value

print("연락처 ",contacts)

# 찾고자 하는 친구 이름 입력받아 핸드폰 번호 출력
name = input("친구 이름?")
if ((name in contacts) == False):
    print("핸드폰 번호 없음")
else:
    print(contacts[name])

# 7-11. 딕셔너리를 이용하여 편의점 재고 관리 프로그램
# 물건이 팔릴때마다 물건의 재고 출력

items = {"커피":7,"생수":3,"종이컵":10,"우유":5,"콜라":4,"사이다":11}

print("판매전 재고",items)

sell = input("판매한 물건은?")

if((sell in items) == False):
    print("판매제품이 아님")
    print("판매후 재고 :",items)
else:
    value = items[sell]
    value -= 1
    items[sell] = value
    print("판매후 재고 :",items)