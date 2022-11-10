# 1. 사용자가 입력한 단어의 끝에 'ing' 추가하는 프로그램

mystr = input("입력 단어 : ")

mystr = mystr + "ing"

print("출력 단어 : ",end='')
print(mystr)

# 2. 사용자가 입력한 단어의 길이가 2보다 크면 문자열 끝에 'ing' 추가하고
# 그렇지 않으면 입력한 단어를 그대로 출력하는 프로그램

mystr = input("입력단어 : ")

if (len(mystr) > 2):
    mystr = mystr + "ing"
    
print("출력 단어 : ",end = '')
print(mystr)

# 3. 사용자가 입력한 단어의 끝에 'ing' 추가하는 프로그램
# 단, 입력한 단어가 'ing'로 끝나면 'ly' 추가

mystr = input("입력 단어 : ")

if (mystr.endswith("ing") == True):
    mystr = mystr + "ly"
else:
    mystr = mystr + "ing"
    
print("출력 단어 : ",end = '')
print(mystr)

# 4. 주어진 문장에서 '가을'을 찾아 'autumn'으로 변경

mystr = '봄 여름 가을 겨울'

print("문장 : ",end = '')
print(mystr)

mystr = mystr.replace('가을','autumn')

print("변경 문장 : ",end = '')
print(mystr)