def func1():
    global a # 전역변수 선언
    a = 10
    print("func1()에서 a값 %d"%a)

def func2():
    print("func2()에서 a값 %d"%a)

a = 20

func1()
func2()