n = 5
for i in range(n,0,-1):
    for j in range(i+1,0,-1):
        print(' ',end='')
    for k in range(1,(n-i+1)*2):
        print('*',end='')
    print()
for l in range(n,0,-1):
    for m in range(0,(n+3-l)):
        print(' ',end='')
    for p in range(1,(l-1)*2):
        print('*',end = '')
    print()