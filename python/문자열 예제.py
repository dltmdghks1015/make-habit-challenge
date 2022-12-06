# 5. MM/DD/YY 형태이 날짜를 입력받아 YY/MM/DD 로 출력

date1 = input("날짜 입력(MM/DD/YY) : ")

date1_list = date1.split('/')

date_result = date1_list.pop()

date1_list.insert(0,date_result)

date2 = '/'.join(date1_list)

print("변환날짜(YY/MM/DD) : ",end='')
print(date2)

# 6. 단어(문자,숫자)가 공백으로 구분되는 문장에서 숫자 추출.

sentence = '2022 python 2 programming'

sentence_list = sentence.split()
res = []
for i in range(0,len(sentence_list)):
    if (sentence_list[i].isdigit() == True):
        res.append(sentence_list[i])

print("문장 : ",end='')
print(sentence)

print("숫자 추출 결과(리스트) : ",end='')
print(res)

# 7. 주어진 문장에서 가장 긴 단어를 출력하는 프로그램

sentence = "오래 보아야 사랑스럽다 너도 그렇다. 나태주"

print(sentence)

sentence_list = sentence.split()
longest_word = ""
for i in range(0,len(sentence_list)):
    if (len(longest_word) < len(sentence_list[i])):
        longest_word = sentence_list[i]

print("가장 긴 단어 : ",end='')
print(longest_word)

# 8. 주어진 문장에서 문자의 빈도를 계산하여 딕셔너리에 저장

sentence = 'Hello Hey'

sentence_list = []

dict = {}
for i in range(0,len(sentence)):
    sentence_list.append(sentence[i])
    
for j in range(0,len(sentence_list)):
    count = sentence.count(sentence_list[j])
    dict[sentence_list[j]] = count

print("문장 : ",end='')
print(sentence)

print("결과(딕셔너리) : ",end='')
print(dict)